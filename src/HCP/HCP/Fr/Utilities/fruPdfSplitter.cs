using AutoMapper;
using DevExpress.XtraEditors;
using GdPicture14;
using HCP.Fr.Dao.Repository;
using HCP.Fr.DS;
using HCP.Fr.Logging;
using HCP.Fr.Logging.Helpers;
using HCP.Fr.Mappings;
using HCP.Helpers;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace HCP.Fr.Utilities
{
    public partial class fruPdfSplitter : DevExpress.XtraEditors.XtraForm
    {
        string _email;
        public fruPdfSplitter(string email)
        {
            InitializeComponent();
            _email = email;
        }
        private static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        private void fruPdfSplitter_Load(object sender, EventArgs e)
        {
            Text = "";
            var licMgr = new GdPictureLicenseManager();
            // LicenseManager oLicenseManager = new LicenseManager(); //Go to http://www.gdpicture.com/download-gdpicture/ to get a 1 month trial key unlocking all features of the toolkit.
            //oLicenseManager.RegisterKEY("XXXX"); //Please, replace XXXX by a valid demo or commercial license key.
            licMgr.SetDeveloperKey(licMgr.GetKey());
            //TextBox3.Text = Application.StartupPath + @"\";
            GetPdfSavedPath();
        }

        private void GetPdfSavedPath()
        {
            var config = AutoMapperMapper.Configuration;
            var mapper = config.CreateMapper();
            var obj = new UserPdfSplitPathsRepository();
            var repos = mapper.Map<IRepository<UserPdfSplitPaths>>(obj);
            var savedPaths = repos.GetAll();
            if (savedPaths != null)
            {
                var last_saved_paths = savedPaths.Where(x => x.ComputerName == Environment.MachineName);
                var last_save_path = last_saved_paths.OrderByDescending(x => DateTime.Parse(x.AjouterAu)).Take(1).SingleOrDefault();
                TextBox3.Text = last_save_path.SavedPath;
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Multiselect = false;
            OpenFileDialog1.Filter = "PDF Document (*.pdf)|*.pdf";
            OpenFileDialog1.FileName = "";

            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBox2.Text = OpenFileDialog1.FileName;
            }
        }

        private void btnsetdestpath_Click(object sender, EventArgs e)
        {
            try
            {
                if (FolderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TextBox3.Text = FolderBrowserDialog1.SelectedPath + @"\";
                    var config = AutoMapperMapper.Configuration;
                    var mapper = config.CreateMapper();
                    var obj = new UserPdfSplitPathsRepository();
                    var repos = mapper.Map<IRepository<UserPdfSplitPaths>>(obj);
                    var saveData = new UserPdfSplitPaths
                    {
                        AjouterAu = HCP.Helpers.CommonHelpers.GetEuDate(),
                        AjouterPar = HCP.Helpers.CommonHelpers.GetSystemUserName(_email),
                        ComputerName = Environment.MachineName,
                        Email = _email,
                        UserName = Environment.UserName,
                        SavedPath = TextBox3.Text
                    };
                    var result = repos.SaveOrUpdate(saveData);
                    if (result > 0)
                    {
                        DevExpressFrHelper.DisplayMessage("Le chemin a été enregistré.");
                        btnsetdestpath.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.LogToDb("btnsetdestpath_Click", "fruPdfSplitter.cs", _email);
                throw ex;
            }
        }

        private void btnprocess_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text.Length == 0)
            {
                DevExpressFrHelper.DisplayMessage("Veuillez parcourir le fichier PDF à diviser.");
            }
            else
            {
                string sImagepath = TextBox2.Text;
                int SplitEach = 0;
                string OutputFolder = TextBox3.Text;
                GdPictureStatus Status = GdPictureStatus.OK;
                GdPicturePDF oGdPicturePDFSrc = new GdPicturePDF();

                btnbrowse.Enabled = false;


                try
                {
                    // prevent for overflow exception
                    SplitEach = Convert.ToInt32(TextBox1.Text);
                }
                catch (Exception)
                {

                }

                if (SplitEach > 0)
                {

                    if (oGdPicturePDFSrc.LoadFromFile(sImagepath, false) == GdPictureStatus.OK)
                    {

                        // Check for encryption
                        if (oGdPicturePDFSrc.IsEncrypted())
                        {
                            if (oGdPicturePDFSrc.SetPassword("") != GdPictureStatus.OK)
                            {
                                String value = "";
                                String PassWord = "";
                                if (InputBox("", "Enter PDF password:", ref value) == DialogResult.OK)
                                {
                                    PassWord = value;
                                }
                                if (oGdPicturePDFSrc.SetPassword(PassWord) != GdPictureStatus.OK)
                                {
                                    MessageBox.Show("Can not uncrypt document");
                                    oGdPicturePDFSrc.CloseDocument();
                                    return;
                                }
                            }
                        }

                        // Checking if the document is  multipage
                        int PageCount = oGdPicturePDFSrc.GetPageCount();
                        if (PageCount > 1)
                        {
                            // Getting the initial compression scheme
                            int CurrentPage = 0;
                            string OutputFilePath = null;
                            int OutputFileCount = System.Convert.ToInt32(Math.Ceiling((double)PageCount / SplitEach));

                            ProgressBar1.Maximum = PageCount;

                            for (int i = 1; i <= OutputFileCount; i++)
                            {
                                GdPicturePDF oGdPicturePDFDest = new GdPicturePDF();
                                Status = oGdPicturePDFDest.NewPDF();
                                OutputFilePath = OutputFolder + "split" + i.ToString() + ".pdf";

                                for (int j = 1; j <= SplitEach; j++)
                                {
                                    CurrentPage = CurrentPage + 1;
                                    if (CurrentPage <= PageCount & Status == GdPictureStatus.OK)
                                    {
                                        //if (oGdPicturePDFDest.ClonePage(oGdPicturePDFSrc, CurrentPage) != GdPictureStatus.OK)
                                        if (oGdPicturePDFDest.ClonePage_2(oGdPicturePDFSrc, CurrentPage) != GdPictureStatus.OK)
                                            MessageBox.Show("Cannot clone image: " + oGdPicturePDFDest.GetStat().ToString());
                                        ProgressBar1.Value = CurrentPage;
                                        Application.DoEvents();
                                    }
                                }
                                if (oGdPicturePDFDest.SaveToFile(OutputFilePath) != GdPictureStatus.OK)
                                    MessageBox.Show("Error: " + oGdPicturePDFDest.GetStat().ToString());
                                if (oGdPicturePDFDest.CloseDocument() != GdPictureStatus.OK)
                                    MessageBox.Show("Cannot close image: " + oGdPicturePDFDest.GetStat().ToString());
                            }

                            if (Status == GdPictureStatus.OK)
                            {
                                MessageBox.Show("Success !");
                            }
                            else
                            {
                                MessageBox.Show("Error: ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error, The PDF is not a multipage document.");
                        }

                        if (oGdPicturePDFSrc.CloseDocument() != GdPictureStatus.OK)
                            MessageBox.Show("Cannot close image: " + oGdPicturePDFSrc.GetStat().ToString());
                    }
                    else
                    {
                        MessageBox.Show("Error, Can't open document: " + sImagepath);
                    }
                }
                else
                {
                    MessageBox.Show("Error, Incorrect value for split each.");
                }
                btnprocess.Enabled = true;
            }
        } //end btn
    }
}