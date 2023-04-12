namespace HCP.Fr.Admin
{
    partial class frAdminManageUsers
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnrtf = new DevExpress.XtraEditors.SimpleButton();
            this.btnword = new DevExpress.XtraEditors.SimpleButton();
            this.btnhtml = new DevExpress.XtraEditors.SimpleButton();
            this.btncsv = new DevExpress.XtraEditors.SimpleButton();
            this.btnexcel = new DevExpress.XtraEditors.SimpleButton();
            this.btn = new DevExpress.XtraEditors.SimpleButton();
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 106);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1706, 631);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnrtf);
            this.groupControl1.Controls.Add(this.btnword);
            this.groupControl1.Controls.Add(this.btnhtml);
            this.groupControl1.Controls.Add(this.btncsv);
            this.groupControl1.Controls.Add(this.btnexcel);
            this.groupControl1.Controls.Add(this.btn);
            this.groupControl1.Controls.Add(this.btnprint);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1706, 100);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnrtf
            // 
            this.btnrtf.Location = new System.Drawing.Point(731, 43);
            this.btnrtf.Name = "btnrtf";
            this.btnrtf.Size = new System.Drawing.Size(94, 29);
            this.btnrtf.TabIndex = 6;
            this.btnrtf.Text = "Rtf";
            this.btnrtf.Click += new System.EventHandler(this.btnrtf_Click);
            // 
            // btnword
            // 
            this.btnword.Location = new System.Drawing.Point(616, 43);
            this.btnword.Name = "btnword";
            this.btnword.Size = new System.Drawing.Size(94, 29);
            this.btnword.TabIndex = 5;
            this.btnword.Text = "Word";
            this.btnword.Click += new System.EventHandler(this.btnword_Click);
            // 
            // btnhtml
            // 
            this.btnhtml.Location = new System.Drawing.Point(499, 43);
            this.btnhtml.Name = "btnhtml";
            this.btnhtml.Size = new System.Drawing.Size(94, 29);
            this.btnhtml.TabIndex = 4;
            this.btnhtml.Text = "HTML";
            this.btnhtml.Click += new System.EventHandler(this.btnhtml_Click);
            // 
            // btncsv
            // 
            this.btncsv.Location = new System.Drawing.Point(377, 43);
            this.btncsv.Name = "btncsv";
            this.btncsv.Size = new System.Drawing.Size(94, 29);
            this.btncsv.TabIndex = 3;
            this.btncsv.Text = "CSV";
            this.btncsv.Click += new System.EventHandler(this.btncsv_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(265, 42);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(94, 29);
            this.btnexcel.TabIndex = 2;
            this.btnexcel.Text = "Excel";
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(147, 43);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(94, 29);
            this.btn.TabIndex = 1;
            this.btn.Text = "PDF";
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(28, 43);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(94, 29);
            this.btnprint.TabIndex = 0;
            this.btnprint.Text = "Imprimer";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // frAdminManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 737);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frAdminManageUsers";
            this.Text = "frAdminManageUsers";
            this.Load += new System.EventHandler(this.frAdminManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnexcel;
        private DevExpress.XtraEditors.SimpleButton btn;
        private DevExpress.XtraEditors.SimpleButton btnprint;
        private DevExpress.XtraEditors.SimpleButton btncsv;
        private DevExpress.XtraEditors.SimpleButton btnhtml;
        private DevExpress.XtraEditors.SimpleButton btnword;
        private DevExpress.XtraEditors.SimpleButton btnrtf;
    }
}