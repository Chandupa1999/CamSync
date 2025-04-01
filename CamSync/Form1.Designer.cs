namespace CamSync
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            cboCamera = new ComboBox();
            cboCamera2 = new ComboBox();
            pic = new PictureBox();
            pic2 = new PictureBox();
            btnStart = new Button();
            btnStop1 = new Button();
            btnStop2 = new Button();
            btnStart2 = new Button();
            btnInfo = new Button();
            linePanel = new Panel();
            linePanelLeft = new Panel();
            linePanelRight = new Panel();
            btnRotate1 = new Button();
            btnRotate2 = new Button();
            btnFlip1 = new Button();
            btnFlip2 = new Button();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 75);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Select Left Camera :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(586, 75);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 1;
            label2.Text = "Select Right Camera :";
            // 
            // cboCamera
            // 
            cboCamera.FormattingEnabled = true;
            cboCamera.Location = new Point(184, 72);
            cboCamera.Name = "cboCamera";
            cboCamera.Size = new Size(361, 23);
            cboCamera.TabIndex = 2;
            // 
            // cboCamera2
            // 
            cboCamera2.FormattingEnabled = true;
            cboCamera2.Location = new Point(714, 72);
            cboCamera2.Name = "cboCamera2";
            cboCamera2.Size = new Size(361, 23);
            cboCamera2.TabIndex = 3;
            // 
            // pic
            // 
            pic.BackgroundImageLayout = ImageLayout.Center;
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.Location = new Point(67, 159);
            pic.Name = "pic";
            pic.Size = new Size(519, 464);
            pic.SizeMode = PictureBoxSizeMode.CenterImage;
            pic.TabIndex = 4;
            pic.TabStop = false;
            // 
            // pic2
            // 
            pic2.BackgroundImageLayout = ImageLayout.Center;
            pic2.BorderStyle = BorderStyle.FixedSingle;
            pic2.Location = new Point(586, 159);
            pic2.Margin = new Padding(0);
            pic2.Name = "pic2";
            pic2.Size = new Size(519, 464);
            pic2.SizeMode = PictureBoxSizeMode.CenterImage;
            pic2.TabIndex = 5;
            pic2.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.BackgroundImageLayout = ImageLayout.Zoom;
            btnStart.Location = new Point(470, 113);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.UseWaitCursor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop1
            // 
            btnStop1.Cursor = Cursors.No;
            btnStop1.Location = new Point(389, 113);
            btnStop1.Name = "btnStop1";
            btnStop1.Size = new Size(75, 23);
            btnStop1.TabIndex = 7;
            btnStop1.Text = "Stop";
            btnStop1.UseVisualStyleBackColor = true;
            btnStop1.Click += btnStop1_Click;
            // 
            // btnStop2
            // 
            btnStop2.Cursor = Cursors.No;
            btnStop2.Location = new Point(919, 113);
            btnStop2.Name = "btnStop2";
            btnStop2.Size = new Size(75, 23);
            btnStop2.TabIndex = 9;
            btnStop2.Text = "Stop";
            btnStop2.UseVisualStyleBackColor = true;
            btnStop2.Click += btnStop2_Click_1;
            // 
            // btnStart2
            // 
            btnStart2.Cursor = Cursors.AppStarting;
            btnStart2.Location = new Point(1000, 113);
            btnStart2.Name = "btnStart2";
            btnStart2.Size = new Size(75, 23);
            btnStart2.TabIndex = 8;
            btnStart2.Text = "Start";
            btnStart2.UseVisualStyleBackColor = true;
            btnStart2.Click += btnStart2_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackgroundImage = (Image)resources.GetObject("btnInfo.BackgroundImage");
            btnInfo.BackgroundImageLayout = ImageLayout.Stretch;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Location = new Point(1132, 11);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(27, 26);
            btnInfo.TabIndex = 10;
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click_1;
            // 
            // linePanel
            // 
            linePanel.BackColor = Color.Red;
            linePanel.Cursor = Cursors.HSplit;
            linePanel.Location = new Point(58, 201);
            linePanel.Name = "linePanel";
            linePanel.Size = new Size(1056, 2);
            linePanel.TabIndex = 11;
            // 
            // linePanelLeft
            // 
            linePanelLeft.BackColor = SystemColors.MenuHighlight;
            linePanelLeft.Cursor = Cursors.VSplit;
            linePanelLeft.Location = new Point(317, 149);
            linePanelLeft.Name = "linePanelLeft";
            linePanelLeft.Size = new Size(2, 483);
            linePanelLeft.TabIndex = 13;
            // 
            // linePanelRight
            // 
            linePanelRight.BackColor = SystemColors.MenuHighlight;
            linePanelRight.Cursor = Cursors.VSplit;
            linePanelRight.Location = new Point(820, 149);
            linePanelRight.Name = "linePanelRight";
            linePanelRight.Size = new Size(2, 483);
            linePanelRight.TabIndex = 14;
            // 
            // btnRotate1
            // 
            btnRotate1.Location = new Point(511, 644);
            btnRotate1.Name = "btnRotate1";
            btnRotate1.Size = new Size(75, 23);
            btnRotate1.TabIndex = 15;
            btnRotate1.Text = "Rotate";
            btnRotate1.UseVisualStyleBackColor = true;
            btnRotate1.Click += btnRotate1_Click;
            // 
            // btnRotate2
            // 
            btnRotate2.Location = new Point(1030, 644);
            btnRotate2.Name = "btnRotate2";
            btnRotate2.Size = new Size(75, 23);
            btnRotate2.TabIndex = 16;
            btnRotate2.Text = "Rotate";
            btnRotate2.UseVisualStyleBackColor = true;
            btnRotate2.Click += btnRotate2_Click;
            // 
            // btnFlip1
            // 
            btnFlip1.Location = new Point(430, 644);
            btnFlip1.Name = "btnFlip1";
            btnFlip1.Size = new Size(75, 23);
            btnFlip1.TabIndex = 17;
            btnFlip1.Text = "Flip";
            btnFlip1.UseVisualStyleBackColor = true;
            btnFlip1.Click += btnFlip1_Click_1;
            // 
            // btnFlip2
            // 
            btnFlip2.Location = new Point(949, 644);
            btnFlip2.Name = "btnFlip2";
            btnFlip2.Size = new Size(75, 23);
            btnFlip2.TabIndex = 18;
            btnFlip2.Text = "Flip";
            btnFlip2.UseVisualStyleBackColor = true;
            btnFlip2.Click += btnFlip2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 635);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-194, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1800, 1);
            panel1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1172, 688);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(btnFlip2);
            Controls.Add(btnFlip1);
            Controls.Add(btnRotate2);
            Controls.Add(btnRotate1);
            Controls.Add(linePanelRight);
            Controls.Add(linePanelLeft);
            Controls.Add(linePanel);
            Controls.Add(btnInfo);
            Controls.Add(btnStop2);
            Controls.Add(btnStart2);
            Controls.Add(btnStop1);
            Controls.Add(btnStart);
            Controls.Add(pic2);
            Controls.Add(pic);
            Controls.Add(cboCamera2);
            Controls.Add(cboCamera);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CamSync Viewer";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboCamera;
        private ComboBox cboCamera2;
        private PictureBox pic;
        private PictureBox pic2;
        private Button btnStart;
        private Button btnStop1;
        private Button btnStop2;
        private Button btnStart2;
        private Button btnInfo;
        private Panel linePanel;
        private Panel linePanelLeft;
        private Panel linePanelRight;
        private Button btnRotate1;
        private Button btnRotate2;
        private Button btnFlip1;
        private Button btnFlip2;
        private Label label3;
        private Panel panel1;
    }
}
