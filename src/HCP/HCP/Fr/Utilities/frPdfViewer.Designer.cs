﻿namespace HCP.Fr.Utilities
{
    partial class frPdfViewer
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
            this.components = new System.ComponentModel.Container();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pdfBarController1 = new DevExpress.XtraPdfViewer.Bars.PdfBarController(this.components);
            this.pdfCommandBar1 = new DevExpress.XtraPdfViewer.Bars.PdfCommandBar();
            this.pdfFileOpenBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem();
            this.pdfFileSaveAsBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem();
            this.pdfFilePrintBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem();
            this.pdfFindTextBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem();
            this.pdfPreviousPageBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem();
            this.pdfNextPageBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem();
            this.pdfSetPageNumberBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem();
            this.repositoryItemPageNumberEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit();
            this.pdfZoomOutBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem();
            this.pdfZoomInBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem();
            this.pdfZoom10CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem();
            this.pdfZoom25CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem();
            this.pdfZoom50CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem();
            this.pdfZoom75CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem();
            this.pdfZoom100CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem();
            this.pdfZoom125CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem();
            this.pdfZoom150CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem();
            this.pdfZoom200CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem();
            this.pdfZoom400CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem();
            this.pdfZoom500CheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem();
            this.pdfSetActualSizeZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem();
            this.pdfSetPageLevelZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem();
            this.pdfSetFitWidthZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem();
            this.pdfSetFitVisibleZoomModeCheckItem1 = new DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem();
            this.pdfExactZoomListBarSubItem1 = new DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem();
            this.pdfCommentBar1 = new DevExpress.XtraPdfViewer.Bars.PdfCommentBar();
            this.pdfTextHighlightBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfTextHighlightBarItem();
            this.pdfTextStrikethroughBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfTextStrikethroughBarItem();
            this.pdfTextUnderlineBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfTextUnderlineBarItem();
            this.pdfStickyNoteBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfStickyNoteBarItem();
            this.pdfExportFormDataBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem();
            this.pdfImportFormDataBarItem1 = new DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 33);
            this.pdfViewer1.MenuManager = this.barManager1;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(1322, 1068);
            this.pdfViewer1.TabIndex = 0;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.pdfCommandBar1,
            this.pdfCommentBar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.pdfFileOpenBarItem1,
            this.pdfFileSaveAsBarItem1,
            this.pdfFilePrintBarItem1,
            this.pdfFindTextBarItem1,
            this.pdfPreviousPageBarItem1,
            this.pdfNextPageBarItem1,
            this.pdfSetPageNumberBarItem1,
            this.pdfZoomOutBarItem1,
            this.pdfZoomInBarItem1,
            this.pdfExactZoomListBarSubItem1,
            this.pdfZoom10CheckItem1,
            this.pdfZoom25CheckItem1,
            this.pdfZoom50CheckItem1,
            this.pdfZoom75CheckItem1,
            this.pdfZoom100CheckItem1,
            this.pdfZoom125CheckItem1,
            this.pdfZoom150CheckItem1,
            this.pdfZoom200CheckItem1,
            this.pdfZoom400CheckItem1,
            this.pdfZoom500CheckItem1,
            this.pdfSetActualSizeZoomModeCheckItem1,
            this.pdfSetPageLevelZoomModeCheckItem1,
            this.pdfSetFitWidthZoomModeCheckItem1,
            this.pdfSetFitVisibleZoomModeCheckItem1,
            this.pdfTextHighlightBarItem1,
            this.pdfTextStrikethroughBarItem1,
            this.pdfTextUnderlineBarItem1,
            this.pdfStickyNoteBarItem1,
            this.pdfExportFormDataBarItem1,
            this.pdfImportFormDataBarItem1});
            this.barManager1.MaxItemId = 30;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPageNumberEdit1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1322, 33);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1101);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1322, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1068);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1322, 33);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1068);
            // 
            // pdfBarController1
            // 
            this.pdfBarController1.BarItems.Add(this.pdfFileOpenBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfFileSaveAsBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfFilePrintBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfFindTextBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfPreviousPageBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfNextPageBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetPageNumberBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoomOutBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoomInBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom10CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom25CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom50CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom75CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom100CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom125CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom150CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom200CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom400CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfZoom500CheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetActualSizeZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetPageLevelZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetFitWidthZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfSetFitVisibleZoomModeCheckItem1);
            this.pdfBarController1.BarItems.Add(this.pdfExactZoomListBarSubItem1);
            this.pdfBarController1.BarItems.Add(this.pdfTextHighlightBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfTextStrikethroughBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfTextUnderlineBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfStickyNoteBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfExportFormDataBarItem1);
            this.pdfBarController1.BarItems.Add(this.pdfImportFormDataBarItem1);
            this.pdfBarController1.Control = this.pdfViewer1;
            // 
            // pdfCommandBar1
            // 
            this.pdfCommandBar1.Control = this.pdfViewer1;
            this.pdfCommandBar1.DockCol = 0;
            this.pdfCommandBar1.DockRow = 0;
            this.pdfCommandBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.pdfCommandBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfFileOpenBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfFileSaveAsBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfFilePrintBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfFindTextBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfPreviousPageBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfNextPageBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetPageNumberBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoomOutBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoomInBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfExactZoomListBarSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfExportFormDataBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfImportFormDataBarItem1)});
            // 
            // pdfFileOpenBarItem1
            // 
            this.pdfFileOpenBarItem1.Id = 0;
            this.pdfFileOpenBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.pdfFileOpenBarItem1.Name = "pdfFileOpenBarItem1";
            // 
            // pdfFileSaveAsBarItem1
            // 
            this.pdfFileSaveAsBarItem1.Id = 1;
            this.pdfFileSaveAsBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.pdfFileSaveAsBarItem1.Name = "pdfFileSaveAsBarItem1";
            // 
            // pdfFilePrintBarItem1
            // 
            this.pdfFilePrintBarItem1.Id = 2;
            this.pdfFilePrintBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.pdfFilePrintBarItem1.Name = "pdfFilePrintBarItem1";
            // 
            // pdfFindTextBarItem1
            // 
            this.pdfFindTextBarItem1.Id = 3;
            this.pdfFindTextBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.pdfFindTextBarItem1.Name = "pdfFindTextBarItem1";
            // 
            // pdfPreviousPageBarItem1
            // 
            this.pdfPreviousPageBarItem1.Id = 4;
            this.pdfPreviousPageBarItem1.Name = "pdfPreviousPageBarItem1";
            // 
            // pdfNextPageBarItem1
            // 
            this.pdfNextPageBarItem1.Id = 5;
            this.pdfNextPageBarItem1.Name = "pdfNextPageBarItem1";
            // 
            // pdfSetPageNumberBarItem1
            // 
            this.pdfSetPageNumberBarItem1.Edit = this.repositoryItemPageNumberEdit1;
            this.pdfSetPageNumberBarItem1.Id = 6;
            this.pdfSetPageNumberBarItem1.Name = "pdfSetPageNumberBarItem1";
            // 
            // repositoryItemPageNumberEdit1
            // 
            this.repositoryItemPageNumberEdit1.AutoHeight = false;
            this.repositoryItemPageNumberEdit1.Mask.EditMask = "########;";
            this.repositoryItemPageNumberEdit1.Name = "repositoryItemPageNumberEdit1";
            this.repositoryItemPageNumberEdit1.Orientation = DevExpress.XtraEditors.PagerOrientation.Horizontal;
            // 
            // pdfZoomOutBarItem1
            // 
            this.pdfZoomOutBarItem1.Id = 7;
            this.pdfZoomOutBarItem1.Name = "pdfZoomOutBarItem1";
            // 
            // pdfZoomInBarItem1
            // 
            this.pdfZoomInBarItem1.Id = 8;
            this.pdfZoomInBarItem1.Name = "pdfZoomInBarItem1";
            // 
            // pdfZoom10CheckItem1
            // 
            this.pdfZoom10CheckItem1.Id = 10;
            this.pdfZoom10CheckItem1.Name = "pdfZoom10CheckItem1";
            // 
            // pdfZoom25CheckItem1
            // 
            this.pdfZoom25CheckItem1.Id = 11;
            this.pdfZoom25CheckItem1.Name = "pdfZoom25CheckItem1";
            // 
            // pdfZoom50CheckItem1
            // 
            this.pdfZoom50CheckItem1.Id = 12;
            this.pdfZoom50CheckItem1.Name = "pdfZoom50CheckItem1";
            // 
            // pdfZoom75CheckItem1
            // 
            this.pdfZoom75CheckItem1.Id = 13;
            this.pdfZoom75CheckItem1.Name = "pdfZoom75CheckItem1";
            // 
            // pdfZoom100CheckItem1
            // 
            this.pdfZoom100CheckItem1.Id = 14;
            this.pdfZoom100CheckItem1.Name = "pdfZoom100CheckItem1";
            // 
            // pdfZoom125CheckItem1
            // 
            this.pdfZoom125CheckItem1.Id = 15;
            this.pdfZoom125CheckItem1.Name = "pdfZoom125CheckItem1";
            // 
            // pdfZoom150CheckItem1
            // 
            this.pdfZoom150CheckItem1.Id = 16;
            this.pdfZoom150CheckItem1.Name = "pdfZoom150CheckItem1";
            // 
            // pdfZoom200CheckItem1
            // 
            this.pdfZoom200CheckItem1.Id = 17;
            this.pdfZoom200CheckItem1.Name = "pdfZoom200CheckItem1";
            // 
            // pdfZoom400CheckItem1
            // 
            this.pdfZoom400CheckItem1.Id = 18;
            this.pdfZoom400CheckItem1.Name = "pdfZoom400CheckItem1";
            // 
            // pdfZoom500CheckItem1
            // 
            this.pdfZoom500CheckItem1.Id = 19;
            this.pdfZoom500CheckItem1.Name = "pdfZoom500CheckItem1";
            // 
            // pdfSetActualSizeZoomModeCheckItem1
            // 
            this.pdfSetActualSizeZoomModeCheckItem1.Id = 20;
            this.pdfSetActualSizeZoomModeCheckItem1.Name = "pdfSetActualSizeZoomModeCheckItem1";
            // 
            // pdfSetPageLevelZoomModeCheckItem1
            // 
            this.pdfSetPageLevelZoomModeCheckItem1.Id = 21;
            this.pdfSetPageLevelZoomModeCheckItem1.Name = "pdfSetPageLevelZoomModeCheckItem1";
            // 
            // pdfSetFitWidthZoomModeCheckItem1
            // 
            this.pdfSetFitWidthZoomModeCheckItem1.Id = 22;
            this.pdfSetFitWidthZoomModeCheckItem1.Name = "pdfSetFitWidthZoomModeCheckItem1";
            // 
            // pdfSetFitVisibleZoomModeCheckItem1
            // 
            this.pdfSetFitVisibleZoomModeCheckItem1.Id = 23;
            this.pdfSetFitVisibleZoomModeCheckItem1.Name = "pdfSetFitVisibleZoomModeCheckItem1";
            // 
            // pdfExactZoomListBarSubItem1
            // 
            this.pdfExactZoomListBarSubItem1.Id = 9;
            this.pdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom10CheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom25CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom50CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom75CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom100CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom125CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom150CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom200CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom400CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfZoom500CheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetActualSizeZoomModeCheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetPageLevelZoomModeCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitWidthZoomModeCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfSetFitVisibleZoomModeCheckItem1)});
            this.pdfExactZoomListBarSubItem1.Name = "pdfExactZoomListBarSubItem1";
            this.pdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // pdfCommentBar1
            // 
            this.pdfCommentBar1.Control = this.pdfViewer1;
            this.pdfCommentBar1.DockCol = 1;
            this.pdfCommentBar1.DockRow = 0;
            this.pdfCommentBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.pdfCommentBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfTextHighlightBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfTextStrikethroughBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfTextUnderlineBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.pdfStickyNoteBarItem1)});
            // 
            // pdfTextHighlightBarItem1
            // 
            this.pdfTextHighlightBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown;
            this.pdfTextHighlightBarItem1.Id = 26;
            this.pdfTextHighlightBarItem1.Name = "pdfTextHighlightBarItem1";
            // 
            // pdfTextStrikethroughBarItem1
            // 
            this.pdfTextStrikethroughBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown;
            this.pdfTextStrikethroughBarItem1.Id = 27;
            this.pdfTextStrikethroughBarItem1.Name = "pdfTextStrikethroughBarItem1";
            // 
            // pdfTextUnderlineBarItem1
            // 
            this.pdfTextUnderlineBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown;
            this.pdfTextUnderlineBarItem1.Id = 28;
            this.pdfTextUnderlineBarItem1.Name = "pdfTextUnderlineBarItem1";
            // 
            // pdfStickyNoteBarItem1
            // 
            this.pdfStickyNoteBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown;
            this.pdfStickyNoteBarItem1.Id = 29;
            this.pdfStickyNoteBarItem1.Name = "pdfStickyNoteBarItem1";
            // 
            // pdfExportFormDataBarItem1
            // 
            this.pdfExportFormDataBarItem1.Id = 24;
            this.pdfExportFormDataBarItem1.Name = "pdfExportFormDataBarItem1";
            // 
            // pdfImportFormDataBarItem1
            // 
            this.pdfImportFormDataBarItem1.Id = 25;
            this.pdfImportFormDataBarItem1.Name = "pdfImportFormDataBarItem1";
            // 
            // frPdfViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 1101);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frPdfViewer";
            this.Text = "frPdfViewer";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPageNumberEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraPdfViewer.Bars.PdfCommandBar pdfCommandBar1;
        private DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem pdfFileOpenBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem pdfFileSaveAsBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem pdfFilePrintBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem pdfFindTextBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem pdfPreviousPageBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem pdfNextPageBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem pdfSetPageNumberBarItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit repositoryItemPageNumberEdit1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem pdfZoomOutBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem pdfZoomInBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem pdfExactZoomListBarSubItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem pdfZoom10CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem pdfZoom25CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem pdfZoom50CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem pdfZoom75CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem pdfZoom100CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem pdfZoom125CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem pdfZoom150CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem pdfZoom200CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem pdfZoom400CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem pdfZoom500CheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem pdfSetActualSizeZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem pdfSetPageLevelZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem pdfSetFitWidthZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem pdfSetFitVisibleZoomModeCheckItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem pdfExportFormDataBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem pdfImportFormDataBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfCommentBar pdfCommentBar1;
        private DevExpress.XtraPdfViewer.Bars.PdfTextHighlightBarItem pdfTextHighlightBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfTextStrikethroughBarItem pdfTextStrikethroughBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfTextUnderlineBarItem pdfTextUnderlineBarItem1;
        private DevExpress.XtraPdfViewer.Bars.PdfStickyNoteBarItem pdfStickyNoteBarItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraPdfViewer.Bars.PdfBarController pdfBarController1;
    }
}