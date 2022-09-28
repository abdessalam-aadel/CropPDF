using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using pdftron;
using pdftron.Common;
using pdftron.SDF;
using pdftron.PDF;

namespace CropPDF
{
    public partial class FrmMain : Form
    {
        string[] PDFfiles;
        int fileCount = 0;

        // Required for AnyCPU implementation.
        private static PDFNetLoader loader = PDFNetLoader.Instance();


        public FrmMain()
        {
            InitializeComponent();
        }

        public static int SearchDirectoryTree(string path, out string[] PDFfiles)
        {
            PDFfiles = Directory.GetFiles(path, "*.pdf", SearchOption.AllDirectories);
            return PDFfiles.Length;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FD = new FolderBrowserDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                txtBoxLoad.Text = FD.SelectedPath;
                fileCount = SearchDirectoryTree(FD.SelectedPath, out PDFfiles);
                // Check the Empty Folder
                if (fileCount == 0)
                    txtTotales.Text = "Your Folder is Empty";
                else
                    txtTotales.Text = fileCount + " files.";
            }
        }

        private void btnStartCroping_Click(object sender, EventArgs e)
        {
            // Check if the user has been selected a folder
            if (PDFfiles == null)
            {
                txtAlert.Text = "Please select your folder and try again!";
                return;
            }

            // Check the Empty Folder
            if (fileCount == 0)
            {
                return;
            }
            
            // Clear the Alert message and success message
            txtDone.Text = "";
            txtAlert.Text = "";

            Cursor = Cursors.WaitCursor;

            // Initialize PDFNet before using any PDFTron related
            // classes and methods (some exceptions can be found in API)
            PDFNet.Initialize();

            // Using PDFNet related classes and methods, must catch or throw PDFNetException
            try
            {
                foreach (string filePath in PDFfiles)
                {
                    using (PDFDoc doc = new PDFDoc(filePath))
                    {
                        doc.InitSecurityHandler();

                        // Access a PDF page 1
                        Page page1 = doc.GetPage(1);

                        // Access a PDF page 2
                        Page page2 = doc.GetPage(2);
                        
                        // Creat a copy from page 1 
                        doc.PagePushBack(page1);

                        // Access to a new PDF page 3
                        Page page3 = doc.GetPage(3);

                        // Crop the first, second and third page
                        page1.SetCropBox(new Rect(565, 0, 1587, 1096));
                        page2.SetCropBox(new Rect(565, 0, 1587, 1096));
                        page3.SetCropBox(new Rect(0, 0, 575, 1096));

                        // Save as a linearized file which is most popular 
                        // and effective format for quick PDF Viewing.
                        doc.Save(filePath, SDFDoc.SaveOptions.e_linearized);
                    }
                }
            }
            catch (PDFNetException ex)
            {
                MessageBox.Show(ex.Message);
            }

            PDFNet.Terminate();
            Cursor = Cursors.Default;
            txtDone.Text = "Done!";
        }

        private void txtGit_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/abdessalam-aadel");
        }

        private void FrmMain_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            txtBoxLoad.Text = path;
            fileCount = SearchDirectoryTree(path, out PDFfiles);
            // Check the Empty Folder
            if (fileCount == 0)
                txtTotales.Text = "Your Folder is Empty";
            else
                txtTotales.Text = fileCount + " files.";
        }

        private void FrmMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
