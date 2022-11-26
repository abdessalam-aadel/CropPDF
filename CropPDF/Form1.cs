using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using pdftron;
using pdftron.SDF;
using pdftron.PDF;

namespace CropPDF
{
    public partial class FrmMain : Form
    {
        string[] PDFfiles;
        int fileCount = 0;
        public bool ischecked = false;
        string selected_path;

        // Required for AnyCPU implementation.
        private static PDFNetLoader loader = PDFNetLoader.Instance();

        public FrmMain() => InitializeComponent();

        public static int SearchDirectoryTree(string path, out string[] PDFfiles)
        {
            PDFfiles = Directory.GetFiles(path, "*.pdf", SearchOption.AllDirectories);
            return PDFfiles.Length;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FD = new FolderBrowserDialog();
            if (selected_path != null)
                FD.SelectedPath = selected_path;

            if (FD.ShowDialog() == DialogResult.OK)
            {
                selected_path = FD.SelectedPath;
                txtBoxLoad.Text = FD.SelectedPath;
                fileCount = SearchDirectoryTree(FD.SelectedPath, out PDFfiles);
                // Check the Empty Folder
                txtTotales.Text = fileCount == 0 ? "Your Folder is Empty" : fileCount + " files.";
                // Clear the Alert message and success message
                txtDone.Text = "";
                txtAlert.Text = "";
                IMGDone.Visible = false;
            }
        }

