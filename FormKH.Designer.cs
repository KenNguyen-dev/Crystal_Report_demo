namespace Crystal_Report
{
    partial class FormKH
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
            this.formCrystalReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // formCrystalReport
            // 
            this.formCrystalReport.ActiveViewIndex = -1;
            this.formCrystalReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formCrystalReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.formCrystalReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formCrystalReport.Location = new System.Drawing.Point(0, 0);
            this.formCrystalReport.Name = "formCrystalReport";
            this.formCrystalReport.Size = new System.Drawing.Size(800, 450);
            this.formCrystalReport.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formCrystalReport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer formCrystalReport;
    }
}

