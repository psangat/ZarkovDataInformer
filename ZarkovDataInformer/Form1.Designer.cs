namespace ZarkovDataInformer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewZarkov = new System.Windows.Forms.DataGridView();
            this.buttonConvertToExcel = new System.Windows.Forms.Button();
            this.backgroundWorkerLoadData = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.labelStatusDesc = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxSevers = new System.Windows.Forms.ComboBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.connect_Server = new System.Windows.Forms.Button();
            this.pictureBoxConnecting = new System.Windows.Forms.PictureBox();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.comboBoxEndDate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTestType = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZarkov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnecting)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewZarkov
            // 
            this.dataGridViewZarkov.AllowUserToAddRows = false;
            this.dataGridViewZarkov.AllowUserToDeleteRows = false;
            this.dataGridViewZarkov.AllowUserToOrderColumns = true;
            this.dataGridViewZarkov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZarkov.Location = new System.Drawing.Point(367, 37);
            this.dataGridViewZarkov.Name = "dataGridViewZarkov";
            this.dataGridViewZarkov.ReadOnly = true;
            this.dataGridViewZarkov.RowTemplate.Height = 24;
            this.dataGridViewZarkov.Size = new System.Drawing.Size(1047, 501);
            this.dataGridViewZarkov.TabIndex = 7;
            // 
            // buttonConvertToExcel
            // 
            this.buttonConvertToExcel.Enabled = false;
            this.buttonConvertToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConvertToExcel.Location = new System.Drawing.Point(1261, 553);
            this.buttonConvertToExcel.Name = "buttonConvertToExcel";
            this.buttonConvertToExcel.Size = new System.Drawing.Size(153, 31);
            this.buttonConvertToExcel.TabIndex = 8;
            this.buttonConvertToExcel.Text = "Download as Excel";
            this.buttonConvertToExcel.UseVisualStyleBackColor = true;
            this.buttonConvertToExcel.Click += new System.EventHandler(this.buttonConvertToExcel_Click);
            // 
            // backgroundWorkerLoadData
            // 
            this.backgroundWorkerLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadData_DoWork);
            this.backgroundWorkerLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoadData_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerConnectServer_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerConnectServer_RunWorkerCompleted);
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLoading.Image = global::ZarkovDataInformer.Properties.Resources.load__2_;
            this.pictureBoxLoading.InitialImage = null;
            this.pictureBoxLoading.Location = new System.Drawing.Point(873, 236);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(131, 130);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLoading.TabIndex = 8;
            this.pictureBoxLoading.TabStop = false;
            this.pictureBoxLoading.Visible = false;
            // 
            // labelStatusDesc
            // 
            this.labelStatusDesc.AutoSize = true;
            this.labelStatusDesc.ForeColor = System.Drawing.Color.DarkRed;
            this.labelStatusDesc.Location = new System.Drawing.Point(60, 93);
            this.labelStatusDesc.Name = "labelStatusDesc";
            this.labelStatusDesc.Size = new System.Drawing.Size(108, 17);
            this.labelStatusDesc.TabIndex = 20;
            this.labelStatusDesc.Text = "Not Connected!!";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(2, 93);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(52, 17);
            this.labelStatus.TabIndex = 19;
            this.labelStatus.Text = "Status:";
            // 
            // comboBoxSevers
            // 
            this.comboBoxSevers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSevers.FormattingEnabled = true;
            this.comboBoxSevers.Items.AddRange(new object[] {
            "Mulgrave Server",
            "COS Server"});
            this.comboBoxSevers.Location = new System.Drawing.Point(127, 12);
            this.comboBoxSevers.Name = "comboBoxSevers";
            this.comboBoxSevers.Size = new System.Drawing.Size(186, 24);
            this.comboBoxSevers.TabIndex = 15;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(127, 45);
            this.textBoxPort.MaxLength = 5;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(186, 22);
            this.textBoxPort.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Connect To: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Port: ";
            // 
            // connect_Server
            // 
            this.connect_Server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect_Server.Location = new System.Drawing.Point(192, 77);
            this.connect_Server.Name = "connect_Server";
            this.connect_Server.Size = new System.Drawing.Size(111, 33);
            this.connect_Server.TabIndex = 16;
            this.connect_Server.Text = "Connect";
            this.connect_Server.UseVisualStyleBackColor = true;
            this.connect_Server.Click += new System.EventHandler(this.connect_Server_Click);
            // 
            // pictureBoxConnecting
            // 
            this.pictureBoxConnecting.Image = global::ZarkovDataInformer.Properties.Resources.ezgif_com_crop__1_;
            this.pictureBoxConnecting.Location = new System.Drawing.Point(115, 124);
            this.pictureBoxConnecting.Name = "pictureBoxConnecting";
            this.pictureBoxConnecting.Size = new System.Drawing.Size(83, 28);
            this.pictureBoxConnecting.TabIndex = 21;
            this.pictureBoxConnecting.TabStop = false;
            this.pictureBoxConnecting.Visible = false;
            // 
            // buttonShowData
            // 
            this.buttonShowData.Enabled = false;
            this.buttonShowData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowData.Location = new System.Drawing.Point(194, 170);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(121, 31);
            this.buttonShowData.TabIndex = 33;
            this.buttonShowData.Text = "Show Data";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // comboBoxEndDate
            // 
            this.comboBoxEndDate.Enabled = false;
            this.comboBoxEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEndDate.FormattingEnabled = true;
            this.comboBoxEndDate.Items.AddRange(new object[] {
            "Mulgrave Server",
            "COS Server"});
            this.comboBoxEndDate.Location = new System.Drawing.Point(11, 123);
            this.comboBoxEndDate.Name = "comboBoxEndDate";
            this.comboBoxEndDate.Size = new System.Drawing.Size(304, 24);
            this.comboBoxEndDate.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Test Type: ";
            // 
            // comboBoxTestType
            // 
            this.comboBoxTestType.Enabled = false;
            this.comboBoxTestType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTestType.FormattingEnabled = true;
            this.comboBoxTestType.Items.AddRange(new object[] {
            "Mulgrave Server",
            "COS Server"});
            this.comboBoxTestType.Location = new System.Drawing.Point(10, 52);
            this.comboBoxTestType.Name = "comboBoxTestType";
            this.comboBoxTestType.Size = new System.Drawing.Size(305, 24);
            this.comboBoxTestType.TabIndex = 30;
            this.comboBoxTestType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTestType_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(18, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 206);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelStatusDesc);
            this.tabPage1.Controls.Add(this.comboBoxSevers);
            this.tabPage1.Controls.Add(this.pictureBoxConnecting);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxPort);
            this.tabPage1.Controls.Add(this.connect_Server);
            this.tabPage1.Controls.Add(this.labelStatus);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(325, 177);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connect To Server";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(18, 258);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(333, 280);
            this.tabControl2.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.buttonShowData);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.comboBoxEndDate);
            this.tabPage2.Controls.Add(this.comboBoxTestType);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(325, 251);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Filters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 597);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBoxLoading);
            this.Controls.Add(this.buttonConvertToExcel);
            this.Controls.Add(this.dataGridViewZarkov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarkov Data Informer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZarkov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnecting)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewZarkov;
        private System.Windows.Forms.Button buttonConvertToExcel;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadData;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label labelStatusDesc;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxSevers;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button connect_Server;
        private System.Windows.Forms.PictureBox pictureBoxConnecting;
        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.ComboBox comboBoxEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTestType;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

