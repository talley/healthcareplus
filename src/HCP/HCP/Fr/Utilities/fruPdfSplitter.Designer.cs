namespace HCP.Fr.Utilities
{
    partial class fruPdfSplitter
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
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnprocess = new System.Windows.Forms.Button();
            this.btnsetdestpath = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(29, 288);
            this.ProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(775, 25);
            this.ProgressBar1.TabIndex = 43;
            // 
            // btnprocess
            // 
            this.btnprocess.Location = new System.Drawing.Point(826, 288);
            this.btnprocess.Margin = new System.Windows.Forms.Padding(4);
            this.btnprocess.Name = "btnprocess";
            this.btnprocess.Size = new System.Drawing.Size(382, 25);
            this.btnprocess.TabIndex = 42;
            this.btnprocess.Text = "Traiter le fractionnement de PDF";
            this.btnprocess.UseVisualStyleBackColor = true;
            this.btnprocess.Click += new System.EventHandler(this.btnprocess_Click);
            // 
            // btnsetdestpath
            // 
            this.btnsetdestpath.Location = new System.Drawing.Point(812, 148);
            this.btnsetdestpath.Margin = new System.Windows.Forms.Padding(4);
            this.btnsetdestpath.Name = "btnsetdestpath";
            this.btnsetdestpath.Size = new System.Drawing.Size(120, 25);
            this.btnsetdestpath.TabIndex = 41;
            this.btnsetdestpath.Text = "Définir le chemin";
            this.btnsetdestpath.UseVisualStyleBackColor = true;
            this.btnsetdestpath.Click += new System.EventHandler(this.btnsetdestpath_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(13, 151);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(144, 16);
            this.Label4.TabIndex = 40;
            this.Label4.Text = "Dossier de destination:";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(216, 148);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.ReadOnly = true;
            this.TextBox3.Size = new System.Drawing.Size(588, 22);
            this.TextBox3.TabIndex = 39;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(812, 51);
            this.btnbrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(120, 25);
            this.btnbrowse.TabIndex = 38;
            this.btnbrowse.Text = "Parcourir";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(29, 51);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(157, 16);
            this.Label3.TabIndex = 37;
            this.Label3.Text = "Choisissez le fichier PDF:";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(216, 51);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new System.Drawing.Size(588, 22);
            this.TextBox2.TabIndex = 36;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(1166, 54);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(42, 16);
            this.Label2.TabIndex = 35;
            this.Label2.Text = "page.";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(1079, 52);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(64, 22);
            this.TextBox1.TabIndex = 34;
            this.TextBox1.Text = "2";
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(959, 55);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 16);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "Split each:";
            // 
            // fruPdfSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 372);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.btnprocess);
            this.Controls.Add(this.btnsetdestpath);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Name = "fruPdfSplitter";
            this.Text = "fruPdfSplitter";
            this.Load += new System.EventHandler(this.fruPdfSplitter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.Button btnprocess;
        internal System.Windows.Forms.Button btnsetdestpath;
        public System.Windows.Forms.ToolTip ToolTip1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Button btnbrowse;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
    }
}