        private void btnStartCroping_Click(object sender, EventArgs e)
        {
            // Clear the Alert message and success message
            txtDone.Text = "";
            txtAlert.Text = "";
            IMGDone.Visible = false;

            // Check if the user has been selected a folder
            if (PDFfiles == null)
            {
                txtAlert.Text = "Please select your folder or drag your PDF file and try again!";
                return;
            }

            // Check the Empty Folder
            if (fileCount == 0)
            {
                txtAlert.Text = "Your Folder is Empty";
                return;
            }

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
                        int nbrPages = doc.GetPageCount();

                        if (ischecked)
                        {
                            doc.InitSecurityHandler();

                            // Start Convertion ...
                            // Convert String to Integer 
                            // ( add System to Class Convert to avoid a conflit between Convert of PDFTron )
                            int X1 = System.Convert.ToInt32(txtBoxX1.Text);
                            int X2 = System.Convert.ToInt32(txtBoxX2.Text);
                            int Y1 = System.Convert.ToInt32(txtBoxY1.Text);
                            int Y2 = System.Convert.ToInt32(txtBoxY2.Text);

                            // Start for loop to crop all pages with the same parametre
                            for (int i = 1; i < nbrPages + 1; i++)
                            {
                                // Access a PDF page
                                Page page = doc.GetPage(i);
                                // Crop the page
                                page.SetCropBox(new Rect(X1, Y1, X2, Y2));
                            }
                            // Save as a linearized file which is most popular 
                            // and effective format for quick PDF Viewing.
                            doc.Save(filePath, SDFDoc.SaveOptions.e_linearized);
                        }
                        else
                        {
                            doc.InitSecurityHandler();
                            if (nbrPages > 2)
                            {
                                PDFNet.Terminate();
                                Cursor = Cursors.Default;
                                return;
                            }

                            // Access a PDF page 1
                            Page page1 = doc.GetPage(1);

                            // Access a PDF page 2
                            Page page2 = doc.GetPage(2);

                            // Creat a copy from page 1 
                            doc.PagePushBack(page1);

                            // Access to a new PDF page 3
                            Page page3 = doc.GetPage(3);

                            // Start Convertion ...
                            // Convert String to Integer 
                            // ( add System to Class Convert to avoid a conflit between Convert of PDFTron )
                            int X1 = System.Convert.ToInt32(txtBoxX1.Text);
                            int X2 = System.Convert.ToInt32(txtBoxX2.Text);
                            int Y1 = System.Convert.ToInt32(txtBoxY1.Text);
                            int Y2 = System.Convert.ToInt32(txtBoxY2.Text);

                            int X11 = System.Convert.ToInt32(txtBoxX11.Text);
                            int X22 = System.Convert.ToInt32(txtBoxX22.Text);
                            int Y11 = System.Convert.ToInt32(txtBoxY11.Text);
                            int Y22 = System.Convert.ToInt32(txtBoxY22.Text);

                            // Crop the first, second and third page
                            page1.SetCropBox(new Rect(X1, Y1, X2, Y2));
                            page2.SetCropBox(new Rect(X1, Y1, X2, Y2));
                            page3.SetCropBox(new Rect(X11, Y11, X22, Y22));

                            // Save as a linearized file which is most popular 
                            // and effective format for quick PDF Viewing.
                            doc.Save(filePath, SDFDoc.SaveOptions.e_linearized);
                        }
                    }
                }
            }

            catch (pdftron.Common.PDFNetException)
            {
                // Message Exception
                MessageBox.Show("Please close the file and try agin", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PDFNet.Terminate();
                Cursor = Cursors.Default;
                return;
            }

            catch (Exception ex)
            {
                // Message Exception
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PDFNet.Terminate();
                Cursor = Cursors.Default;
                PDFfiles = null;
                txtBoxLoad.Text = "Chose your folder ...";
                txtTotales.Text = "...";
                return;
            }

            PDFNet.Terminate();
            Cursor = Cursors.Default;
            txtDone.Text = "Done";
            IMGDone.Visible = true;
            PDFfiles = null;
            txtBoxLoad.Text = "Chose your folder ...";
            txtTotales.Text = "...";
        }

        private void FrmMain_DragDrop(object sender, DragEventArgs e)
        {
            picArrowDown.Visible = false;
            IMGDone.Visible = false;
            string path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

            // Get Extension of dragged file 
            string ext = Path.GetExtension(path);

            // Condition >> Drag Folder
            if (Directory.Exists(path))
            {
                txtBoxLoad.Text = path;
                fileCount = SearchDirectoryTree(path, out PDFfiles);
                // Check the Empty Folder
                txtTotales.Text = fileCount == 0 ? "Your Folder is Empty" : fileCount + " files.";
            }

            // Condition >> Drage one PDF file
            else if (ext == ".pdf")
            {
                txtBoxLoad.Text = path;
                PDFfiles = new string[] { path };
                fileCount = 1;
                txtTotales.Text = fileCount + " files.";
            }
            else
                PDFfiles = null;
        }

        private void FrmMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            IMGDone.Visible = false;
            picArrowDown.Visible = true;
            txtBoxLoad.Text = "Chose your folder ...";
            txtDone.Text = "";
            txtTotales.Text = "...";
            txtAlert.Text = "";
            PDFfiles = null;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                ischecked = true;
                labelChangeText.Text = "Parametre of croping :";
                labelToStrikout.Font = new System.Drawing.Font(labelToStrikout.Font, FontStyle.Strikeout); ;

                // Disable all text box of croping parametre
                txtBoxX11.Enabled = false;
                txtBoxX22.Enabled = false;
                txtBoxY11.Enabled = false;
                txtBoxY22.Enabled = false;

                txtBoxX1.Text = "800";
            }
            else
            {
                ischecked = false;
                labelChangeText.Text = "Parametre of croping the first and second pages :";
                labelToStrikout.Font = new System.Drawing.Font(labelToStrikout.Font, FontStyle.Regular); ;

                // Enable all text box of croping parametre
                txtBoxX11.Enabled = true;
                txtBoxX22.Enabled = true;
                txtBoxY11.Enabled = true;
                txtBoxY22.Enabled = true;

                // Return default values
                txtBoxX1.Text = "590";
                txtBoxX2.Text = "1587";
                txtBoxY1.Text = "0";
                txtBoxY2.Text = "1096";
            }
        }

        private void FrmMain_DragLeave(object sender, EventArgs e) => picArrowDown.Visible = false;

        private void GoToGithub_Click(object sender, EventArgs e)
        {
            // Go to Github repository
            Process.Start("https://github.com/abdessalam-aadel/CropPDF");
        }

        // Start methode : Not Enter a Key String just a Key Number
        private static void Not_KeyString(KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                // if you press the BACKSPACE key, the Handled property is set to false, 
                e.Handled = e.KeyChar == 8 ? false : true;
            }
        }

        private void txtBoxX1_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);

        private void txtBoxX2_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);

        private void txtBoxY1_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);

        private void txtBoxY2_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);

        private void txtBoxX11_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);

        private void txtBoxX22_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);

        private void txtBoxY11_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);

        private void txtBoxY22_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);
    }
}
