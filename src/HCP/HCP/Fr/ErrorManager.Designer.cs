namespace HCP.Fr
{
    partial class ErrorManager
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txterrormsg = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.ultraTree1 = new Infragistics.Win.UltraWinTree.UltraTree();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(357, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Une erreur s\'est produite. Le détail technique est ci-dessous.";
            // 
            // txterrormsg
            // 
            this.txterrormsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txterrormsg.Location = new System.Drawing.Point(0, 62);
            this.txterrormsg.Name = "txterrormsg";
            this.txterrormsg.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            this.txterrormsg.Size = new System.Drawing.Size(1038, 575);
            this.txterrormsg.TabIndex = 1;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(20, 596);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(1006, 29);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "Fermer";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // ultraTree1
            // 
            this.ultraTree1.Location = new System.Drawing.Point(0, 0);
            this.ultraTree1.Name = "ultraTree1";
            this.ultraTree1.TabIndex = 0;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Location = new System.Drawing.Point(0, 0);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.TabIndex = 0;
            // 
            // ErrorManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 637);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.txterrormsg);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire d\'erreurs";
            this.Load += new System.EventHandler(this.ErrorManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraRichEdit.RichEditControl txterrormsg;
        private DevExpress.XtraEditors.SimpleButton btnclose;
        private Infragistics.Win.UltraWinTree.UltraTree ultraTree1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
    }
}