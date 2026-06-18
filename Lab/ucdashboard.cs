using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab
{
    public partial class ucdashboard : UserControl
    {
        private System.Windows.Forms.DataVisualization.Charting.Chart chartObat;
        private Dashboard _dashboard;
        public ucdashboard(Dashboard dashboard = null)
        {
            InitializeComponent();
            _dashboard = dashboard;
            InitChart();
            MuatActivityLog();
            MuatChartObat();
            MuatStatistik();
        }

        private void LoadUserControl(UserControl uc)
        {
            _dashboard?.LoadUC(uc);
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

        public void MuatActivityLog()
        {
            richTextBoxLog.Clear();
            List<string> logs = DatabaseHelper.GetActivityLog();
            foreach (string log in logs)
            {
                richTextBoxLog.AppendText(log + Environment.NewLine + Environment.NewLine);
            }
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
                series.Points.AddXY(item.Key, item.Value);

            chartObat.Series.Add(series);
            chartObat.ChartAreas[0].BackColor = Color.Transparent;
        }

        public void MuatStatistik()
        {
            // Hitung total pasien
            DataTable dtPasien = DatabaseHelper.GetSemuaPasien();
            label8.Text = dtPasien.Rows.Count.ToString();

            // Hitung total petugas
            DataTable dtPetugas = DatabaseHelper.GetSemuaPetugas();
            label9.Text = dtPetugas.Rows.Count.ToString();

            // Hitung total obat
            DataTable dtObat = DatabaseHelper.GetSemuaObat();
            label13.Text = dtObat.Rows.Count.ToString();
        }
        private void myButtons5_Click(object sender, EventArgs e)
        {
            Petugas petugas = new Petugas(_dashboard);
            LoadUserControl(petugas);
        }
        private void myButtons7_Click(object sender, EventArgs e)
        {
            Pasien pasien = new Pasien();
            LoadUserControl(pasien);
        }

        private void myButtons8_Click(object sender, EventArgs e)
        {
            obat obat = new obat(_dashboard);
            LoadUserControl(obat);
        }
    }
}
