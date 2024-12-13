﻿namespace SS_OpenCV
{
    partial class MainForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTSUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToBWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOnPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differentiationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilatationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayAndRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whitesInXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whitesInYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licensePlateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterRecognitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterSeparationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findLicensePlateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImageViewer = new System.Windows.Forms.PictureBox();
            this.blueChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images (*.png, *.bmp, *.jpg)|*.png;*.bmp;*.jpg";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.evalToolStripMenuItem,
            this.licensePlateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save As...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.transformsToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.autoZoomToolStripMenuItem,
            this.histogramsToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negativeToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.redToolStripMenuItem,
            this.blueChannelToolStripMenuItem,
            this.greenChannelToolStripMenuItem,
            this.brightnessContrastToolStripMenuItem,
            this.oTSUToolStripMenuItem,
            this.convertToBWToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negativeToolStripMenuItem.Text = "Negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem.Text = "Red Channel";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // brightnessContrastToolStripMenuItem
            // 
            this.brightnessContrastToolStripMenuItem.Name = "brightnessContrastToolStripMenuItem";
            this.brightnessContrastToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brightnessContrastToolStripMenuItem.Text = "Brightness & Contrast";
            this.brightnessContrastToolStripMenuItem.Click += new System.EventHandler(this.brightnessContrastToolStripMenuItem_Click);
            // 
            // oTSUToolStripMenuItem
            // 
            this.oTSUToolStripMenuItem.Name = "oTSUToolStripMenuItem";
            this.oTSUToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oTSUToolStripMenuItem.Text = "OTSU";
            this.oTSUToolStripMenuItem.Click += new System.EventHandler(this.oTSUToolStripMenuItem_Click_1);
            // 
            // convertToBWToolStripMenuItem
            // 
            this.convertToBWToolStripMenuItem.Name = "convertToBWToolStripMenuItem";
            this.convertToBWToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convertToBWToolStripMenuItem.Text = "Convert to BW";
            this.convertToBWToolStripMenuItem.Click += new System.EventHandler(this.convertToBWToolStripMenuItem_Click_1);
            // 
            // transformsToolStripMenuItem
            // 
            this.transformsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.translationToolStripMenuItem,
            this.rotationToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.zoomOnPointToolStripMenuItem});
            this.transformsToolStripMenuItem.Name = "transformsToolStripMenuItem";
            this.transformsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transformsToolStripMenuItem.Text = "Transforms";
            // 
            // translationToolStripMenuItem
            // 
            this.translationToolStripMenuItem.Name = "translationToolStripMenuItem";
            this.translationToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.translationToolStripMenuItem.Text = "Translation";
            this.translationToolStripMenuItem.Click += new System.EventHandler(this.translationToolStripMenuItem_Click);
            // 
            // rotationToolStripMenuItem
            // 
            this.rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            this.rotationToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.rotationToolStripMenuItem.Text = "Rotation";
            this.rotationToolStripMenuItem.Click += new System.EventHandler(this.rotationToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // zoomOnPointToolStripMenuItem
            // 
            this.zoomOnPointToolStripMenuItem.Name = "zoomOnPointToolStripMenuItem";
            this.zoomOnPointToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.zoomOnPointToolStripMenuItem.Text = "Zoom on point";
            this.zoomOnPointToolStripMenuItem.Click += new System.EventHandler(this.zoomOnPointToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaToolStripMenuItem,
            this.medianaToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.sobelVerticalToolStripMenuItem,
            this.sobelHorizontalToolStripMenuItem,
            this.differentiationToolStripMenuItem,
            this.robertsToolStripMenuItem,
            this.dilatationToolStripMenuItem,
            this.erosionToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.mediaToolStripMenuItem.Text = "Mean - solution A";
            this.mediaToolStripMenuItem.Click += new System.EventHandler(this.mediaToolStripMenuItem_Click);
            // 
            // medianaToolStripMenuItem
            // 
            this.medianaToolStripMenuItem.Name = "medianaToolStripMenuItem";
            this.medianaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.medianaToolStripMenuItem.Text = "Median";
            this.medianaToolStripMenuItem.Click += new System.EventHandler(this.medianaToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // sobelVerticalToolStripMenuItem
            // 
            this.sobelVerticalToolStripMenuItem.Name = "sobelVerticalToolStripMenuItem";
            this.sobelVerticalToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.sobelVerticalToolStripMenuItem.Text = "Sobel vertical";
            this.sobelVerticalToolStripMenuItem.Click += new System.EventHandler(this.sobelVerticalToolStripMenuItem_Click_1);
            // 
            // sobelHorizontalToolStripMenuItem
            // 
            this.sobelHorizontalToolStripMenuItem.Name = "sobelHorizontalToolStripMenuItem";
            this.sobelHorizontalToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.sobelHorizontalToolStripMenuItem.Text = "Sobel horizontal";
            this.sobelHorizontalToolStripMenuItem.Click += new System.EventHandler(this.sobelHorizontalToolStripMenuItem_Click);
            // 
            // differentiationToolStripMenuItem
            // 
            this.differentiationToolStripMenuItem.Name = "differentiationToolStripMenuItem";
            this.differentiationToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.differentiationToolStripMenuItem.Text = "Differentiation";
            this.differentiationToolStripMenuItem.Click += new System.EventHandler(this.differentiationToolStripMenuItem_Click);
            // 
            // robertsToolStripMenuItem
            // 
            this.robertsToolStripMenuItem.Name = "robertsToolStripMenuItem";
            this.robertsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.robertsToolStripMenuItem.Text = "Roberts";
            this.robertsToolStripMenuItem.Click += new System.EventHandler(this.robertsToolStripMenuItem_Click);
            // 
            // dilatationToolStripMenuItem
            // 
            this.dilatationToolStripMenuItem.Name = "dilatationToolStripMenuItem";
            this.dilatationToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.dilatationToolStripMenuItem.Text = "Dilatation";
            this.dilatationToolStripMenuItem.Click += new System.EventHandler(this.dilatationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // autoZoomToolStripMenuItem
            // 
            this.autoZoomToolStripMenuItem.CheckOnClick = true;
            this.autoZoomToolStripMenuItem.Name = "autoZoomToolStripMenuItem";
            this.autoZoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoZoomToolStripMenuItem.Text = "Auto Zoom";
            this.autoZoomToolStripMenuItem.Click += new System.EventHandler(this.autoZoomToolStripMenuItem_Click);
            // 
            // histogramsToolStripMenuItem
            // 
            this.histogramsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayToolStripMenuItem1,
            this.rGBToolStripMenuItem,
            this.grayAndRGBToolStripMenuItem,
            this.whitesInXToolStripMenuItem,
            this.whitesInYToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.histogramsToolStripMenuItem.Name = "histogramsToolStripMenuItem";
            this.histogramsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.histogramsToolStripMenuItem.Text = "Histograms";
            // 
            // grayToolStripMenuItem1
            // 
            this.grayToolStripMenuItem1.Name = "grayToolStripMenuItem1";
            this.grayToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.grayToolStripMenuItem1.Text = "Gray";
            this.grayToolStripMenuItem1.Click += new System.EventHandler(this.grayToolStripMenuItem1_Click);
            // 
            // rGBToolStripMenuItem
            // 
            this.rGBToolStripMenuItem.Name = "rGBToolStripMenuItem";
            this.rGBToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.rGBToolStripMenuItem.Text = "RGB";
            this.rGBToolStripMenuItem.Click += new System.EventHandler(this.rGBToolStripMenuItem_Click);
            // 
            // grayAndRGBToolStripMenuItem
            // 
            this.grayAndRGBToolStripMenuItem.Name = "grayAndRGBToolStripMenuItem";
            this.grayAndRGBToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.grayAndRGBToolStripMenuItem.Text = "Gray and RGB";
            this.grayAndRGBToolStripMenuItem.Click += new System.EventHandler(this.grayAndRGBToolStripMenuItem_Click);
            // 
            // whitesInXToolStripMenuItem
            // 
            this.whitesInXToolStripMenuItem.Name = "whitesInXToolStripMenuItem";
            this.whitesInXToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.whitesInXToolStripMenuItem.Text = "Whites in X";
            this.whitesInXToolStripMenuItem.Click += new System.EventHandler(this.whitesInXToolStripMenuItem_Click);
            // 
            // whitesInYToolStripMenuItem
            // 
            this.whitesInYToolStripMenuItem.Name = "whitesInYToolStripMenuItem";
            this.whitesInYToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.whitesInYToolStripMenuItem.Text = "Whites in Y";
            this.whitesInYToolStripMenuItem.Click += new System.EventHandler(this.whitesInYToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.autoresToolStripMenuItem.Text = "Autores...";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // evalToolStripMenuItem
            // 
            this.evalToolStripMenuItem.Name = "evalToolStripMenuItem";
            this.evalToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.evalToolStripMenuItem.Text = "Eval";
            this.evalToolStripMenuItem.Click += new System.EventHandler(this.evalToolStripMenuItem_Click);
            // 
            // licensePlateToolStripMenuItem
            // 
            this.licensePlateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characterRecognitionToolStripMenuItem,
            this.characterSeparationToolStripMenuItem,
            this.findLicensePlateToolStripMenuItem,
            this.aLLToolStripMenuItem});
            this.licensePlateToolStripMenuItem.Name = "licensePlateToolStripMenuItem";
            this.licensePlateToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.licensePlateToolStripMenuItem.Text = "License Plate";
            // 
            // characterRecognitionToolStripMenuItem
            // 
            this.characterRecognitionToolStripMenuItem.Name = "characterRecognitionToolStripMenuItem";
            this.characterRecognitionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.characterRecognitionToolStripMenuItem.Text = "Character Recognition";
            this.characterRecognitionToolStripMenuItem.Click += new System.EventHandler(this.characterRecognitionToolStripMenuItem_Click);
            // 
            // characterSeparationToolStripMenuItem
            // 
            this.characterSeparationToolStripMenuItem.Name = "characterSeparationToolStripMenuItem";
            this.characterSeparationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.characterSeparationToolStripMenuItem.Text = "Character Separation";
            this.characterSeparationToolStripMenuItem.Click += new System.EventHandler(this.characterSeparationToolStripMenuItem_Click);
            // 
            // findLicensePlateToolStripMenuItem
            // 
            this.findLicensePlateToolStripMenuItem.Name = "findLicensePlateToolStripMenuItem";
            this.findLicensePlateToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.findLicensePlateToolStripMenuItem.Text = "Find License Plate";
            this.findLicensePlateToolStripMenuItem.Click += new System.EventHandler(this.findLicensePlateToolStripMenuItem_Click_1);
            // 
            // aLLToolStripMenuItem
            // 
            this.aLLToolStripMenuItem.Name = "aLLToolStripMenuItem";
            this.aLLToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.aLLToolStripMenuItem.Text = "ALL";
            this.aLLToolStripMenuItem.Click += new System.EventHandler(this.aLLToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ImageViewer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 290);
            this.panel1.TabIndex = 6;
            // 
            // ImageViewer
            // 
            this.ImageViewer.Location = new System.Drawing.Point(3, 3);
            this.ImageViewer.Name = "ImageViewer";
            this.ImageViewer.Size = new System.Drawing.Size(576, 427);
            this.ImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageViewer.TabIndex = 6;
            this.ImageViewer.TabStop = false;
            // 
            // blueChannelToolStripMenuItem
            // 
            this.blueChannelToolStripMenuItem.Name = "blueChannelToolStripMenuItem";
            this.blueChannelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blueChannelToolStripMenuItem.Text = "Blue Channel";
            this.blueChannelToolStripMenuItem.Click += new System.EventHandler(this.blueChannelToolStripMenuItem_Click);
            // 
            // greenChannelToolStripMenuItem
            // 
            this.greenChannelToolStripMenuItem.Name = "greenChannelToolStripMenuItem";
            this.greenChannelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greenChannelToolStripMenuItem.Text = "Green Channel";
            this.greenChannelToolStripMenuItem.Click += new System.EventHandler(this.greenChannelToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sistemas Sensoriais 2021/2022 - Image processing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoZoomToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImageViewer;
        private System.Windows.Forms.ToolStripMenuItem evalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessContrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOnPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem differentiationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayAndRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whitesInXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whitesInYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilatationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licensePlateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterRecognitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterSeparationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findLicensePlateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTSUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToBWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenChannelToolStripMenuItem;
    }
}

