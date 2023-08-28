namespace HCP.Fr.Admin.SpecialitiesUI
{
    partial class fruAddSpeciality
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtspeciality = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ckstatus = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtdesc = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtspeciality.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckstatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnclose);
            this.groupControl1.Controls.Add(this.btnadd);
            this.groupControl1.Controls.Add(this.txtdesc);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.ckstatus);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtspeciality);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1250, 371);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ajouter Une Spécialité";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 371);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1250, 381);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Spécialité";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Spécialité";
            // 
            // txtspeciality
            // 
            this.txtspeciality.Location = new System.Drawing.Point(86, 43);
            this.txtspeciality.Name = "txtspeciality";
            this.txtspeciality.Size = new System.Drawing.Size(317, 22);
            this.txtspeciality.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(409, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Statut";
            // 
            // ckstatus
            // 
            this.ckstatus.Location = new System.Drawing.Point(491, 44);
            this.ckstatus.Name = "ckstatus";
            this.ckstatus.Properties.Caption = "";
            this.ckstatus.Size = new System.Drawing.Size(94, 21);
            this.ckstatus.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Description";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(86, 88);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            this.txtdesc.Size = new System.Drawing.Size(1141, 200);
            this.txtdesc.TabIndex = 5;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(86, 304);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(197, 29);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Ajouter";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(307, 304);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(197, 29);
            this.btnclose.TabIndex = 7;
            this.btnclose.Text = "Fermer";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1246, 351);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // fruAddSpeciality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 752);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "fruAddSpeciality";
            this.Text = "fruAddSpeciality";
            this.Load += new System.EventHandler(this.fruAddSpeciality_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtspeciality.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckstatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtspeciality;
        private DevExpress.XtraEditors.CheckEdit ckstatus;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraRichEdit.RichEditControl txtdesc;
        private DevExpress.XtraEditors.SimpleButton btnclose;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}