using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;

namespace StudioManager
{
    public partial class WebcamTests : Form
    {
        public WebcamTests()
        {
            InitializeComponent();
        }

        private VideoCaptureDevice finalCamera;
        private FilterInfoCollection videoDevices;


        private void WebcamTests_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo CaptureDevices in videoDevices)
            {
                cmb_Webcam.Items.Add(CaptureDevices.Name);
            }
            cmb_Webcam.SelectedIndex = 0;
            finalCamera = new VideoCaptureDevice();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (finalCamera.IsRunning == true) finalCamera.Stop();

            finalCamera = new VideoCaptureDevice(videoDevices[cmb_Webcam.SelectedIndex].MonikerString);
            finalCamera.NewFrame += new NewFrameEventHandler(video_NewFrame);

        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // get new frame
            Bitmap video = (Bitmap)eventArgs.Frame;
            pb_webcam.Image = video;
            // process the frame
        }

        
    }
}
