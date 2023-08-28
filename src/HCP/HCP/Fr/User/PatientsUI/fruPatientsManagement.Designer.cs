namespace HCP.Fr.User.PatientsUI
{
    partial class fruPatientsManagement
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
            this.btnsearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtvalue = new DevExpress.XtraEditors.TextEdit();
            this.drpcriterias = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnhtml = new DevExpress.XtraEditors.SimpleButton();
            this.btnword = new DevExpress.XtraEditors.SimpleButton();
            this.btnpreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            this.btnexcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnpdf = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpcriterias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 111);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1793, 848);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsClipboard.AllowCsvFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowExcelFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.AllowHtmlFormat = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowPreview = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.btnsearch);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtvalue);
            this.groupControl1.Controls.Add(this.drpcriterias);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(872, 93);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Recherche";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(698, 44);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(166, 23);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "Rechercher";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(400, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Valeur";
            // 
            // txtvalue
            // 
            this.txtvalue.Location = new System.Drawing.Point(458, 45);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(236, 22);
            this.txtvalue.TabIndex = 2;
            // 
            // drpcriterias
            // 
            this.drpcriterias.Location = new System.Drawing.Point(127, 45);
            this.drpcriterias.Name = "drpcriterias";
            this.drpcriterias.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.drpcriterias.Size = new System.Drawing.Size(267, 22);
            this.drpcriterias.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Choisis une option";
            // 
            // groupControl2
            // 
            this.groupControl2.AutoSize = true;
            this.groupControl2.Controls.Add(this.btnhtml);
            this.groupControl2.Controls.Add(this.btnword);
            this.groupControl2.Controls.Add(this.btnpreview);
            this.groupControl2.Controls.Add(this.btnprint);
            this.groupControl2.Controls.Add(this.btnexcel);
            this.groupControl2.Controls.Add(this.btnpdf);
            this.groupControl2.Location = new System.Drawing.Point(878, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(903, 93);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Export";
            // 
            // btnhtml
            // 
            this.btnhtml.Location = new System.Drawing.Point(633, 41);
            this.btnhtml.Name = "btnhtml";
            this.btnhtml.Size = new System.Drawing.Size(103, 30);
            this.btnhtml.TabIndex = 5;
            this.btnhtml.Text = "HTML";
            this.btnhtml.Click += new System.EventHandler(this.btnhtml_Click);
            // 
            // btnword
            // 
            this.btnword.Location = new System.Drawing.Point(392, 41);
            this.btnword.Name = "btnword";
            this.btnword.Size = new System.Drawing.Size(103, 30);
            this.btnword.TabIndex = 4;
            this.btnword.Text = "Word";
            this.btnword.Click += new System.EventHandler(this.btnword_Click);
            // 
            // btnpreview
            // 
            this.btnpreview.Location = new System.Drawing.Point(19, 41);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(103, 30);
            this.btnpreview.TabIndex = 3;
            this.btnpreview.Text = "Aperçu";
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(144, 41);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(103, 30);
            this.btnprint.TabIndex = 2;
            this.btnprint.Text = "Imprimer";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(266, 41);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(103, 30);
            this.btnexcel.TabIndex = 1;
            this.btnexcel.Text = "Excel";
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btnpdf
            // 
            this.btnpdf.Location = new System.Drawing.Point(511, 41);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(103, 30);
            this.btnpdf.TabIndex = 0;
            this.btnpdf.Text = "PDF";
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // fruPatientsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 959);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "fruPatientsManagement";
            this.Text = "fruPatientsManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fruPatientsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpcriterias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnprint;
        private DevExpress.XtraEditors.SimpleButton btnexcel;
        private DevExpress.XtraEditors.SimpleButton btnpdf;
        private DevExpress.XtraEditors.SimpleButton btnpreview;
        private DevExpress.XtraEditors.SimpleButton btnword;
        private DevExpress.XtraEditors.SimpleButton btnhtml;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit drpcriterias;
        private DevExpress.XtraEditors.TextEdit txtvalue;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnsearch;
    }
}