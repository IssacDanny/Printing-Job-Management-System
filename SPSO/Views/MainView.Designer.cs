namespace SPSO.Views
{
    partial class MainView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRequests = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOwner = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.btnHomePage);
            this.panel1.Controls.Add(this.btnPurchase);
            this.panel1.Controls.Add(this.btnRequests);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnOwner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 740);
            this.panel1.TabIndex = 0;
            // 
            // btnRequests
            // 
            this.btnRequests.BackColor = System.Drawing.Color.Black;
            this.btnRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRequests.ForeColor = System.Drawing.Color.Gray;
            this.btnRequests.Location = new System.Drawing.Point(3, 242);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(243, 56);
            this.btnRequests.TabIndex = 3;
            this.btnRequests.Text = "Yêu Cầu In Ấn";
            this.btnRequests.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(56, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "BK - Printing Service";
            // 
            // btnOwner
            // 
            this.btnOwner.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOwner.ForeColor = System.Drawing.Color.Gray;
            this.btnOwner.Location = new System.Drawing.Point(3, 337);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(243, 56);
            this.btnOwner.TabIndex = 2;
            this.btnOwner.Text = "Hồ Sơ Người Dùng";
            this.btnOwner.UseVisualStyleBackColor = false;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Black;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPurchase.ForeColor = System.Drawing.Color.Gray;
            this.btnPurchase.Location = new System.Drawing.Point(3, 433);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(243, 56);
            this.btnPurchase.TabIndex = 2;
            this.btnPurchase.Text = "Mua Giấy In";
            this.btnPurchase.UseVisualStyleBackColor = false;
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.Color.Black;
            this.btnHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHomePage.ForeColor = System.Drawing.Color.Gray;
            this.btnHomePage.Location = new System.Drawing.Point(3, 151);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(243, 56);
            this.btnHomePage.TabIndex = 2;
            this.btnHomePage.Text = "Trang Chủ";
            this.btnHomePage.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SPSO.Properties.Resources.image_4;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 740);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "MainView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnHomePage;
    }
}