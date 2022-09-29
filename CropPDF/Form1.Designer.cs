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
            this.txtBoxX1 = new System.Windows.Forms.TextBox();
            this.txtBoxX2 = new System.Windows.Forms.TextBox();
            this.txtBoxY1 = new System.Windows.Forms.TextBox();
            this.txtBoxY2 = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxY22 = new System.Windows.Forms.TextBox();
            this.txtBoxY11 = new System.Windows.Forms.TextBox();
            this.txtBoxX22 = new System.Windows.Forms.TextBox();
            this.txtBoxX11 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxLoad
            // 
            this.txtBoxLoad.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxLoad.Enabled = false;
            this.txtBoxLoad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxLoad.Location = new System.Drawing.Point(12, 15);
            this.txtBoxLoad.Name = "txtBoxLoad";
            this.txtBoxLoad.Size = new System.Drawing.Size(268, 20);
            this.txtBoxLoad.TabIndex = 100;
            this.txtBoxLoad.Text = "Chose your folder ...";
            // 
            // txtGit
            // 
            this.txtGit.AutoSize = true;
            this.txtGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtGit.Location = new System.Drawing.Point(164, 164);
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
            this.btnLoad.Location = new System.Drawing.Point(286, 15);
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
            this.btnStartCroping.Location = new System.Drawing.Point(12, 44);
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
            this.labelTotales.Location = new System.Drawing.Point(142, 151);
            this.labelTotales.Name = "labelTotales";
            this.labelTotales.Size = new System.Drawing.Size(72, 13);
            this.labelTotales.TabIndex = 4;
            this.labelTotales.Text = "Totales Files :";
            // 
            // txtTotales
            // 
            this.txtTotales.AutoSize = true;
            this.txtTotales.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtTotales.Location = new System.Drawing.Point(210, 151);
            this.txtTotales.Name = "txtTotales";
            this.txtTotales.Size = new System.Drawing.Size(16, 13);
            this.txtTotales.TabIndex = 5;
            this.txtTotales.Text = "...";
            // 
            // txtDone
            // 
            this.txtDone.AutoSize = true;
            this.txtDone.ForeColor = System.Drawing.Color.DarkRed;
            this.txtDone.Location = new System.Drawing.Point(327, 151);
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
            // txtBoxX1
            // 
            this.txtBoxX1.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtBoxX1.Location = new System.Drawing.Point(37, 88);
            this.txtBoxX1.Name = "txtBoxX1";
            this.txtBoxX1.Size = new System.Drawing.Size(38, 20);
            this.txtBoxX1.TabIndex = 102;
            this.txtBoxX1.Text = "565";
            // 
            // txtBoxX2
            // 
            this.txtBoxX2.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtBoxX2.Location = new System.Drawing.Point(105, 88);
            this.txtBoxX2.Name = "txtBoxX2";
            this.txtBoxX2.Size = new System.Drawing.Size(38, 20);
            this.txtBoxX2.TabIndex = 103;
            this.txtBoxX2.Text = "1587";
            // 
            // txtBoxY1
            // 
            this.txtBoxY1.ForeColor = System.Drawing.Color.Black;
            this.txtBoxY1.Location = new System.Drawing.Point(254, 88);
            this.txtBoxY1.Name = "txtBoxY1";
            this.txtBoxY1.Size = new System.Drawing.Size(38, 20);
            this.txtBoxY1.TabIndex = 104;
            this.txtBoxY1.Text = "0";
            // 
            // txtBoxY2
            // 
            this.txtBoxY2.ForeColor = System.Drawing.Color.Black;
            this.txtBoxY2.Location = new System.Drawing.Point(322, 88);
            this.txtBoxY2.Name = "txtBoxY2";
            this.txtBoxY2.Size = new System.Drawing.Size(38, 20);
            this.txtBoxY2.TabIndex = 105;
            this.txtBoxY2.Text = "1096";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelX1.Location = new System.Drawing.Point(9, 91);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(26, 13);
            this.labelX1.TabIndex = 106;
            this.labelX1.Text = "X1 :";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelX2.Location = new System.Drawing.Point(77, 91);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(26, 13);
            this.labelX2.TabIndex = 108;
            this.labelX2.Text = "X2 :";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.ForeColor = System.Drawing.Color.Black;
            this.labelY2.Location = new System.Drawing.Point(296, 91);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(26, 13);
            this.labelY2.TabIndex = 110;
            this.labelY2.Text = "Y2 :";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.ForeColor = System.Drawing.Color.Black;
            this.labelY1.Location = new System.Drawing.Point(228, 91);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(26, 13);
            this.labelY1.TabIndex = 109;
            this.labelY1.Text = "Y1 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(296, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "Y2 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(228, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 117;
            this.label2.Text = "Y1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(77, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "X2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(9, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "X1 :";
            // 
            // txtBoxY22
            // 
            this.txtBoxY22.ForeColor = System.Drawing.Color.Black;
            this.txtBoxY22.Location = new System.Drawing.Point(322, 126);
            this.txtBoxY22.Name = "txtBoxY22";
            this.txtBoxY22.Size = new System.Drawing.Size(38, 20);
            this.txtBoxY22.TabIndex = 114;
            this.txtBoxY22.Text = "1096";
            // 
            // txtBoxY11
            // 
            this.txtBoxY11.ForeColor = System.Drawing.Color.Black;
            this.txtBoxY11.Location = new System.Drawing.Point(254, 126);
            this.txtBoxY11.Name = "txtBoxY11";
            this.txtBoxY11.Size = new System.Drawing.Size(38, 20);
            this.txtBoxY11.TabIndex = 113;
            this.txtBoxY11.Text = "0";
            // 
            // txtBoxX22
            // 
            this.txtBoxX22.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtBoxX22.Location = new System.Drawing.Point(105, 126);
            this.txtBoxX22.Name = "txtBoxX22";
            this.txtBoxX22.Size = new System.Drawing.Size(38, 20);
            this.txtBoxX22.TabIndex = 112;
            this.txtBoxX22.Text = "575";
            // 
            // txtBoxX11
            // 
            this.txtBoxX11.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtBoxX11.Location = new System.Drawing.Point(37, 126);
            this.txtBoxX11.Name = "txtBoxX11";
            this.txtBoxX11.Size = new System.Drawing.Size(38, 20);
            this.txtBoxX11.TabIndex = 111;
            this.txtBoxX11.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(9, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 13);
            this.label5.TabIndex = 119;
            this.label5.Text = "Parametre of croping the first and second pages :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(9, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 120;
            this.label6.Text = "Parametre of croping the third page :";
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 180);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxY22);
            this.Controls.Add(this.txtBoxY11);
            this.Controls.Add(this.txtBoxX22);
            this.Controls.Add(this.txtBoxX11);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtBoxY2);
            this.Controls.Add(this.txtBoxY1);
            this.Controls.Add(this.txtBoxX2);
            this.Controls.Add(this.txtBoxX1);
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
        private System.Windows.Forms.TextBox txtBoxX1;
        private System.Windows.Forms.TextBox txtBoxX2;
        private System.Windows.Forms.TextBox txtBoxY1;
        private System.Windows.Forms.TextBox txtBoxY2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxY22;
        private System.Windows.Forms.TextBox txtBoxY11;
        private System.Windows.Forms.TextBox txtBoxX22;
        private System.Windows.Forms.TextBox txtBoxX11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

