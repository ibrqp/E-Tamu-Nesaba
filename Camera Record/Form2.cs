using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Camera_Record
{
    public partial class Form2 : Form
    {
        private OleDbConnection conn;
        private OleDbDataAdapter adapter;
        private DataTable dt;

        public Form2()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\dbsiswa.mdb;");
        }

        private void GetVoteData()
        {
            conn.Open();
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT countOfVote FROM vote_jurusan", conn);
            adapter.Fill(dt);

            chart1.Series.Clear();

            // Menambahkan series baru ke Chart
            Series series = chart1.Series.Add("Jumlah Suara");

            // Menambahkan data ke series
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string label = GetCustomLabel(i + 1);
                int value = Convert.ToInt32(dt.Rows[i]["countOfVote"]);
                series.Points.AddXY(label, value);
            }

            // Mengatur jenis grafik
            series.ChartType = SeriesChartType.Column;

            conn.Close();
        }
        private void GetCustomers()
        {
            conn.Open();
            //con = new OleDbConnection("provider=Microsoft.ACE.OleDB.12.0; Data Source=D:\\dbsiswa.mdb");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM Jumlah_Pengunjung",conn);
            //con.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt; // Menggunakan huruf besar "S" dalam "DataSource"
            conn.Close();
        }

        private string GetCustomLabel(int index)
        {
            // Menentukan tulisan sesuai dengan nilai index
            switch (index)
            {
                case 1:
                    return "BRODCAST";
                case 2:
                    return "BUSANA";
                case 3:
                    return "DKV";
                case 4:
                    return "MEKATRONIKA";
                case 5:
                    return "OTOTRONIKA";
                case 6:
                    return "PPLG";
                case 7:
                    return "TEI";
                case 8:
                    return "TITL";
                case 9:
                    return "TJKT";
                default:
                    return "";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Mengatur Chart
            chart1.Titles.Add("Grafik Hasil Voting Jurusan");
            chart1.ChartAreas[0].AxisX.Title = "Jurusan";
            chart1.ChartAreas[0].AxisY.Title = "Jumlah Suara";

            // Mengatur DataGridView
            dataGridView1.AutoResizeColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetVoteData();
            GetCustomers();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            GetVoteData();
            GetCustomers();

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            GetVoteData();
            GetCustomers();
        }
    }
}
