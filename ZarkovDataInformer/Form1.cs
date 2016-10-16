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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarkovDataInformer
{
    public partial class Form1 : Form
    {
        DataTable _outputDataTable = new DataTable();
        IMongoCollection<BsonDocument> _collection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void connect_Server_Click(object sender, EventArgs e)
        {
            comboBoxSevers.Enabled = false;
            textBoxPort.Enabled = false;
            connect_Server.Enabled = false;
            var index = comboBoxSevers.SelectedIndex;
            var port = textBoxPort.Text;
            if (String.IsNullOrEmpty(port) || index == -1)
            {
                MessageBox.Show("Connection Failed!!\nPlease select the server name from drop down and enter server port in the box. Then, Try again.");
            }
            else if (index == 0) // Mulgrave Server
            {
                string conn = String.Format(@"mongodb://{0}:{1}", ConfigurationSettings.AppSettings.Get("MulgraveDBConectionString"), port);
                _collection = connectServerAndGetCollection(conn, "agilent", "zarkov");
                loadFields(_collection);
            }
            else if (index == 1) // COS Server
            {
                string conn = String.Format(@"mongodb://{0}:{1}", ConfigurationSettings.AppSettings.Get("COSDBConectionString"), port);
                _collection = connectServerAndGetCollection(conn, "agilent", "zarkov");
                loadFields(_collection);
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
                MessageBox.Show(String.Format("[Error]: {0}", ex.Message));
                return null;
            }
        }

        private void loadFields(IMongoCollection<BsonDocument> collection)
        {
            var filter = new BsonDocument();
            try
            {
                var test_types = collection.Distinct<String>("test_type", filter).ToList();
                comboBoxTestType.DataSource = test_types;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                comboBoxEndDate.Enabled = true;
                comboBoxTestType.Enabled = true;
                //buttonConvertToExcel.Enabled = true;
                buttonShowData.Enabled = true;
                labelStatusDesc.Text = "Connected!!";
            }
        }

        public DataTable GetDataTableFromList(List<BsonDocument> cursor)
        {
            if (cursor != null && cursor.Count() > 0)
            {

                DataTable dt = new DataTable(cursor.ToString());
                foreach (BsonDocument doc in cursor)
                {

                    foreach (BsonElement elm in doc.Elements)
                    {
                        if (!dt.Columns.Contains(elm.Name))
                        {
                            dt.Columns.Add(new DataColumn(elm.Name));
                        }

                    }
                    DataRow dr = dt.NewRow();
                    foreach (BsonElement elm in doc.Elements)
                    {
                        dr[elm.Name] = elm.Value;

                    }
                    dt.Rows.Add(dr);
                }
                return dt;

            }
            return null;
        }

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            var testType = comboBoxTestType.SelectedItem;
            var endDate = comboBoxEndDate.SelectedItem;
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("test_type", testType) & builder.Eq("end_dt", Convert.ToDateTime(endDate));
            if (_collection != null)
            {
                var output = _collection.Find(filter).ToList();
                _outputDataTable = GetDataTableFromList(output);
                if (_outputDataTable == null)
                {
                    MessageBox.Show("No Results to Display!!!", "Message!!!");
                }
                else
                {
                    dataGridViewZarkov.DataSource = _outputDataTable;
                    buttonConvertToExcel.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("The Collection is Empty.", "Message!!!");
            }
        }

        private void comboBoxTestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var test_type = comboBoxTestType.SelectedItem;
            var filter = new BsonDocument().Add("test_type", test_type.ToString());
            var end_dates = _collection.Distinct<BsonDateTime>("end_dt", filter).ToList();
            comboBoxEndDate.DataSource = end_dates;
        }

        private void buttonConvertToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel |*.xlsx";
            saveFileDialog1.Title = "Save an excel File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add(_outputDataTable, "Data Sheet");
                    workbook.SaveAs(saveFileDialog1.FileName);
                    MessageBox.Show("Save Successful!!!", "Message!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("[Error]: {0}", ex.Message));
                }
            }
        }
    }
}
