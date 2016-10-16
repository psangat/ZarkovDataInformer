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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSevers = new System.Windows.Forms.ComboBox();
            this.connect_Server = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTestType = new System.Windows.Forms.ComboBox();
            this.comboBoxEndDate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewZarkov = new System.Windows.Forms.DataGridView();
            this.buttonConvertToExcel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatusDesc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZarkov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connect To: ";
            // 
            // comboBoxSevers
            // 
            this.comboBoxSevers.FormattingEnabled = true;
            this.comboBoxSevers.Items.AddRange(new object[] {
            "Mulgrave Server",
            "COS Server"});
            this.comboBoxSevers.Location = new System.Drawing.Point(127, 3);
            this.comboBoxSevers.Name = "comboBoxSevers";
            this.comboBoxSevers.Size = new System.Drawing.Size(186, 24);
            this.comboBoxSevers.TabIndex = 1;
            // 
            // connect_Server
            // 
            this.connect_Server.Location = new System.Drawing.Point(238, 66);
            this.connect_Server.Name = "connect_Server";
            this.connect_Server.Size = new System.Drawing.Size(75, 33);
            this.connect_Server.TabIndex = 2;
            this.connect_Server.Text = "Connect";
            this.connect_Server.UseVisualStyleBackColor = true;
            this.connect_Server.Click += new System.EventHandler(this.connect_Server_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Test Type: ";
            // 
            // comboBoxTestType
            // 
            this.comboBoxTestType.Enabled = false;
            this.comboBoxTestType.FormattingEnabled = true;
            this.comboBoxTestType.Items.AddRange(new object[] {
            "Mulgrave Server",
            "COS Server"});
            this.comboBoxTestType.Location = new System.Drawing.Point(130, 41);
            this.comboBoxTestType.Name = "comboBoxTestType";
            this.comboBoxTestType.Size = new System.Drawing.Size(227, 24);
            this.comboBoxTestType.TabIndex = 4;
            this.comboBoxTestType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTestType_SelectedIndexChanged);
            // 
            // comboBoxEndDate
            // 
            this.comboBoxEndDate.Enabled = false;
            this.comboBoxEndDate.FormattingEnabled = true;
            this.comboBoxEndDate.Items.AddRange(new object[] {
            "Mulgrave Server",
            "COS Server"});
            this.comboBoxEndDate.Location = new System.Drawing.Point(131, 71);
            this.comboBoxEndDate.Name = "comboBoxEndDate";
            this.comboBoxEndDate.Size = new System.Drawing.Size(226, 24);
            this.comboBoxEndDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Date:";
            // 
            // dataGridViewZarkov
            // 
            this.dataGridViewZarkov.AllowUserToAddRows = false;
            this.dataGridViewZarkov.AllowUserToDeleteRows = false;
            this.dataGridViewZarkov.AllowUserToOrderColumns = true;
            this.dataGridViewZarkov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZarkov.Location = new System.Drawing.Point(43, 149);
            this.dataGridViewZarkov.Name = "dataGridViewZarkov";
            this.dataGridViewZarkov.ReadOnly = true;
            this.dataGridViewZarkov.RowTemplate.Height = 24;
            this.dataGridViewZarkov.Size = new System.Drawing.Size(949, 411);
            this.dataGridViewZarkov.TabIndex = 7;
            // 
            // buttonConvertToExcel
            // 
            this.buttonConvertToExcel.Enabled = false;
            this.buttonConvertToExcel.Location = new System.Drawing.Point(839, 577);
            this.buttonConvertToExcel.Name = "buttonConvertToExcel";
            this.buttonConvertToExcel.Size = new System.Drawing.Size(153, 31);
            this.buttonConvertToExcel.TabIndex = 8;
            this.buttonConvertToExcel.Text = "Download as Excel";
            this.buttonConvertToExcel.UseVisualStyleBackColor = true;
            this.buttonConvertToExcel.Click += new System.EventHandler(this.buttonConvertToExcel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Port: ";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(127, 36);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(186, 22);
            this.textBoxPort.TabIndex = 10;
            // 
            // buttonShowData
            // 
            this.buttonShowData.Enabled = false;
            this.buttonShowData.Location = new System.Drawing.Point(670, 577);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(153, 31);
            this.buttonShowData.TabIndex = 11;
            this.buttonShowData.Text = "Show Data";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(43, 13);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelStatusDesc);
            this.splitContainer1.Panel1.Controls.Add(this.labelStatus);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxSevers);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPort);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.connect_Server);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxTestType);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxEndDate);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(949, 100);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 12;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(8, 82);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(52, 17);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Status:";
            // 
            // labelStatusDesc
            // 
            this.labelStatusDesc.AutoSize = true;
            this.labelStatusDesc.Location = new System.Drawing.Point(66, 82);
            this.labelStatusDesc.Name = "labelStatusDesc";
            this.labelStatusDesc.Size = new System.Drawing.Size(108, 17);
            this.labelStatusDesc.TabIndex = 12;
            this.labelStatusDesc.Text = "Not Connected!!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "-------Select Filters-------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 632);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonShowData);
            this.Controls.Add(this.buttonConvertToExcel);
            this.Controls.Add(this.dataGridViewZarkov);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarkov Data Informer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZarkov)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSevers;
        private System.Windows.Forms.Button connect_Server;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTestType;
        private System.Windows.Forms.ComboBox comboBoxEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewZarkov;
        private System.Windows.Forms.Button buttonConvertToExcel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatusDesc;
        private System.Windows.Forms.Label label5;
    }
}

