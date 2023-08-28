namespace HCP.Fr.User.PatientsUI
{
    partial class fruNewPatientAddress
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtnotes = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnupdateaddr = new DevExpress.XtraEditors.SimpleButton();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtaddr = new Krypton.Toolkit.KryptonRichTextBox();
            this.txtapartment = new DevExpress.XtraEditors.TextEdit();
            this.txtstate = new DevExpress.XtraEditors.TextEdit();
            this.txtzip = new DevExpress.XtraEditors.TextEdit();
            this.txtcity = new DevExpress.XtraEditors.TextEdit();
            this.txttelephone = new DevExpress.XtraEditors.TextEdit();
            this.drpcountries = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtapartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtzip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttelephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpcountries.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 107);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Numero Appartement";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(431, 107);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ville";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 157);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "état Ou Région";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(431, 157);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Pays";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(25, 208);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(80, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Boite Postale";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(431, 208);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 16);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Téléphone";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(25, 259);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 16);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Notes";
            // 
            // txtnotes
            // 
            this.txtnotes.Location = new System.Drawing.Point(139, 279);
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            this.txtnotes.Size = new System.Drawing.Size(697, 402);
            this.txtnotes.TabIndex = 7;
            // 
            // btnupdateaddr
            // 
            this.btnupdateaddr.Location = new System.Drawing.Point(148, 701);
            this.btnupdateaddr.Name = "btnupdateaddr";
            this.btnupdateaddr.Size = new System.Drawing.Size(176, 29);
            this.btnupdateaddr.TabIndex = 8;
            this.btnupdateaddr.Text = "Mettre à jour l\'adresse";
            this.btnupdateaddr.Click += new System.EventHandler(this.btnupdateaddr_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(341, 701);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(156, 29);
            this.btnclose.TabIndex = 9;
            this.btnclose.Text = "Fermer";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(25, 21);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 16);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Adresse";
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(148, 21);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(688, 69);
            this.txtaddr.TabIndex = 13;
            this.txtaddr.Text = "";
            // 
            // txtapartment
            // 
            this.txtapartment.Location = new System.Drawing.Point(148, 104);
            this.txtapartment.Name = "txtapartment";
            this.txtapartment.Size = new System.Drawing.Size(234, 22);
            this.txtapartment.TabIndex = 14;
            // 
            // txtstate
            // 
            this.txtstate.Location = new System.Drawing.Point(148, 154);
            this.txtstate.Name = "txtstate";
            this.txtstate.Size = new System.Drawing.Size(234, 22);
            this.txtstate.TabIndex = 15;
            // 
            // txtzip
            // 
            this.txtzip.Location = new System.Drawing.Point(148, 205);
            this.txtzip.Name = "txtzip";
            this.txtzip.Size = new System.Drawing.Size(234, 22);
            this.txtzip.TabIndex = 16;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(543, 104);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(234, 22);
            this.txtcity.TabIndex = 17;
            // 
            // txttelephone
            // 
            this.txttelephone.Location = new System.Drawing.Point(543, 205);
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(234, 22);
            this.txttelephone.TabIndex = 18;
            // 
            // drpcountries
            // 
            this.drpcountries.Location = new System.Drawing.Point(543, 154);
            this.drpcountries.Name = "drpcountries";
            this.drpcountries.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpcountries.Properties.NullText = "";
            this.drpcountries.Size = new System.Drawing.Size(233, 22);
            this.drpcountries.TabIndex = 19;
            // 
            // fruNewPatientAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 742);
            this.Controls.Add(this.drpcountries);
            this.Controls.Add(this.txttelephone);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtzip);
            this.Controls.Add(this.txtstate);
            this.Controls.Add(this.txtapartment);
            this.Controls.Add(this.txtaddr);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnupdateaddr);
            this.Controls.Add(this.txtnotes);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fruNewPatientAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fruNewPatientAddress";
            this.Load += new System.EventHandler(this.fruNewPatientAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtapartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtzip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttelephone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpcountries.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraRichEdit.RichEditControl txtnotes;
        private DevExpress.XtraEditors.SimpleButton btnupdateaddr;
        private DevExpress.XtraEditors.SimpleButton btnclose;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Krypton.Toolkit.KryptonRichTextBox txtaddr;
        private DevExpress.XtraEditors.TextEdit txtapartment;
        private DevExpress.XtraEditors.TextEdit txtstate;
        private DevExpress.XtraEditors.TextEdit txtzip;
        private DevExpress.XtraEditors.TextEdit txtcity;
        private DevExpress.XtraEditors.TextEdit txttelephone;
        private DevExpress.XtraEditors.LookUpEdit drpcountries;
    }
}