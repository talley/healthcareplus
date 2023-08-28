﻿namespace HCP.Fr.Admin.SpecialitiesUI
{
    partial class fruAdminImportSpecialities
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
            this.txtpath = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnbrowse = new DevExpress.XtraEditors.SimpleButton();
            this.btnupload = new DevExpress.XtraEditors.SimpleButton();
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            ((System.ComponentModel.ISupportInitialize)(this.txtpath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpath
            // 
            this.txtpath.Enabled = false;
            this.txtpath.Location = new System.Drawing.Point(12, 45);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(1188, 22);
            this.txtpath.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnbrowse);
            this.groupControl1.Controls.Add(this.btnupload);
            this.groupControl1.Controls.Add(this.txtpath);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1743, 100);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Recherche";
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(1219, 38);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(170, 29);
            this.btnbrowse.TabIndex = 4;
            this.btnbrowse.Text = "Parcourir";
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(1412, 38);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(170, 29);
            this.btnupload.TabIndex = 2;
            this.btnupload.Text = "Télécharger";
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(2, 28);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Size = new System.Drawing.Size(1739, 1053);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.spreadsheetControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1743, 1083);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Données";
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // fruAdminImportSpecialities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 1083);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "fruAdminImportSpecialities";
            this.Text = "fruAdminImportSpecialities";
            this.Load += new System.EventHandler(this.fruAdminImportSpecialities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtpath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtpath;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnbrowse;
        private DevExpress.XtraEditors.SimpleButton btnupload;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.ComponentModel.BackgroundWorker bw;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
    }
}