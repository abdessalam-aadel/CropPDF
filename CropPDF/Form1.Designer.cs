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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtBoxLoad = new System.Windows.Forms.TextBox();
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
            this.labelChangeText = new System.Windows.Forms.Label();
            this.labelToStrikout = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.picArrowDown = new System.Windows.Forms.PictureBox();
            this.GoToGithub = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.IMGDone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGDone)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxLoad
            // 
            this.txtBoxLoad.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLoad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxLoad.Location = new System.Drawing.Point(12, 14);
            this.txtBoxLoad.Name = "txtBoxLoad";
            this.txtBoxLoad.ReadOnly = true;
            this.txtBoxLoad.Size = new System.Drawing.Size(268, 20);
            this.txtBoxLoad.TabIndex = 100;
            this.txtBoxLoad.Text = "Chose your folder ...";
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLoad.Location = new System.Drawing.Point(286, 14);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 20);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load ...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnStartCroping
            // 
            this.btnStartCroping.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartCroping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartCroping.FlatAppearance.BorderSize = 2;
            this.btnStartCroping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCroping.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCroping.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnStartCroping.Location = new System.Drawing.Point(12, 40);
            this.btnStartCroping.Name = "btnStartCroping";
            this.btnStartCroping.Size = new System.Drawing.Size(349, 36);
            this.btnStartCroping.TabIndex = 3;
            this.btnStartCroping.Text = "Start Croping";
            this.btnStartCroping.UseVisualStyleBackColor = false;
            this.btnStartCroping.Click += new System.EventHandler(this.btnStartCroping_Click);
            // 
            // labelTotales
            // 
            this.labelTotales.AutoSize = true;
            this.labelTotales.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelTotales.Location = new System.Drawing.Point(136, 191);
            this.labelTotales.Name = "labelTotales";
            this.labelTotales.Size = new System.Drawing.Size(72, 13);
            this.labelTotales.TabIndex = 4;
            this.labelTotales.Text = "Totales Files :";
            // 
            // txtTotales
            // 
            this.txtTotales.AutoSize = true;
            this.txtTotales.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtTotales.Location = new System.Drawing.Point(204, 191);
            this.txtTotales.Name = "txtTotales";
            this.txtTotales.Size = new System.Drawing.Size(16, 13);
            this.txtTotales.TabIndex = 5;
            this.txtTotales.Text = "...";
            // 
            // txtDone
            // 
            this.txtDone.AutoSize = true;
            this.txtDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDone.ForeColor = System.Drawing.Color.DarkRed;
            this.txtDone.Location = new System.Drawing.Point(308, 190);
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
            this.txtBoxX1.Location = new System.Drawing.Point(37, 121);
            this.txtBoxX1.Name = "txtBoxX1";
            this.txtBoxX1.ShortcutsEnabled = false;
            this.txtBoxX1.Size = new System.Drawing.Size(38, 20);
            this.txtBoxX1.TabIndex = 102;
            this.txtBoxX1.Text = "590";
            this.txtBoxX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxX1_KeyPress);
            // 
            // txtBoxX2
            // 
            this.txtBoxX2.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtBoxX2.Location = new System.Drawing.Point(105, 121);
            this.txtBoxX2.Name = "txtBoxX2";
            this.txtBoxX2.ShortcutsEnabled = false;
            this.txtBoxX2.Size = new System.Drawing.Size(38, 20);
            this.txtBoxX2.TabIndex = 103;
            this.txtBoxX2.Text = "1587";
            this.txtBoxX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxX2_KeyPress);
            // 
            // txtBoxY1
            // 
            this.txtBoxY1.ForeColor = System.Drawing.Color.Black;
            this.txtBoxY1.Location = new System.Drawing.Point(254, 121);
            this.txtBoxY1.Name = "txtBoxY1";
            this.txtBoxY1.ShortcutsEnabled = false;
            this.txtBoxY1.Size = new System.Drawing.Size(38, 20);
            this.txtBoxY1.TabIndex = 104;
            this.txtBoxY1.Text = "0";
            this.txtBoxY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxY1_KeyPress);
            // 
            // txtBoxY2
            // 
            this.txtBoxY2.ForeColor = System.Drawing.Color.Black;
            this.txtBoxY2.Location = new System.Drawing.Point(322, 121);
            this.txtBoxY2.Name = "txtBoxY2";
            this.txtBoxY2.ShortcutsEnabled = false;
            this.txtBoxY2.Size = new System.Drawing.Size(38, 20);
            this.txtBoxY2.TabIndex = 105;
            this.txtBoxY2.Text = "1096";
            this.txtBoxY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxY2_KeyPress);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelX1.Location = new System.Drawing.Point(9, 124);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(26, 13);
            this.labelX1.TabIndex = 106;
            this.labelX1.Text = "X1 :";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelX2.Location = new System.Drawing.Point(77, 124);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(26, 13);
            this.labelX2.TabIndex = 108;
            this.labelX2.Text = "X2 :";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.ForeColor = System.Drawing.Color.Black;
            this.labelY2.Location = new System.Drawing.Point(296, 124);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(26, 13);
            this.labelY2.TabIndex = 110;
            this.labelY2.Text = "Y2 :";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.ForeColor = System.Drawing.Color.Black;
            this.labelY1.Location = new System.Drawing.Point(228, 124);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(26, 13);
            this.labelY1.TabIndex = 109;
            this.labelY1.Text = "Y1 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(296, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "Y2 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(228, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 117;
            this.label2.Text = "Y1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(77, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "X2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(9, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "X1 :";
            // 
            // txtBoxY22
            // 
            this.txtBoxY22.ForeColor = System.Drawing.Color.Black;
            this.txtBoxY22.Location = new System.Drawing.Point(322, 165);
            this.txtBoxY22.Name = "txtBoxY22";
            this.txtBoxY22.ShortcutsEnabled = false;
            this.txtBoxY22.Size = new System.Drawing.Size(38, 20);
            this.txtBoxY22.TabIndex = 114;
            this.txtBoxY22.Text = "1096";
            this.txtBoxY22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxY22_KeyPress);
            // 
            // txtBoxY11
            // 
            this.txtBoxY11.ForeColor = System.Drawing.Color.Black;
            this.txtBoxY11.Location = new System.Drawing.Point(254, 165);
            this.txtBoxY11.Name = "txtBoxY11";
            this.txtBoxY11.ShortcutsEnabled = false;
            this.txtBoxY11.Size = new System.Drawing.Size(38, 20);
            this.txtBoxY11.TabIndex = 113;
            this.txtBoxY11.Text = "0";
            this.txtBoxY11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxY11_KeyPress);
            // 
            // txtBoxX22
            // 
            this.txtBoxX22.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtBoxX22.Location = new System.Drawing.Point(105, 165);
            this.txtBoxX22.Name = "txtBoxX22";
            this.txtBoxX22.ShortcutsEnabled = false;
            this.txtBoxX22.Size = new System.Drawing.Size(38, 20);
            this.txtBoxX22.TabIndex = 112;
            this.txtBoxX22.Text = "595";
            this.txtBoxX22.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxX22_KeyPress);
            // 
            // txtBoxX11
            // 
            this.txtBoxX11.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtBoxX11.Location = new System.Drawing.Point(37, 165);
            this.txtBoxX11.Name = "txtBoxX11";
            this.txtBoxX11.ShortcutsEnabled = false;
            this.txtBoxX11.Size = new System.Drawing.Size(38, 20);
            this.txtBoxX11.TabIndex = 111;
            this.txtBoxX11.Text = "0";
            this.txtBoxX11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxX11_KeyPress);
            // 
            // labelChangeText
            // 
            this.labelChangeText.AutoSize = true;
            this.labelChangeText.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelChangeText.Location = new System.Drawing.Point(9, 105);
            this.labelChangeText.Name = "labelChangeText";
            this.labelChangeText.Size = new System.Drawing.Size(239, 13);
            this.labelChangeText.TabIndex = 119;
            this.labelChangeText.Text = "Parametre of croping the first and second pages :";
            // 
            // labelToStrikout
            // 
            this.labelToStrikout.AutoSize = true;
            this.labelToStrikout.BackColor = System.Drawing.Color.Transparent;
            this.labelToStrikout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToStrikout.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelToStrikout.Location = new System.Drawing.Point(9, 150);
            this.labelToStrikout.Name = "labelToStrikout";
            this.labelToStrikout.Size = new System.Drawing.Size(179, 13);
            this.labelToStrikout.TabIndex = 120;
            this.labelToStrikout.Text = "Parametre of croping the third page :";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox.ForeColor = System.Drawing.Color.Maroon;
            this.checkBox.Location = new System.Drawing.Point(12, 83);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(181, 17);
            this.checkBox.TabIndex = 121;
            this.checkBox.Text = "Crop Yellow and Green paper file.";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // picArrowDown
            // 
            this.picArrowDown.BackColor = System.Drawing.Color.Transparent;
            this.picArrowDown.Image = global::CropPDF.Properties.Resources.Arrows_down_animated;
            this.picArrowDown.Location = new System.Drawing.Point(169, 117);
            this.picArrowDown.Name = "picArrowDown";
            this.picArrowDown.Size = new System.Drawing.Size(35, 31);
            this.picArrowDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArrowDown.TabIndex = 122;
            this.picArrowDown.TabStop = false;
            this.picArrowDown.Visible = false;
            // 
            // GoToGithub
            // 
            this.GoToGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToGithub.Image = ((System.Drawing.Image)(resources.GetObject("GoToGithub.Image")));
            this.GoToGithub.Location = new System.Drawing.Point(12, 187);
            this.GoToGithub.Name = "GoToGithub";
            this.GoToGithub.Size = new System.Drawing.Size(17, 16);
            this.GoToGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoToGithub.TabIndex = 123;
            this.GoToGithub.TabStop = false;
            this.toolTip1.SetToolTip(this.GoToGithub, "Go to Github.");
            this.GoToGithub.Click += new System.EventHandler(this.GoToGithub_Click);
            // 
            // IMGDone
            // 
            this.IMGDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IMGDone.Image = ((System.Drawing.Image)(resources.GetObject("IMGDone.Image")));
            this.IMGDone.Location = new System.Drawing.Point(344, 188);
            this.IMGDone.Name = "IMGDone";
            this.IMGDone.Size = new System.Drawing.Size(17, 16);
            this.IMGDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMGDone.TabIndex = 124;
            this.IMGDone.TabStop = false;
            this.toolTip1.SetToolTip(this.IMGDone, "Go to Github.");
            this.IMGDone.Visible = false;
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 209);
            this.Controls.Add(this.IMGDone);
            this.Controls.Add(this.GoToGithub);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.labelToStrikout);
            this.Controls.Add(this.labelChangeText);
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
            this.Controls.Add(this.txtBoxLoad);
            this.Controls.Add(this.picArrowDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crop Multiple PDF Files";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmMain_DragEnter);
            this.DragLeave += new System.EventHandler(this.FrmMain_DragLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picArrowDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoToGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGDone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxLoad;
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
        private System.Windows.Forms.Label labelChangeText;
        private System.Windows.Forms.Label labelToStrikout;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.PictureBox picArrowDown;
        private System.Windows.Forms.PictureBox GoToGithub;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox IMGDone;
    }
}

