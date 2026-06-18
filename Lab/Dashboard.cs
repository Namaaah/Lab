using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Globalization;
using Chart = System.Windows.Forms.DataVisualization.Charting.Chart;
using ChartArea = System.Windows.Forms.DataVisualization.Charting.ChartArea;
using Legend = System.Windows.Forms.DataVisualization.Charting.Legend;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;
using SeriesChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType;


namespace Lab
{
    public partial class Dashboard : Form
    {
        private System.Windows.Forms.DataVisualization.Charting.Chart chartObat;
        public Dashboard()
        {
            InitializeComponent();
            MuatActivityLog();
            InitChart();
            MuatChartObat();
        }

        private void InitChart()
        {
            chartObat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartObat.Dock = DockStyle.Fill;
            chartObat.BackColor = Color.Transparent;
            panelChart.Controls.Add(chartObat);

            var chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            chartArea.BackColor = Color.Transparent;
            chartObat.ChartAreas.Add(chartArea);

            var legend = new System.Windows.Forms.DataVisualization.Charting.Legend();
            legend.BackColor = Color.Transparent;
            chartObat.Legends.Add(legend);
        }
        public void MuatChartObat()
        {
            chartObat.Series.Clear();
            chartObat.Titles.Clear();

            chartObat.Titles.Add("Stok Obat per Jenis");

            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Obat");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.Label = "#VALX\n#VAL";

            Dictionary<string, int> data = DatabaseHelper.GetTotalPerJenisObat();

            if (data.Count == 0)
            {
                chartObat.Titles.Clear();
                chartObat.Titles.Add("Belum ada data obat");
                return;
            }

            foreach (var item in data)
            {
                series.Points.AddXY(item.Key, item.Value);
            }

            chartObat.Series.Add(series);
            chartObat.ChartAreas[0].BackColor = Color.Transparent;
        }
        private void LoadUserControl(UserControl uc)
        {
            panel4.Controls.Clear();
            panel4.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            panel4.Visible = true;
        }
        private void KembaliKeDashboard()
        {
            ucdashboard uc = new ucdashboard(this); // ← tambah "this"
            LoadUserControl(uc);

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ucdashboard uc = new ucdashboard(this);
            LoadUserControl(uc);
            tanggal.Text = DateTime.Now.ToString("dddd,dd MMM yyyy");
        }

        private void cyberButton2_Click(object sender, EventArgs e)
        {
            ucdashboard uc = new ucdashboard(this);
            LoadUserControl(uc);

        }

        private void cyberButton3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }


        // Mouse enter event
        private void myButtons1_MouseEnter(object sender, EventArgs e)
        {
            myButtons1.BackColor = Color.FromArgb(67, 135, 71);
        }

        private void myButtons2_MouseEnter_1(object sender, EventArgs e)
        {
            myButtons2.BackColor = Color.FromArgb(67, 135, 71);
        }



        private void myButtons4_MouseEnter(object sender, EventArgs e)
        {
            myButtons4.BackColor = Color.FromArgb(67, 135, 71);
        }



        // Mouse leave event
        private void myButtons1_MouseLeave(object sender, EventArgs e)
        {
            myButtons1.BackColor = Color.Transparent;
        }


        private void myButtons2_MouseLeave(object sender, EventArgs e)
        {
            myButtons2.BackColor = Color.Transparent;
        }



        private void myButtons4_MouseLeave(object sender, EventArgs e)
        {
            myButtons4.BackColor = Color.Transparent;
        }



        // Mouse enter and event for cyber buttons


        private void cyberButton1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void myButtons2_Click(object sender, EventArgs e)
        {
            Pasienv2 passien = new Pasienv2();
            LoadUserControl(passien);
        }

        private void myButtons3_Click(object sender, EventArgs e)
        {
            ruang ruang = new ruang();
            LoadUserControl(ruang);
        }

        private void myButtons4_Click(object sender, EventArgs e)
        {
            obat obat = new obat();
            LoadUserControl(obat);
        }

        private void myButtons5_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            LoadUserControl(update);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetButtonActive(Button selectedButton)
        {
            // List semua tombol yang ingin dikelola warnanya
            List<Button> menuButtons = new List<Button> { myButtons1, myButtons2, myButtons4 };

            foreach (var btn in menuButtons)
            {
                // Kembalikan ke warna awal (misal: Hijau Tua UKS)
                btn.BackColor = Color.FromArgb(45, 120, 70);
                btn.ForeColor = Color.White;
            }

            // Ubah tombol yang diklik ke warna Aktif (misal: Hijau Muda atau Putih)
            selectedButton.BackColor = Color.FromArgb(135, 70, 70);
            selectedButton.ForeColor = Color.Red;
        }

        private void myButtons1_click(object sender, EventArgs e)
        {
            SetButtonActive(myButtons1);
            Petugas petugas = new Petugas(this);
            LoadUserControl(petugas);
            MuatActivityLog();

        }
        private void myButtons2_click(object sender, EventArgs e)
        {
            SetButtonActive(myButtons2);
            Pasienv2 passien = new Pasienv2(this);
            LoadUserControl(passien);
            MuatActivityLog();

        }

        private void myButtons4_click(object sender, EventArgs e)
        {
            SetButtonActive(myButtons4);
            obat obat = new obat(this);
            LoadUserControl(obat);
            MuatActivityLog();

        }


        private void timerJam_Tick(object sender, EventArgs e)
        {
            jam.Text = DateTime.Now.ToString("HH:mm:ss");

            tanggal.Text = DateTime.Now.ToString("dddd | dd MMM yyyy ");
        }

        private void myButtons6_MouseEnter(object sender, EventArgs e)
        {
            myButtons6.BackColor = Color.White;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void shapedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shapedPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        public void MuatActivityLog()
        {
            richTextBoxLog.Clear();
            List<string> logs = DatabaseHelper.GetActivityLog();
            foreach (string log in logs)
            {
                richTextBoxLog.AppendText(log + Environment.NewLine + Environment.NewLine);
                // Environment.NewLine kedua = beri jarak antar item log
            }
        }


        public void RefreshDashboard()
        {
            MuatActivityLog();

        }

        private void myButtons5_Click_1(object sender, EventArgs e)
        {
            Petugas petugas = new Petugas();
            LoadUserControl(petugas);
        }

        private void myButtons7_Click(object sender, EventArgs e)
        {
            Pasien pasien = new Pasien();
            LoadUserControl(pasien);
        }

        private void myButtons8_Click(object sender, EventArgs e)
        {
            obat obat = new obat();
            LoadUserControl(obat);
        }

        public void LoadUC(UserControl uc)
        {
            LoadUserControl(uc);
        }

        private void myButtons1_Click_1(object sender, EventArgs e)
        {
           
            Petugas petugas = new Petugas(this);
            LoadUserControl(petugas);
            MuatActivityLog();

        }
    }
}
