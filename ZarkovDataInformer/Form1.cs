using ClosedXML.Excel;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ZarkovDataInformer
{
    public partial class Form1 : Form
    {
        DataTable _outputDataTable = new DataTable();
        IMongoCollection<BsonDocument> _collection = null;
        Dictionary<int, Dictionary<string, List<BsonDateTime>>> _dataCache = new Dictionary<int, Dictionary<string, List<BsonDateTime>>>();
        List<string> test_types = new List<string>();
        Dictionary<string, object> columns = new Dictionary<string, object>();
        string col = string.Empty;

        public Form1()
        {
            InitializeComponent();
            this.textBoxPort.KeyPress += new KeyPressEventHandler(textBoxPort_KeyPress);
        }

        private void connect_Server_On()
        {
            Cursor.Current = Cursors.WaitCursor;
            pictureBoxConnecting.Visible = true;
            comboBoxSevers.Enabled = false;
            textBoxPort.Enabled = false;
            Cursor.Current = Cursors.Arrow;
        }

        private void connect_Server_Off()
        {
            Cursor.Current = Cursors.Arrow;
            comboBoxTestType.DataSource = test_types;
            pictureBoxConnecting.Visible = false;
            comboBoxSevers.Enabled = false;
            textBoxPort.Enabled = false;
            comboBoxEndDate.Enabled = true;
            comboBoxTestType.Enabled = true;
            buttonShowData.Enabled = true;
            labelStatusDesc.Text = "Connected!!";
            labelStatusDesc.ForeColor = Color.Green;
            connect_Server.Text = "Disconnect";
            Cursor.Current = Cursors.WaitCursor;

        }

        private void connect_Server_Cancel()
        {
            pictureBoxConnecting.Visible = false;
            comboBoxSevers.Enabled = true;
            textBoxPort.Enabled = true;
            connect_Server.Enabled = true;
            labelStatusDesc.Text = "Failed!!";
            labelStatusDesc.ForeColor = Color.DarkRed;
        }

        private void disconnect_Server()
        {
            pictureBoxConnecting.Visible = false;
            comboBoxSevers.Enabled = true;
            textBoxPort.Enabled = true;
            connect_Server.Enabled = true;
            comboBoxEndDate.Enabled = false;
            comboBoxTestType.Enabled = false;
            buttonShowData.Enabled = false;
            labelStatusDesc.Text = "Not Connected!!";
            labelStatusDesc.ForeColor = Color.DarkRed;
            connect_Server.Text = "Connect";
        }

        private void loading_On()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewZarkov.DataSource = new DataTable();
            pictureBoxLoading.Visible = true;
            comboBoxEndDate.Enabled = false;
            comboBoxTestType.Enabled = false;
            buttonDownload.Enabled = false;
            buttonShowData.Enabled = false;
            Cursor.Current = Cursors.Arrow;
        }

        private void loading_Off()
        {
            Cursor.Current = Cursors.Arrow;
            pictureBoxLoading.Visible = false;
            comboBoxEndDate.Enabled = true;
            comboBoxTestType.Enabled = true;
            buttonDownload.Enabled = true;
            buttonShowData.Enabled = true;
            labelCount.Text = Convert.ToString(_outputDataTable.Rows.Count);
            Cursor.Current = Cursors.WaitCursor;
        }

        private void load_Fields()
        {
            var filter = new BsonDocument();
            try
            {
                test_types = _collection.Distinct<String>(Constants.TestType, filter).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("[Error]: {0}", ex.Message), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            loading_On();
            List<object> items = new List<object>();
            items.Add(comboBoxTestType.SelectedItem);
            items.Add(comboBoxEndDate.SelectedItem);
            backgroundWorkerLoadData.RunWorkerAsync(items);

        }

        private void connect_Server_Click(object sender, EventArgs e)
        {
            if (connect_Server.Text.Equals("Connect"))
            {
                connect_Server_On();
                var servers = comboBoxSevers.SelectedItem == null ? comboBoxSevers.Text : comboBoxSevers.SelectedItem.ToString();
                List<object> items = new List<object>();
                items.Add(servers);
                items.Add(textBoxPort.Text);
                backgroundWorker2.RunWorkerAsync(items);
            }
            else if (connect_Server.Text.Equals("Disconnect"))
            {
                disconnect_Server();
            }

        }

        private void comboBoxTestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var port = Convert.ToInt16(textBoxPort.Text);
            var test_type = comboBoxTestType.SelectedItem;
            var filter = new BsonDocument().Add(Constants.TestType, test_type.ToString());
            if (_dataCache.ContainsKey(port))
            {
                if (_dataCache[port].ContainsKey(test_type.ToString()))
                {
                    var top10_Sorted_Dates = _dataCache[port][test_type.ToString()];
                    comboBoxEndDate.DataSource = top10_Sorted_Dates;
                }
                else
                {
                    var end_dates = _collection.Distinct<BsonDateTime>(Constants.EndDate, filter).ToList();
                    var sorted_Dates = from element in end_dates
                                       orderby element descending
                                       select element;
                    var top10_Sorted_Dates = sorted_Dates.Take(10).ToList();
                    _dataCache[port].Add(test_type.ToString(), top10_Sorted_Dates);
                    comboBoxEndDate.DataSource = top10_Sorted_Dates;
                }

            }
            else
            {
                Dictionary<string, List<BsonDateTime>> data = new Dictionary<string, List<BsonDateTime>>();
                var end_dates = _collection.Distinct<BsonDateTime>(Constants.EndDate, filter).ToList();
                var sorted_Dates = from element in end_dates
                                   orderby element descending
                                   select element;
                var top10_Sorted_Dates = sorted_Dates.Take(10).ToList();
                data.Add(test_type.ToString(), top10_Sorted_Dates);
                _dataCache.Add(port, data);
                comboBoxEndDate.DataSource = top10_Sorted_Dates;
            }
        }

        private void backgroundWorkerConnectServer_DoWork(object sender, DoWorkEventArgs e)
        {
            if (this.labelStatusDesc.InvokeRequired)
            {
                this.labelStatusDesc.BeginInvoke((MethodInvoker)delegate () { this.labelStatusDesc.Text = "Connecting ..."; this.labelStatusDesc.ForeColor = Color.CadetBlue; });
            }
            else
            {
                this.labelStatusDesc.Text = "Connecting ...";
                this.labelStatusDesc.ForeColor = Color.CadetBlue;
            }

            var comboBoxValues = e.Argument as List<object>;
            var serverName = Convert.ToString(comboBoxValues[0]);
            var port = Convert.ToString(comboBoxValues[1]);
            if (String.IsNullOrEmpty(port) || String.IsNullOrEmpty(serverName))
            {
                MessageBox.Show("[Error] : Connection Failed!!\nPlease select the server name from drop down and enter server port in the box.", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            else if (serverName.Equals("Mulgrave Server")) // Mulgrave Server
            {
                var server = ConfigurationSettings.AppSettings.Get("MulgraveDBConectionString");
                if (isPortAvailable(server, Convert.ToInt16(port)))
                {
                    string conn = String.Format(@"mongodb://{0}:{1}", server, port);
                    _collection = connectServerAndGetCollection(conn, "agilent", "zarkov");
                    load_Fields();
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
            else if (serverName.Equals("COS Server")) // COS Server
            {
                var server = ConfigurationSettings.AppSettings.Get("COSDBConectionString");
                if (isPortAvailable(server, Convert.ToInt16(port)))
                {
                    string conn = String.Format(@"mongodb://{0}:{1}", server, port);
                    _collection = connectServerAndGetCollection(conn, "agilent", "zarkov");
                    load_Fields();
                }
                else
                {
                    e.Cancel = true;
                    return;
                }
            }
            else
            {
                if (isPortAvailable(serverName, Convert.ToInt16(port)))
                {
                    string conn = String.Format(@"mongodb://{0}:{1}", serverName, port);
                    _collection = connectServerAndGetCollection(conn, "agilent", "zarkov");
                    load_Fields();
                }
                else
                {
                    e.Cancel = true;
                    return;
                }

            }
        }

        private void backgroundWorkerConnectServer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (e.Cancelled)
            {
                connect_Server_Cancel();
            }
            else
            {
                // this runs on the UI thread
                connect_Server_Off();
            }
        }

        private void backgroundWorkerLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            var comboBoxValues = e.Argument as List<object>;
            var testType = comboBoxValues[0];
            var endDate = comboBoxValues[1];
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq(Constants.TestType, testType) & builder.Eq(Constants.EndDate, Convert.ToDateTime(endDate));
            if (_collection != null)
            {
                var output = _collection.Find(filter).ToList();
                _outputDataTable = convertListToDataTable(output);
                if (_outputDataTable == null)
                {
                    MessageBox.Show("No Results to Display!!!", "Message!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The Collection is Empty.", "Message!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backgroundWorkerLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // this runs on the UI thread
            loading_Off();
            dataGridViewZarkov.DataSource = _outputDataTable;
        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel |*.xlsx|CSV |*.csv";
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.ShowDialog();

                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName != "")
                {

                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            var workbook = new XLWorkbook();
                            var worksheet = workbook.Worksheets.Add(_outputDataTable, "Data Sheet");
                            workbook.SaveAs(saveFileDialog1.FileName);
                            break;

                        case 2:
                            List<String> lines = ToCSV(_outputDataTable);
                            File.WriteAllLines(saveFileDialog1.FileName, lines);
                            break;
                    }
                    MessageBox.Show("Save Successful!!!", "Message!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("[Error]: {0}", ex.Message), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> ToCSV(DataTable dt)
        {
            var lines = new List<string>();
            string[] columnNames = dt.Columns.Cast<DataColumn>().
                             Select(column => column.ColumnName).
                             ToArray();
            var header = string.Join(",", columnNames);
            lines.Add(header);
            var valueLines = dt.AsEnumerable()
                               .Select(row => string.Join(",", row.ItemArray));
            lines.AddRange(valueLines);
            return lines;
        }


        /// <summary>
        /// Checks if the port is open in the remote server.
        /// </summary>
        /// <param name="_HostURI"></param>
        /// <param name="_PortNumber"></param>
        /// <returns>boolean</returns>
        private bool isPortAvailable(string _HostURI, int _PortNumber)
        {
            try
            {
                TcpClient client = new TcpClient(_HostURI, _PortNumber);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("[Error]: {0}", ex.Message), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private IMongoCollection<BsonDocument> connectServerAndGetCollection(string connection, string dbName, string collection)
        {
            try
            {
                return new MongoClient(connection).GetDatabase(dbName).GetCollection<BsonDocument>(collection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("[Error]: {0}", ex.Message), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable convertListToDataTable(List<BsonDocument> list)
        {
            if (list != null && list.Count() > 0)
            {
                DataTable dt = new DataTable(list.ToString());

                foreach (BsonDocument doc in list)
                {
                    DataRow dr = dt.NewRow();
                    foreach (BsonElement elm in doc.Elements)
                    {
                        if (elm.Value is BsonDocument || elm.Value is BsonArray)
                        {
                            columns.Clear();
                            createColumnHeaderAndData(elm);
                            foreach (var colm in columns)
                            {
                                if (!dt.Columns.Contains(colm.Key.ToString()))
                                    dt.Columns.Add(new DataColumn(colm.Key.ToString()));
                                dr[colm.Key] = colm.Value;
                            }
                        }
                        else
                        {
                            if (!dt.Columns.Contains(elm.Name))
                                dt.Columns.Add(new DataColumn(elm.Name));
                            dr[elm.Name] = elm.Value;

                        }
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }
            return null;
        }

        private string createColumnHeaderAndData(BsonElement ele)
        {
            if (ele.Value is BsonDocument)
            {
                BsonDocument bsd = (BsonDocument)ele.Value;
                foreach (BsonElement elem in bsd.Elements)
                {
                    col = ele.Name + "_" + createColumnHeaderAndData(elem);
                    if (col.Substring(col.Length - 1, 1).Equals("_"))
                    {
                        // do not include the rubbish item
                        col = string.Empty;
                    }
                    else
                    {
                        columns.Add(col, elem.Value);
                        col = string.Empty;
                    }
                }
            }
            else if (ele.Value is BsonArray)
            {
                BsonArray bsa = (BsonArray)ele.Value;
                int totalItems = bsa.Count();
                for (int i = 0; i < totalItems; i++)
                {
                    BsonDocument bsd = bsa.ElementAt(i).ToBsonDocument();
                    foreach (BsonElement elem in bsd.Elements)
                    {
                        col = ele.Name + "_" + i + "_" + createColumnHeaderAndData(elem);
                        columns.Add(col, elem.Value);
                        col = string.Empty;
                    }
                }
            }
            else
            {
                return ele.Name;
            }
            return string.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mulgrave Server: \nPorts Range: 4430 - 4454\n\nCOS Server:\nPort: 5555\n\nAlso accepts users host and port.", "Available Ports!!! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
