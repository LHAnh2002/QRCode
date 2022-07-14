using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QRCode
{
    public partial class Form1 : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        bool batdau = true;
        public delegate void delPassData(TextBox text);
        public Form1()
        {
            InitializeComponent();
            
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Taoqr f = new Taoqr();
            f.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btQuet.Text = "Quét QR!";
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cbBCamera.Items.Add(Device.Name);
            if (cbBCamera.Items.Count > 0)
            {
                cbBCamera.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
            }
        }

        private void btQuet_Click(object sender, EventArgs e)
        {
            
            if (batdau  )
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbBCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
                videoCaptureDevice.Start();
                timer1.Start();
                btQuet.Text = "Dừng!";
                batdau = false;

            }
            else
            {
                btQuet.Text = "Quét QR!";
                timer1.Stop();
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.SignalToStop();
                batdau = true;
            }
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraqr.Image = (Bitmap)eventArgs.Frame.Clone();
            

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(cameraqr.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)cameraqr.Image);
                if(result != null)
                {
                    txtQRCode.Text = result.ToString();
                    //timer1.Stop();
                    //if (videoCaptureDevice.IsRunning)
                    //    videoCaptureDevice.SignalToStop();
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {   
            if (videoCaptureDevice.IsRunning)
                videoCaptureDevice.SignalToStop();
        }


        public TimKiem fa = null;
        private void txtQRCode_TextChanged(object sender, EventArgs e)
        {
            if (txtQRCode.Text != "")
            {   if(fa!= null)
                {
                    fa.Close();
                }
                fa= new TimKiem();
                fa.funData(this.txtQRCode);
                fa.Show();
                txtQRCode.Clear();
            }
        }

        private void btHinhAnh_Click(object sender, EventArgs e)
        {
            
        }
    }
}