namespace HCP.Fr.User.PatientsUI
{
    partial class fruEditPatientNote
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
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdateaddr = new DevExpress.XtraEditors.SimpleButton();
            this.txtnotes = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(343, 720);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(156, 29);
            this.btnclose.TabIndex = 29;
            this.btnclose.Text = "Fermer";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnupdateaddr
            // 
            this.btnupdateaddr.Location = new System.Drawing.Point(150, 720);
            this.btnupdateaddr.Name = "btnupdateaddr";
            this.btnupdateaddr.Size = new System.Drawing.Size(176, 29);
            this.btnupdateaddr.TabIndex = 28;
            this.btnupdateaddr.Text = "Mettre à Jour La Note";
            this.btnupdateaddr.Click += new System.EventHandler(this.btnupdateaddr_Click);
            // 
            // txtnotes
            // 
            this.txtnotes.Location = new System.Drawing.Point(141, 24);
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            this.txtnotes.Size = new System.Drawing.Size(918, 676);
            this.txtnotes.TabIndex = 27;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(31, 24);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 16);
            this.labelControl7.TabIndex = 26;
            this.labelControl7.Text = "Notes";
            // 
            // fruEditPatientNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 764);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnupdateaddr);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.labelControl7);
            this.MaximizeBox = false;
            this.Name = "fruEditPatientNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fruEditPatientNote";
            this.Load += new System.EventHandler(this.fruEditPatientNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnclose;
        private DevExpress.XtraEditors.SimpleButton btnupdateaddr;
        private DevExpress.XtraRichEdit.RichEditControl txtnotes;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}