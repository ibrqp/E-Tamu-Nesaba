using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using System.Diagnostics;
using AForge.Video.DirectShow;
using System.Collections;
using System.IO;
using System.Drawing.Imaging;
using System.Data.OleDb;
using Camera_Record.Kelas;
using Bunifu.UI.WinForms;

namespace Camera_Record
{
    public partial class Form5 : Form
    {
        //OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCapabilities[] snapshotCapabilities;

        private ArrayList listCamera = new ArrayList();
        public string pathFolder = Application.StartupPath + @"\ibra\";
        public string pathDB = Application.StartupPath + @"\db\";
        public string nameCapture = "";
        public string Jurusan = "";

        private Stopwatch stopWatch = null;
        private static bool needSnapshot = false;


        //Kelas.Koneksi konn = new Kelas.Koneksi();
        void bersih()
        {
            textBox_Nama.Text = "";
            textBox_AsalSekolah.Text = "";
            textBox_NoHp.Text = "";
            textBox_Alamat.Text = "";
        }



        public Form5()
        {
            InitializeComponent();
            getListCameraUSB();
            OpenCamera();

        }
        //void GetCustomers()
        //{
        //    Koneksi.conn.Open();
        //    //con = new OleDbConnection("provider=Microsoft.ACE.OleDB.12.0; Data Source=D:\\dbsiswa.mdb");
        //    dt = new DataTable();
        //    adapter = new OleDbDataAdapter("SELECT * FROM tbl_siswa", Koneksi.conn);
        //    //con.Open();
        //    adapter.Fill(dt);
        //    //dataGridView1.DataSource = dt; // Menggunakan huruf besar "S" dalam "DataSource"
        //    Koneksi.conn.Close();
        //}


        private static string _usbcamera;
        public string usbcamera
        {
            get { return _usbcamera; }
            set { _usbcamera = value; }
        }







        #region Open Scan Camera
        private void OpenCamera()
        {
            try
            {
                usbcamera = comboBox1.SelectedIndex.ToString();
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count != 0)
                {
                    // add all devices to combo
                    foreach (FilterInfo device in videoDevices)
                    {
                        listCamera.Add(device.Name);

                    }
                }
                else
                {
                    MessageBox.Show("Camera devices found");
                }

                videoDevice = new VideoCaptureDevice(videoDevices[Convert.ToInt32(usbcamera)].MonikerString);
                snapshotCapabilities = videoDevice.SnapshotCapabilities;
                if (snapshotCapabilities.Length == 0)
                {
                    //MessageBox.Show("Camera Capture Not supported");
                }

                OpenVideoSource(videoDevice);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }
        #endregion


        //Delegate Untuk Capture, insert database, update ke grid 
        public delegate void CaptureSnapshotManifast(Bitmap image);
        public void UpdateCaptureSnapshotManifast(Bitmap image)
        {
            try
            {
                needSnapshot = false;
                pictureBox2.Image = image;
                pictureBox2.Update();


                string namaImage = "sampleImage";

                nameCapture = namaImage + "_" + textBox_Nama.Text + ".bmp";
                // label4.Text = pathFolder + nameCapture;

                //String namafile = nameCapture;
                //MessageBox.Show(namafile);
                if (Directory.Exists(pathFolder))
                {
                    pictureBox2.Image.Save(pathFolder + nameCapture, ImageFormat.Bmp);
                }
                else
                {
                    Directory.CreateDirectory(pathFolder);
                    pictureBox2.Image.Save(pathFolder + nameCapture, ImageFormat.Bmp);
                }

            }
            catch { }
            simpan();
        }

        public void OpenVideoSource(IVideoSource source)
        {
            try
            {
                // set busy cursor
                this.Cursor = Cursors.WaitCursor;

                // stop current video source
                CloseCurrentVideoSource();

                // start new video source
                videoSourcePlayer1.VideoSource = source;
                videoSourcePlayer1.Start();

                // reset stop watch
                stopWatch = null;


                this.Cursor = Cursors.Default;
            }
            catch { }
        }

