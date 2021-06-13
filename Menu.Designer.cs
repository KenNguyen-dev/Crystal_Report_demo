namespace Crystal_Report
{
    partial class Menu
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
            this.btnVoucher = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btnDoiTac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoucher
            // 
            this.btnVoucher.Location = new System.Drawing.Point(34, 55);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.Size = new System.Drawing.Size(160, 55);
            this.btnVoucher.TabIndex = 0;
            this.btnVoucher.Text = "Danh sách voucher";
            this.btnVoucher.UseVisualStyleBackColor = true;
            this.btnVoucher.Click += new System.EventHandler(this.btnVoucher_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(34, 169);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(193, 26);
            this.tbTimKiem.TabIndex = 1;
            // 
            // btnDoiTac
            // 
            this.btnDoiTac.Location = new System.Drawing.Point(34, 223);
            this.btnDoiTac.Name = "btnDoiTac";
            this.btnDoiTac.Size = new System.Drawing.Size(146, 42);
            this.btnDoiTac.TabIndex = 2;
            this.btnDoiTac.Text = "Tìm Kiếm Đối Tác";
            this.btnDoiTac.UseVisualStyleBackColor = true;
            this.btnDoiTac.Click += new System.EventHandler(this.btnDoiTac_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoiTac);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.btnVoucher);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoucher;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btnDoiTac;
    }
}