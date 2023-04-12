namespace HCP.Fr.Admin
{
    partial class frAdminDisableUser
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
            this.drpusers = new DevExpress.XtraEditors.LookUpEdit();
            this.btndisable = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnactivate = new DevExpress.XtraEditors.SimpleButton();
            this.drpusers2 = new DevExpress.XtraEditors.LookUpEdit();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.btnclose2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.drpusers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drpusers2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Choisir Utilisateur";
            // 
            // drpusers
            // 
            this.drpusers.Location = new System.Drawing.Point(145, 51);
            this.drpusers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.drpusers.Name = "drpusers";
            this.drpusers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpusers.Properties.NullText = "";
            this.drpusers.Size = new System.Drawing.Size(590, 22);
            this.drpusers.TabIndex = 15;
            // 
            // btndisable
            // 
            this.btndisable.Appearance.BackColor = System.Drawing.Color.Red;
            this.btndisable.Appearance.ForeColor = System.Drawing.Color.White;
            this.btndisable.Appearance.Options.UseBackColor = true;
            this.btndisable.Appearance.Options.UseForeColor = true;
            this.btndisable.Location = new System.Drawing.Point(756, 47);
            this.btndisable.Name = "btndisable";
            this.btndisable.Size = new System.Drawing.Size(228, 29);
            this.btndisable.TabIndex = 16;
            this.btndisable.Text = "Désactiver";
            this.btndisable.Click += new System.EventHandler(this.btndisable_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnclose);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btndisable);
            this.groupControl1.Controls.Add(this.drpusers);
            this.groupControl1.Location = new System.Drawing.Point(26, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1168, 100);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Désactiver Utilisateur";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnclose2);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.btnactivate);
            this.groupControl2.Controls.Add(this.drpusers2);
            this.groupControl2.Location = new System.Drawing.Point(26, 130);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1168, 100);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Activater Utilisateur";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Choisir Utilisateur";
            // 
            // btnactivate
            // 
            this.btnactivate.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnactivate.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnactivate.Appearance.Options.UseBackColor = true;
            this.btnactivate.Appearance.Options.UseForeColor = true;
            this.btnactivate.Location = new System.Drawing.Point(756, 47);
            this.btnactivate.Name = "btnactivate";
            this.btnactivate.Size = new System.Drawing.Size(228, 29);
            this.btnactivate.TabIndex = 16;
            this.btnactivate.Text = "Activer ";
            this.btnactivate.Click += new System.EventHandler(this.btnactivate_Click);
            // 
            // drpusers2
            // 
            this.drpusers2.Location = new System.Drawing.Point(145, 51);
            this.drpusers2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.drpusers2.Name = "drpusers2";
            this.drpusers2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpusers2.Properties.NullText = "";
            this.drpusers2.Size = new System.Drawing.Size(590, 22);
            this.drpusers2.TabIndex = 15;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(990, 46);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(123, 29);
            this.btnclose.TabIndex = 17;
            this.btnclose.Text = "Fermer";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnclose2
            // 
            this.btnclose2.Location = new System.Drawing.Point(990, 47);
            this.btnclose2.Name = "btnclose2";
            this.btnclose2.Size = new System.Drawing.Size(123, 29);
            this.btnclose2.TabIndex = 18;
            this.btnclose2.Text = "Fermer";
            this.btnclose2.Click += new System.EventHandler(this.btnclose2_Click);
            // 
            // frAdminDisableUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 260);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frAdminDisableUser";
            this.Text = "Désactiver l\'utilisateur";
            this.Load += new System.EventHandler(this.frAdminDisableUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drpusers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drpusers2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit drpusers;
        private DevExpress.XtraEditors.SimpleButton btndisable;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnactivate;
        private DevExpress.XtraEditors.LookUpEdit drpusers2;
        private DevExpress.XtraEditors.SimpleButton btnclose;
        private DevExpress.XtraEditors.SimpleButton btnclose2;
    }
}