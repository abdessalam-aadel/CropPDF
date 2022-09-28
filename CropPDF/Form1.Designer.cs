namespace CropPDF
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtBoxLoad = new System.Windows.Forms.TextBox();
            this.txtGit = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnStartCroping = new System.Windows.Forms.Button();
            this.labelTotales = new System.Windows.Forms.Label();
            this.txtTotales = new System.Windows.Forms.Label();
            this.txtDone = new System.Windows.Forms.Label();
            this.txtAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxLoad
            // 
            this.txtBoxLoad.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxLoad.Enabled = false;
            this.txtBoxLoad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxLoad.Location = new System.Drawing.Point(12, 21);
            this.txtBoxLoad.Multiline = true;
            this.txtBoxLoad.Name = "txtBoxLoad";
            this.txtBoxLoad.Size = new System.Drawing.Size(268, 23);
            this.txtBoxLoad.TabIndex = 100;
            this.txtBoxLoad.Text = "Chose your folder ...";
            // 
            // txtGit
            // 
            this.txtGit.AutoSize = true;
            this.txtGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtGit.Location = new System.Drawing.Point(165, 89);
            this.txtGit.Name = "txtGit";
            this.txtGit.Size = new System.Drawing.Size(38, 13);
            this.txtGit.TabIndex = 1;
            this.txtGit.Text = "Github";
            this.txtGit.Click += new System.EventHandler(this.txtGit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLoad.Location = new System.Drawing.Point(286, 21);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load ...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnStartCroping
            // 
            this.btnStartCroping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartCroping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCroping.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStartCroping.Location = new System.Drawing.Point(12, 50);
            this.btnStartCroping.Name = "btnStartCroping";
            this.btnStartCroping.Size = new System.Drawing.Size(349, 23);
            this.btnStartCroping.TabIndex = 3;
            this.btnStartCroping.Text = "Start Croping";
            this.btnStartCroping.UseVisualStyleBackColor = true;
            this.btnStartCroping.Click += new System.EventHandler(this.btnStartCroping_Click);
            // 
            // labelTotales
            // 
            this.labelTotales.AutoSize = true;
            this.labelTotales.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelTotales.Location = new System.Drawing.Point(143, 76);
            this.labelTotales.Name = "labelTotales";
            this.labelTotales.Size = new System.Drawing.Size(72, 13);
            this.labelTotales.TabIndex = 4;
            this.labelTotales.Text = "Totales Files :";
            // 
            // txtTotales
            // 
            this.txtTotales.AutoSize = true;
            this.txtTotales.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtTotales.Location = new System.Drawing.Point(211, 76);
            this.txtTotales.Name = "txtTotales";
            this.txtTotales.Size = new System.Drawing.Size(16, 13);
            this.txtTotales.TabIndex = 5;
            this.txtTotales.Text = "...";
            // 
            // txtDone
            // 
            this.txtDone.AutoSize = true;
            this.txtDone.ForeColor = System.Drawing.Color.DarkRed;
            this.txtDone.Location = new System.Drawing.Point(327, 76);
            this.txtDone.Name = "txtDone";
            this.txtDone.Size = new System.Drawing.Size(0, 13);
            this.txtDone.TabIndex = 6;
            // 
            // txtAlert
            // 
            this.txtAlert.AutoSize = true;
            this.txtAlert.ForeColor = System.Drawing.Color.DarkRed;
            this.txtAlert.Location = new System.Drawing.Point(91, 5);
            this.txtAlert.Name = "txtAlert";
            this.txtAlert.Size = new System.Drawing.Size(0, 13);
            this.txtAlert.TabIndex = 101;
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 106);
            this.Controls.Add(this.txtAlert);
            this.Controls.Add(this.txtDone);
            this.Controls.Add(this.txtTotales);
            this.Controls.Add(this.labelTotales);
            this.Controls.Add(this.btnStartCroping);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtGit);
            this.Controls.Add(this.txtBoxLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crop Multiple PDF Files";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxLoad;
        private System.Windows.Forms.Label txtGit;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnStartCroping;
        private System.Windows.Forms.Label labelTotales;
        private System.Windows.Forms.Label txtTotales;
        private System.Windows.Forms.Label txtDone;
        private System.Windows.Forms.Label txtAlert;
    }
}