        private void getListCameraUSB()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count != 0)
            {
                // add all devices to combo
                foreach (FilterInfo device in videoDevices)
                {
                    comboBox1.Items.Add(device.Name);

                }
            }
            else
            {
                comboBox1.Items.Add("No DirectShow devices found");
            }

            comboBox1.SelectedIndex = 0;

        }

        public void CloseCurrentVideoSource()
        {
            try
            {

                if (videoSourcePlayer1.VideoSource != null)
                {
                    videoSourcePlayer1.SignalToStop();

                    // wait ~ 3 seconds
                    for (int i = 0; i < 30; i++)
                    {
                        if (!videoSourcePlayer1.IsRunning)
                            break;
                        System.Threading.Thread.Sleep(100);
                    }

                    if (videoSourcePlayer1.IsRunning)
                    {
                        videoSourcePlayer1.Stop();
                    }

                    videoSourcePlayer1.VideoSource = null;
                }
            }
            catch { }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //radio();
            //simpan();

            //bersih();

        }

        private void videoSourcePlayer1_NewFrame_1(object sender, ref Bitmap image)
        {
            try
            {
                DateTime now = DateTime.Now;
                Graphics g = Graphics.FromImage(image);

                // paint current time
                SolidBrush brush = new SolidBrush(Color.Red);
                g.DrawString(now.ToString(), this.Font, brush, new PointF(5, 5));
                brush.Dispose();
                if (needSnapshot)
                {
                    this.Invoke(new CaptureSnapshotManifast(UpdateCaptureSnapshotManifast), image);
                }
                g.Dispose();
            }
            catch
            { }
           }
        public void button_simpan(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //simpan();
            //bersih();

        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    GetCustomers();
        //}


        void simpan()
        {

            try
            {

                radio();

                //Console.WriteLine(nameCapture);
                //MessageBox.Show(nameCapture);

                Koneksi.conn.Open();
                String Queri = "INSERT INTO tbl_siswa (`Nama`, `Asal_Sekolah`, `NoHp`, `Alamat`, `vote` ,`img`) VALUES ('" + textBox_Nama.Text + "', '" + textBox_AsalSekolah.Text + "', '" + textBox_NoHp.Text + "', '" + textBox_Alamat.Text + "', '" + Jurusan + "','" + nameCapture + "')";
                cmd = new OleDbCommand(Queri, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("TerimaKasih " + textBox_Nama.Text + " Atas Partisipasinya ");
                Koneksi.conn.Close();
                bersih(); //memanggil method Clear
            }
            catch (Exception)
            {

                //MessageBox.Show("Tambah Data Gagal");
            }
        }

        public void label4_Click(object sender, EventArgs e)
        {

        }


        void radio()
        {
            Jurusan = "";

            if (radioButton1.Checked == true)
            {
                Jurusan = bunifuLabel1.Text;
            }
            if (radioButton2.Checked == true)
            {
                Jurusan = bunifuLabel2.Text;
            }
            if (radioButton3.Checked == true)
            {
                Jurusan = bunifuLabel3.Text;
            }
            if (radioButton4.Checked == true)
            {
                Jurusan = bunifuLabel4.Text;
            }
            if (radioButton5.Checked == true)
            {
                Jurusan = bunifuLabel5.Text;
            }
            if (radioButton6.Checked == true)
            {
                Jurusan = bunifuLabel6.Text;
            }
            if (radioButton7.Checked == true)
            {
                Jurusan = bunifuLabel7.Text;
            }
            if (radioButton8.Checked == true)
            {
                Jurusan = bunifuLabel8.Text;
            }
            if (radioButton9.Checked == true)
            {
                Jurusan = bunifuLabel8.Text;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void radioButton1_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged2_1(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            bunifuLabel1.Hide();
        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGroupBox1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void videoSourcePlayer1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textBox_Nama_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            needSnapshot = true;
        }

        private void buttonSimpan_Click_1(object sender, EventArgs e)
        {
            needSnapshot = true;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            needSnapshot=true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
