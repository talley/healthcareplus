namespace HCP.Fr.User.PatientsUI
{
    partial class fruNewPatientRaisonVisite
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
            this.txtvisitraison = new DevExpress.XtraRichEdit.RichEditControl();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtvisitraison
            // 
            this.txtvisitraison.Location = new System.Drawing.Point(139, 12);
            this.txtvisitraison.Name = "txtvisitraison";
            this.txtvisitraison.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            this.txtvisitraison.Size = new System.Drawing.Size(1006, 660);
            this.txtvisitraison.TabIndex = 0;
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.AutoSize = true;
            this.ultraLabel3.Location = new System.Drawing.Point(12, 12);
            this.ultraLabel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(54, 17);
            this.ultraLabel3.TabIndex = 3;
            this.ultraLabel3.Text = "Adresse";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(139, 694);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(201, 24);
            this.btnadd.TabIndex = 17;
            this.btnadd.Text = "Ajouter";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(355, 694);
            this.btnclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(201, 24);
            this.btnclose.TabIndex = 18;
            this.btnclose.Text = "Fermer";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // fruNewPatientRaisonVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 753);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.txtvisitraison);
            this.Name = "fruNewPatientRaisonVisite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fruNewPatientRaisonVisite";
            this.Load += new System.EventHandler(this.fruNewPatientRaisonVisite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl txtvisitraison;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btnclose;
    }
}