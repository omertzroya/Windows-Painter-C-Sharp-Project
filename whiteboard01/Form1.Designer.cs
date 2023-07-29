
namespace whiteboard01
{
    partial class Form1
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
            this.buttonAddNewSlide = new System.Windows.Forms.Button();
            this.buttonShowPreviousSlide = new System.Windows.Forms.Button();
            this.buttonShowNextSlide = new System.Windows.Forms.Button();
            this.buttonShowLastSlide = new System.Windows.Forms.Button();
            this.buttonShowFirstSlide = new System.Windows.Forms.Button();
            this.textBoxSlideNumber = new System.Windows.Forms.TextBox();
            this.buttonDeleteSlide = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelWidths = new System.Windows.Forms.Panel();
            this.panelWidth4 = new System.Windows.Forms.Panel();
            this.panelWidth3 = new System.Windows.Forms.Panel();
            this.panelWidth2 = new System.Windows.Forms.Panel();
            this.panelWidth1 = new System.Windows.Forms.Panel();
            this.panelColors = new System.Windows.Forms.Panel();
            this.buttonColorWhite = new System.Windows.Forms.Button();
            this.buttonColorGreen = new System.Windows.Forms.Button();
            this.buttonColorYellow = new System.Windows.Forms.Button();
            this.buttonColorBlue = new System.Windows.Forms.Button();
            this.buttonColorRed = new System.Windows.Forms.Button();
            this.radioButtonFreeHand = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.panelSelectedColor = new System.Windows.Forms.Panel();
            this.radioButtonNonFillRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonFillRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonNonFillElipce = new System.Windows.Forms.RadioButton();
            this.radioButtonFillElipce = new System.Windows.Forms.RadioButton();
            this.radioButtonEraser = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButtonSelector = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelWidths.SuspendLayout();
            this.panelColors.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddNewSlide
            // 
            this.buttonAddNewSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddNewSlide.Location = new System.Drawing.Point(1154, 602);
            this.buttonAddNewSlide.Name = "buttonAddNewSlide";
            this.buttonAddNewSlide.Size = new System.Drawing.Size(40, 23);
            this.buttonAddNewSlide.TabIndex = 0;
            this.buttonAddNewSlide.Text = "+";
            this.buttonAddNewSlide.UseVisualStyleBackColor = true;
            this.buttonAddNewSlide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAddNewSlide_MouseClick);
            // 
            // buttonShowPreviousSlide
            // 
            this.buttonShowPreviousSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowPreviousSlide.Location = new System.Drawing.Point(910, 603);
            this.buttonShowPreviousSlide.Name = "buttonShowPreviousSlide";
            this.buttonShowPreviousSlide.Size = new System.Drawing.Size(40, 23);
            this.buttonShowPreviousSlide.TabIndex = 1;
            this.buttonShowPreviousSlide.Text = "<";
            this.buttonShowPreviousSlide.UseVisualStyleBackColor = true;
            this.buttonShowPreviousSlide.Click += new System.EventHandler(this.buttonShoePreviousSlide_Click);
            // 
            // buttonShowNextSlide
            // 
            this.buttonShowNextSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowNextSlide.Enabled = false;
            this.buttonShowNextSlide.Location = new System.Drawing.Point(1062, 602);
            this.buttonShowNextSlide.Name = "buttonShowNextSlide";
            this.buttonShowNextSlide.Size = new System.Drawing.Size(40, 23);
            this.buttonShowNextSlide.TabIndex = 2;
            this.buttonShowNextSlide.Text = ">";
            this.buttonShowNextSlide.UseVisualStyleBackColor = true;
            this.buttonShowNextSlide.Click += new System.EventHandler(this.buttonShowNextSlide_Click);
            // 
            // buttonShowLastSlide
            // 
            this.buttonShowLastSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowLastSlide.Location = new System.Drawing.Point(1108, 602);
            this.buttonShowLastSlide.Name = "buttonShowLastSlide";
            this.buttonShowLastSlide.Size = new System.Drawing.Size(40, 23);
            this.buttonShowLastSlide.TabIndex = 3;
            this.buttonShowLastSlide.Text = "> |";
            this.buttonShowLastSlide.UseVisualStyleBackColor = true;
            this.buttonShowLastSlide.Click += new System.EventHandler(this.buttonShowLastSlide_Click);
            // 
            // buttonShowFirstSlide
            // 
            this.buttonShowFirstSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowFirstSlide.Location = new System.Drawing.Point(864, 603);
            this.buttonShowFirstSlide.Name = "buttonShowFirstSlide";
            this.buttonShowFirstSlide.Size = new System.Drawing.Size(40, 23);
            this.buttonShowFirstSlide.TabIndex = 4;
            this.buttonShowFirstSlide.Text = "| <";
            this.buttonShowFirstSlide.UseVisualStyleBackColor = true;
            this.buttonShowFirstSlide.Click += new System.EventHandler(this.buttonShowFirstSlide_Click);
            // 
            // textBoxSlideNumber
            // 
            this.textBoxSlideNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSlideNumber.Location = new System.Drawing.Point(956, 603);
            this.textBoxSlideNumber.Name = "textBoxSlideNumber";
            this.textBoxSlideNumber.ReadOnly = true;
            this.textBoxSlideNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxSlideNumber.TabIndex = 5;
            this.textBoxSlideNumber.Text = "0";
            // 
            // buttonDeleteSlide
            // 
            this.buttonDeleteSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteSlide.Location = new System.Drawing.Point(818, 603);
            this.buttonDeleteSlide.Name = "buttonDeleteSlide";
            this.buttonDeleteSlide.Size = new System.Drawing.Size(40, 23);
            this.buttonDeleteSlide.TabIndex = 6;
            this.buttonDeleteSlide.Text = "--";
            this.buttonDeleteSlide.UseVisualStyleBackColor = true;
            this.buttonDeleteSlide.Click += new System.EventHandler(this.buttonDeleteSlide_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(215, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 561);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panelWidths
            // 
            this.panelWidths.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelWidths.Controls.Add(this.panelWidth4);
            this.panelWidths.Controls.Add(this.panelWidth3);
            this.panelWidths.Controls.Add(this.panelWidth2);
            this.panelWidths.Controls.Add(this.panelWidth1);
            this.panelWidths.Location = new System.Drawing.Point(126, 312);
            this.panelWidths.Name = "panelWidths";
            this.panelWidths.Size = new System.Drawing.Size(70, 124);
            this.panelWidths.TabIndex = 8;
            this.panelWidths.Tag = "0";
            // 
            // panelWidth4
            // 
            this.panelWidth4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWidth4.Location = new System.Drawing.Point(0, 90);
            this.panelWidth4.Name = "panelWidth4";
            this.panelWidth4.Size = new System.Drawing.Size(66, 30);
            this.panelWidth4.TabIndex = 3;
            this.panelWidth4.Tag = "4";
            this.panelWidth4.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWidth4_Paint);
            this.panelWidth4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWidth4_MouseDown);
            // 
            // panelWidth3
            // 
            this.panelWidth3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWidth3.Location = new System.Drawing.Point(0, 60);
            this.panelWidth3.Name = "panelWidth3";
            this.panelWidth3.Size = new System.Drawing.Size(66, 30);
            this.panelWidth3.TabIndex = 2;
            this.panelWidth3.Tag = "3";
            this.panelWidth3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWidth3_Paint);
            this.panelWidth3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWidth3_MouseDown);
            // 
            // panelWidth2
            // 
            this.panelWidth2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWidth2.Location = new System.Drawing.Point(0, 30);
            this.panelWidth2.Name = "panelWidth2";
            this.panelWidth2.Size = new System.Drawing.Size(66, 30);
            this.panelWidth2.TabIndex = 1;
            this.panelWidth2.Tag = "2";
            this.panelWidth2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWidth2_Paint);
            this.panelWidth2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWidth2_MouseDown);
            // 
            // panelWidth1
            // 
            this.panelWidth1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWidth1.Location = new System.Drawing.Point(0, 0);
            this.panelWidth1.Name = "panelWidth1";
            this.panelWidth1.Size = new System.Drawing.Size(66, 30);
            this.panelWidth1.TabIndex = 0;
            this.panelWidth1.Tag = "1";
            this.panelWidth1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWidth1_Paint);
            this.panelWidth1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelWidth1_MouseDown);
            // 
            // panelColors
            // 
            this.panelColors.Controls.Add(this.buttonColorWhite);
            this.panelColors.Controls.Add(this.buttonColorGreen);
            this.panelColors.Controls.Add(this.buttonColorYellow);
            this.panelColors.Controls.Add(this.buttonColorBlue);
            this.panelColors.Controls.Add(this.buttonColorRed);
            this.panelColors.Location = new System.Drawing.Point(14, 312);
            this.panelColors.Name = "panelColors";
            this.panelColors.Size = new System.Drawing.Size(70, 123);
            this.panelColors.TabIndex = 9;
            // 
            // buttonColorWhite
            // 
            this.buttonColorWhite.BackColor = System.Drawing.Color.Black;
            this.buttonColorWhite.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonColorWhite.Location = new System.Drawing.Point(0, 92);
            this.buttonColorWhite.Name = "buttonColorWhite";
            this.buttonColorWhite.Size = new System.Drawing.Size(70, 28);
            this.buttonColorWhite.TabIndex = 4;
            this.buttonColorWhite.UseVisualStyleBackColor = false;
            this.buttonColorWhite.Click += new System.EventHandler(this.buttonColorWhite_Click);
            // 
            // buttonColorGreen
            // 
            this.buttonColorGreen.BackColor = System.Drawing.Color.Green;
            this.buttonColorGreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonColorGreen.Location = new System.Drawing.Point(0, 69);
            this.buttonColorGreen.Name = "buttonColorGreen";
            this.buttonColorGreen.Size = new System.Drawing.Size(70, 23);
            this.buttonColorGreen.TabIndex = 3;
            this.buttonColorGreen.UseVisualStyleBackColor = false;
            this.buttonColorGreen.Click += new System.EventHandler(this.buttonColorGreen_Click);
            // 
            // buttonColorYellow
            // 
            this.buttonColorYellow.BackColor = System.Drawing.Color.White;
            this.buttonColorYellow.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonColorYellow.Location = new System.Drawing.Point(0, 46);
            this.buttonColorYellow.Name = "buttonColorYellow";
            this.buttonColorYellow.Size = new System.Drawing.Size(70, 23);
            this.buttonColorYellow.TabIndex = 2;
            this.buttonColorYellow.Text = "Eraser";
            this.buttonColorYellow.UseVisualStyleBackColor = false;
            this.buttonColorYellow.Click += new System.EventHandler(this.buttonColorYellow_Click);
            // 
            // buttonColorBlue
            // 
            this.buttonColorBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonColorBlue.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonColorBlue.Location = new System.Drawing.Point(0, 23);
            this.buttonColorBlue.Name = "buttonColorBlue";
            this.buttonColorBlue.Size = new System.Drawing.Size(70, 23);
            this.buttonColorBlue.TabIndex = 1;
            this.buttonColorBlue.UseVisualStyleBackColor = false;
            this.buttonColorBlue.Click += new System.EventHandler(this.buttonColorBlue_Click);
            // 
            // buttonColorRed
            // 
            this.buttonColorRed.BackColor = System.Drawing.Color.Red;
            this.buttonColorRed.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonColorRed.Location = new System.Drawing.Point(0, 0);
            this.buttonColorRed.Name = "buttonColorRed";
            this.buttonColorRed.Size = new System.Drawing.Size(70, 23);
            this.buttonColorRed.TabIndex = 0;
            this.buttonColorRed.UseVisualStyleBackColor = false;
            this.buttonColorRed.Click += new System.EventHandler(this.buttonColorRed_Click);
            // 
            // radioButtonFreeHand
            // 
            this.radioButtonFreeHand.AutoSize = true;
            this.radioButtonFreeHand.Checked = true;
            this.radioButtonFreeHand.Location = new System.Drawing.Point(70, 35);
            this.radioButtonFreeHand.Name = "radioButtonFreeHand";
            this.radioButtonFreeHand.Size = new System.Drawing.Size(72, 17);
            this.radioButtonFreeHand.TabIndex = 10;
            this.radioButtonFreeHand.TabStop = true;
            this.radioButtonFreeHand.Text = "FreeHand";
            this.radioButtonFreeHand.UseVisualStyleBackColor = true;
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(6, 35);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(45, 17);
            this.radioButtonLine.TabIndex = 11;
            this.radioButtonLine.Text = "Line";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            // 
            // panelSelectedColor
            // 
            this.panelSelectedColor.BackColor = System.Drawing.Color.Black;
            this.panelSelectedColor.Location = new System.Drawing.Point(63, 232);
            this.panelSelectedColor.Name = "panelSelectedColor";
            this.panelSelectedColor.Size = new System.Drawing.Size(70, 39);
            this.panelSelectedColor.TabIndex = 12;
            this.panelSelectedColor.BackColorChanged += new System.EventHandler(this.panelSelectedColor_BackColorChanged);
            // 
            // radioButtonNonFillRectangle
            // 
            this.radioButtonNonFillRectangle.AutoSize = true;
            this.radioButtonNonFillRectangle.Location = new System.Drawing.Point(6, 58);
            this.radioButtonNonFillRectangle.Name = "radioButtonNonFillRectangle";
            this.radioButtonNonFillRectangle.Size = new System.Drawing.Size(118, 17);
            this.radioButtonNonFillRectangle.TabIndex = 13;
            this.radioButtonNonFillRectangle.Text = "None Fill Rectangle";
            this.radioButtonNonFillRectangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonFillRectangle
            // 
            this.radioButtonFillRectangle.AutoSize = true;
            this.radioButtonFillRectangle.Location = new System.Drawing.Point(6, 81);
            this.radioButtonFillRectangle.Name = "radioButtonFillRectangle";
            this.radioButtonFillRectangle.Size = new System.Drawing.Size(89, 17);
            this.radioButtonFillRectangle.TabIndex = 14;
            this.radioButtonFillRectangle.Text = "Fill Rectangle";
            this.radioButtonFillRectangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonNonFillElipce
            // 
            this.radioButtonNonFillElipce.AutoSize = true;
            this.radioButtonNonFillElipce.Location = new System.Drawing.Point(6, 104);
            this.radioButtonNonFillElipce.Name = "radioButtonNonFillElipce";
            this.radioButtonNonFillElipce.Size = new System.Drawing.Size(99, 17);
            this.radioButtonNonFillElipce.TabIndex = 15;
            this.radioButtonNonFillElipce.Text = "None Fill Ellipse";
            this.radioButtonNonFillElipce.UseVisualStyleBackColor = true;
            // 
            // radioButtonFillElipce
            // 
            this.radioButtonFillElipce.AutoSize = true;
            this.radioButtonFillElipce.Location = new System.Drawing.Point(6, 127);
            this.radioButtonFillElipce.Name = "radioButtonFillElipce";
            this.radioButtonFillElipce.Size = new System.Drawing.Size(70, 17);
            this.radioButtonFillElipce.TabIndex = 16;
            this.radioButtonFillElipce.Text = "Fill Ellipse";
            this.radioButtonFillElipce.UseVisualStyleBackColor = true;
            // 
            // radioButtonEraser
            // 
            this.radioButtonEraser.AutoSize = true;
            this.radioButtonEraser.Location = new System.Drawing.Point(6, 176);
            this.radioButtonEraser.Name = "radioButtonEraser";
            this.radioButtonEraser.Size = new System.Drawing.Size(199, 17);
            this.radioButtonEraser.TabIndex = 18;
            this.radioButtonEraser.Text = "Remove Object (Rectangle or Eliipse";
            this.radioButtonEraser.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Colors :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(79, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "Current Color :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 288);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(68, 20);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "Width :";
            // 
            // radioButtonSelector
            // 
            this.radioButtonSelector.AutoSize = true;
            this.radioButtonSelector.Location = new System.Drawing.Point(6, 153);
            this.radioButtonSelector.Name = "radioButtonSelector";
            this.radioButtonSelector.Size = new System.Drawing.Size(182, 17);
            this.radioButtonSelector.TabIndex = 17;
            this.radioButtonSelector.Text = "Change Color Select Rec or Ellip ";
            this.radioButtonSelector.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "File";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem1,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem1.Text = "Save As";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 637);
            this.Controls.Add(this.radioButtonSelector);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonEraser);
            this.Controls.Add(this.radioButtonFillElipce);
            this.Controls.Add(this.radioButtonNonFillElipce);
            this.Controls.Add(this.radioButtonFillRectangle);
            this.Controls.Add(this.radioButtonNonFillRectangle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSelectedColor);
            this.Controls.Add(this.radioButtonLine);
            this.Controls.Add(this.radioButtonFreeHand);
            this.Controls.Add(this.panelColors);
            this.Controls.Add(this.panelWidths);
            this.Controls.Add(this.buttonDeleteSlide);
            this.Controls.Add(this.textBoxSlideNumber);
            this.Controls.Add(this.buttonShowFirstSlide);
            this.Controls.Add(this.buttonShowLastSlide);
            this.Controls.Add(this.buttonShowNextSlide);
            this.Controls.Add(this.buttonShowPreviousSlide);
            this.Controls.Add(this.buttonAddNewSlide);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelWidths.ResumeLayout(false);
            this.panelColors.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewSlide;
        private System.Windows.Forms.Button buttonShowPreviousSlide;
        private System.Windows.Forms.Button buttonShowNextSlide;
        private System.Windows.Forms.Button buttonShowLastSlide;
        private System.Windows.Forms.Button buttonShowFirstSlide;
        private System.Windows.Forms.TextBox textBoxSlideNumber;
        private System.Windows.Forms.Button buttonDeleteSlide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelWidths;
        private System.Windows.Forms.Panel panelWidth4;
        private System.Windows.Forms.Panel panelWidth3;
        private System.Windows.Forms.Panel panelWidth2;
        private System.Windows.Forms.Panel panelWidth1;
        private System.Windows.Forms.Panel panelColors;
        private System.Windows.Forms.Button buttonColorWhite;
        private System.Windows.Forms.Button buttonColorGreen;
        private System.Windows.Forms.Button buttonColorYellow;
        private System.Windows.Forms.Button buttonColorBlue;
        private System.Windows.Forms.Button buttonColorRed;
        private System.Windows.Forms.RadioButton radioButtonFreeHand;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.Panel panelSelectedColor;
        private System.Windows.Forms.RadioButton radioButtonNonFillRectangle;
        private System.Windows.Forms.RadioButton radioButtonFillRectangle;
        private System.Windows.Forms.RadioButton radioButtonNonFillElipce;
        private System.Windows.Forms.RadioButton radioButtonFillElipce;
        private System.Windows.Forms.RadioButton radioButtonEraser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButtonSelector;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

