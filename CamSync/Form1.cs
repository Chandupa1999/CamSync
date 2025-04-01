using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;



namespace CamSync
{
    public partial class Form1 : Form
    {

        private bool isDraggingHorizontal = false;
        private int mouseY;

        private bool isDraggingLeft = false;
        private bool isDraggingRight = false;
        private int mouseX;


        public Form1()
        {
            InitializeComponent();

            // Horizontal line events
            linePanel.MouseDown += LinePanel_MouseDown;
            linePanel.MouseMove += LinePanel_MouseMove;
            linePanel.MouseUp += LinePanel_MouseUp;

            // Left vertical line events
            linePanelLeft.MouseDown += LinePanelLeft_MouseDown;
            linePanelLeft.MouseMove += LinePanelLeft_MouseMove;
            linePanelLeft.MouseUp += LinePanelLeft_MouseUp;

            // Right vertical line events
            linePanelRight.MouseDown += LinePanelRight_MouseDown;
            linePanelRight.MouseMove += LinePanelRight_MouseMove;
            linePanelRight.MouseUp += LinePanelRight_MouseUp;
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice1, videoCaptureDevice2;








        private void btnStart_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice1 != null && videoCaptureDevice1.IsRunning)
            {
                videoCaptureDevice1.SignalToStop();
                videoCaptureDevice1.WaitForStop();
            }

            videoCaptureDevice1 = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice1.NewFrame += VideoCaptureDevice1_NewFrame;
            videoCaptureDevice1.Start();
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice2 != null && videoCaptureDevice2.IsRunning)
            {
                videoCaptureDevice2.SignalToStop();
                videoCaptureDevice2.WaitForStop();
            }

            videoCaptureDevice2 = new VideoCaptureDevice(filterInfoCollection[cboCamera2.SelectedIndex].MonikerString);
            videoCaptureDevice2.NewFrame += VideoCaptureDevice2_NewFrame;
            videoCaptureDevice2.Start();
        }









        private void VideoCaptureDevice1_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            frame.RotateFlip(RotateFlipType.RotateNoneFlipX); // Flip image horizontally
            pic.Image = frame;
        }

        private void VideoCaptureDevice2_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            frame.RotateFlip(RotateFlipType.RotateNoneFlipX); // Flip image horizontally
            pic2.Image = frame;
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cboCamera.Items.Add(filterInfo.Name);
                cboCamera2.Items.Add(filterInfo.Name);
            }

            if (cboCamera.Items.Count > 0)
                cboCamera.SelectedIndex = 0;

            if (cboCamera2.Items.Count > 0)
                cboCamera2.SelectedIndex = 0;

            videoCaptureDevice1 = new VideoCaptureDevice();
            videoCaptureDevice2 = new VideoCaptureDevice();
        }










        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice1 != null && videoCaptureDevice1.IsRunning)
                videoCaptureDevice1.SignalToStop();
            videoCaptureDevice1.WaitForStop();

            if (videoCaptureDevice2 != null && videoCaptureDevice2.IsRunning)
                videoCaptureDevice2.SignalToStop();
            videoCaptureDevice2.WaitForStop();
        }














        // Horizontal line dragging (Up & Down)
        private void LinePanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDraggingHorizontal = true;
            mouseY = e.Y;
        }

        private void LinePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggingHorizontal)
            {
                int newY = linePanel.Top + (e.Y - mouseY);

                // Horizontal line dragging
                // Set limits for movement (adjust minY and maxY as needed)
                int minY = 156;  // Minimum Y position
                int maxY = 625; // Maximum Y position

                if (newY >= minY && newY <= maxY)
                {
                    linePanel.Top = newY;
                }
            }
        }
        private void LinePanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingHorizontal = false;
        }

        // Left vertical line dragging (Left & Right)
        private void LinePanelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            isDraggingLeft = true;
            mouseX = e.X;
        }

        private void LinePanelLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggingLeft)
            {
                int newX = linePanelLeft.Left + (e.X - mouseX);

                // Left vertical line dragging
                // Set limits for movement (adjust minX and maxX as needed)
                int minX = 64;  // Minimum X position
                int maxX = 584; // Maximum X position

                if (newX >= minX && newX <= maxX)
                {
                    linePanelLeft.Left = newX;
                }
            }
        }
        private void LinePanelLeft_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingLeft = false;
        }

        // Right vertical line dragging (Left & Right)
        private void LinePanelRight_MouseDown(object sender, MouseEventArgs e)
        {
            isDraggingRight = true;
            mouseX = e.X;
        }
        private void LinePanelRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggingRight)
            {
                int newX = linePanelRight.Left + (e.X - mouseX);

                // Right vertical line dragging
                // Set limits for movement (adjust minX and maxX as needed)
                int minX = 585;   // Minimum X position
                int maxX = 1106;  // Maximum X position

                if (newX >= minX && newX <= maxX)
                {
                    linePanelRight.Left = newX;
                }
            }
        }

        private void LinePanelRight_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingRight = false;
        }









        private void btnStop1_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice1 != null && videoCaptureDevice1.IsRunning)
            {
                videoCaptureDevice1.SignalToStop();
                videoCaptureDevice1.WaitForStop();
                pic.Image = null;  // Clear the PictureBox
            }
        }
        private void btnStop2_Click_1(object sender, EventArgs e)
        {
            if (videoCaptureDevice2 != null && videoCaptureDevice2.IsRunning)
            {
                videoCaptureDevice2.SignalToStop();
                videoCaptureDevice2.WaitForStop();
                pic2.Image = null;  // Clear the PictureBox
            }
        }












        private void btnInfo_Click_1(object sender, EventArgs e)
        {
            string aboutText = "DualCam Viewer\n\n" +
                       "Version: 1.0\n" +
                       "Developed by: Chandupa Perera\n\n" +
                       "This application allows you to view and manage two cameras simultaneously.\n" +
                       "Features:\n" +
                       "✔ Start & Stop each camera separately\n" +
                       "✔ Move adjustable guide lines\n" +
                       "✔ Simple & user-friendly interface\n\n" +

                       "📧 Contact: yashasvichandupa@gmail.com\n" +
                       "📞 Phone: +94 713684090";


            MessageBox.Show(aboutText, "About CamSync Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        
    }
}
