namespace SPSO.Views
{
    partial class RequestView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePrintingLog = new System.Windows.Forms.TabPage();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageRequestDetail = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDoubleSided = new System.Windows.Forms.RadioButton();
            this.radioButtonOneSided = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.PrintingLocationCB = new System.Windows.Forms.ComboBox();
            this.PaperSizeCB = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePrintingLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageRequestDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requests";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 69);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePrintingLog);
            this.tabControl1.Controls.Add(this.tabPageRequestDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 381);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPagePrintingLog
            // 
            this.tabPagePrintingLog.Controls.Add(this.btnAddNew);
            this.tabPagePrintingLog.Controls.Add(this.dataGridView1);
            this.tabPagePrintingLog.Controls.Add(this.btnSearch);
            this.tabPagePrintingLog.Controls.Add(this.txtSearch);
            this.tabPagePrintingLog.Controls.Add(this.label2);
            this.tabPagePrintingLog.Location = new System.Drawing.Point(4, 25);
            this.tabPagePrintingLog.Name = "tabPagePrintingLog";
            this.tabPagePrintingLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrintingLog.Size = new System.Drawing.Size(792, 352);
            this.tabPagePrintingLog.TabIndex = 0;
            this.tabPagePrintingLog.Text = "Printing Log";
            this.tabPagePrintingLog.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Location = new System.Drawing.Point(667, 81);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(117, 35);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add Request";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 245);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(576, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(27, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(543, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search request";
            // 
            // tabPageRequestDetail
            // 
            this.tabPageRequestDetail.Controls.Add(this.PaperSizeCB);
            this.tabPageRequestDetail.Controls.Add(this.PrintingLocationCB);
            this.tabPageRequestDetail.Controls.Add(this.btnCancel);
            this.tabPageRequestDetail.Controls.Add(this.btnSave);
            this.tabPageRequestDetail.Controls.Add(this.numericUpDownQuantity);
            this.tabPageRequestDetail.Controls.Add(this.groupBox1);
            this.tabPageRequestDetail.Controls.Add(this.label7);
            this.tabPageRequestDetail.Controls.Add(this.label6);
            this.tabPageRequestDetail.Controls.Add(this.label5);
            this.tabPageRequestDetail.Controls.Add(this.txtName);
            this.tabPageRequestDetail.Controls.Add(this.label4);
            this.tabPageRequestDetail.Controls.Add(this.label3);
            this.tabPageRequestDetail.Controls.Add(this.txtID);
            this.tabPageRequestDetail.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequestDetail.Name = "tabPageRequestDetail";
            this.tabPageRequestDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequestDetail.Size = new System.Drawing.Size(792, 352);
            this.tabPageRequestDetail.TabIndex = 1;
            this.tabPageRequestDetail.Text = "Request Form";
            this.tabPageRequestDetail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(678, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 41);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(569, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 41);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(60, 303);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(144, 22);
            this.numericUpDownQuantity.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDoubleSided);
            this.groupBox1.Controls.Add(this.radioButtonOneSided);
            this.groupBox1.Location = new System.Drawing.Point(60, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 93);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu In";
            // 
            // radioButtonDoubleSided
            // 
            this.radioButtonDoubleSided.AutoSize = true;
            this.radioButtonDoubleSided.Location = new System.Drawing.Point(6, 63);
            this.radioButtonDoubleSided.Name = "radioButtonDoubleSided";
            this.radioButtonDoubleSided.Size = new System.Drawing.Size(74, 20);
            this.radioButtonDoubleSided.TabIndex = 12;
            this.radioButtonDoubleSided.TabStop = true;
            this.radioButtonDoubleSided.Text = "Hai Mặt";
            this.radioButtonDoubleSided.UseVisualStyleBackColor = true;
            // 
            // radioButtonOneSided
            // 
            this.radioButtonOneSided.AutoSize = true;
            this.radioButtonOneSided.Location = new System.Drawing.Point(6, 32);
            this.radioButtonOneSided.Name = "radioButtonOneSided";
            this.radioButtonOneSided.Size = new System.Drawing.Size(75, 20);
            this.radioButtonOneSided.TabIndex = 11;
            this.radioButtonOneSided.TabStop = true;
            this.radioButtonOneSided.Text = "Một Mặt";
            this.radioButtonOneSided.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Khổ Giấy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa Điểm In";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(322, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 22);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ Và Tên Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label3.Location = new System.Drawing.Point(57, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Số Sinh Viên";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(60, 63);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(224, 22);
            this.txtID.TabIndex = 0;
            // 
            // PrintingLocationCB
            // 
            this.PrintingLocationCB.FormattingEnabled = true;
            this.PrintingLocationCB.Items.AddRange(new object[] {
            "A4",
            "C6",
            "Thư Viện",
            "A1"});
            this.PrintingLocationCB.Location = new System.Drawing.Point(601, 63);
            this.PrintingLocationCB.Name = "PrintingLocationCB";
            this.PrintingLocationCB.Size = new System.Drawing.Size(158, 24);
            this.PrintingLocationCB.TabIndex = 15;
            this.PrintingLocationCB.SelectedIndexChanged += new System.EventHandler(this.PrintingLocationCB_SelectedIndexChanged);
            // 
            // PaperSizeCB
            // 
            this.PaperSizeCB.FormattingEnabled = true;
            this.PaperSizeCB.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5"});
            this.PaperSizeCB.Location = new System.Drawing.Point(60, 122);
            this.PaperSizeCB.Name = "PaperSizeCB";
            this.PaperSizeCB.Size = new System.Drawing.Size(178, 24);
            this.PaperSizeCB.TabIndex = 16;
            this.PaperSizeCB.SelectedIndexChanged += new System.EventHandler(this.PaperSizeCB_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(710, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // RequestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "RequestView";
            this.Text = "RequestView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePrintingLog.ResumeLayout(false);
            this.tabPagePrintingLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageRequestDetail.ResumeLayout(false);
            this.tabPageRequestDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePrintingLog;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageRequestDetail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDoubleSided;
        private System.Windows.Forms.RadioButton radioButtonOneSided;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox PaperSizeCB;
        private System.Windows.Forms.ComboBox PrintingLocationCB;
        private System.Windows.Forms.Button btnClose;
    }
}