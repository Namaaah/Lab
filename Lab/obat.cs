using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab
{
    public partial class obat : UserControl
    {
        int kedip = 0;
        int selectedId = -1;
        bool modeEdit = false;
        private Dashboard _dashboard;

        public obat(Dashboard dashboard = null)
        {
            InitializeComponent();
            _dashboard = dashboard;
            DatabaseHelper.InitDatabase();
            MuatDataObat();

        }

        private void RefreshLog()
        {
            _dashboard?.RefreshDashboard();
        }


        public void MuatDataObat()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            DataTable dt = DatabaseHelper.GetSemuaObat();
            dataGridView1.DataSource = dt;

            if (dataGridView1.Columns["Id"] != null)
                dataGridView1.Columns["Id"].Visible = false;
        }


        private void ResetModeEdit()
        {
            selectedId = -1;
            modeEdit = false;
            btnSimpan.Text = "Simpan";
            btnSimpan.BackColor = Color.FromArgb(255, 193, 7); // Warna kuning asli
        }

        private void BersihkanForm()
        {
            txtobat.textBox.Text = "";
            cbjenis.SelectedIndex = -1;
            txtjumlah.textBox.Text = "";
            txtpenyimpanan.textBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }


        private void btnSimpan_Click_1(object sender, EventArgs e)
        {

            string nama = txtobat?.textBox?.Text ?? string.Empty;
            string jenis = cbjenis?.Text ?? string.Empty;
            string jumlahStr = txtjumlah?.textBox?.Text ?? string.Empty;
            string expired = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string lokasi = txtpenyimpanan?.textBox?.Text ?? string.Empty;


            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(jenis) ||
                string.IsNullOrWhiteSpace(jumlahStr) || string.IsNullOrWhiteSpace(lokasi))
            {
                label7.Visible = true;
                kedip = 0;
                timer1.Start();
                txtobat?.textBox?.Focus();
                return;
            }

            if (!int.TryParse(jumlahStr, out int jumlah))
            {
                label7.Text = "Jumlah harus berupa angka";
                label7.Visible = true;
                kedip = 0;
                timer1.Start();
                txtjumlah?.Focus();
                return;
            }

            if (selectedId == -1)
            {
                DatabaseHelper.SimpanObat(nama, jenis, jumlah, expired, lokasi);
                // ↓ TAMBAH DI SINI
                DatabaseHelper.TambahLog(
                    $"Admin menambahkan obat: Nama: \"{nama}\" | Jenis: \"{jenis}\" | " +
                    $"Jumlah: \"{jumlah}\" | Expired: \"{expired}\" | Lokasi: \"{lokasi}\""
                );
            }
            else
            {
                // ↓ AMBIL DATA LAMA DULU
                string namaLama = dataGridView1.SelectedRows[0].Cells["Nama"].Value?.ToString();
                string jenisLama = dataGridView1.SelectedRows[0].Cells["Jenis"].Value?.ToString();
                string jumlahLama = dataGridView1.SelectedRows[0].Cells["Jumlah"].Value?.ToString();
                string expiredLama = dataGridView1.SelectedRows[0].Cells["Date Expired"].Value?.ToString();
                string lokasiLama = dataGridView1.SelectedRows[0].Cells["Lokasi penyimpanan"].Value?.ToString();

                DatabaseHelper.UpdateObat(selectedId, nama, jenis, jumlah, expired, lokasi);
                // ↓ TAMBAH DI SINI
                DatabaseHelper.TambahLog(
                    $"Admin mengubah obat: Nama: \"{namaLama}\" → \"{nama}\" | " +
                    $"Jenis: \"{jenisLama}\" → \"{jenis}\" | Jumlah: \"{jumlahLama}\" → \"{jumlah}\" | " +
                    $"Expired: \"{expiredLama}\" → \"{expired}\" | Lokasi: \"{lokasiLama}\" → \"{lokasi}\""
                );
                ResetModeEdit();
            }
            MuatDataObat();
            BersihkanForm();
            RefreshLog();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            modeEdit = true;
            label9.Visible = true;
        }

 

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data obat yang ingin dihapus!");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["Id"].Value);
            string nama = row.Cells["Nama"].Value?.ToString();

            DialogResult result = MessageBox.Show(
                $"Hapus data obat '{nama}'?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // ↓ AMBIL DATA LENGKAP DULU
                string jenis = row.Cells["Jenis"].Value?.ToString();
                string jumlahStr = row.Cells["Jumlah"].Value?.ToString();
                string expired = row.Cells["Date Expired"].Value?.ToString();
                string lokasi = row.Cells["Lokasi penyimpanan"].Value?.ToString();

                DatabaseHelper.HapusObat(id);
                // ↓ TAMBAH DI SINI
                DatabaseHelper.TambahLog(
                    $"Admin menghapus obat: Nama: \"{nama}\" | Jenis: \"{jenis}\" | " +
                    $"Jumlah: \"{jumlahStr}\" | Expired: \"{expired}\" | Lokasi: \"{lokasi}\""
                );
                MuatDataObat();
                RefreshLog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label7.ForeColor == Color.Red)
                label7.ForeColor = Color.White;
            else
                label7.ForeColor = Color.Red;

            kedip++;

            if (kedip >= 10)
            {
                timer1.Stop();
                label7.Visible = false;
                label7.ForeColor = Color.Red;
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            if (!modeEdit) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            selectedId = Convert.ToInt32(row.Cells["Id"].Value);

            txtobat.textBox.Text = row.Cells["Nama"].Value?.ToString();
            cbjenis.SelectedItem = row.Cells["Jenis"].Value?.ToString();
            txtjumlah.textBox.Text = row.Cells["Jumlah"].Value?.ToString();
            txtpenyimpanan.textBox.Text = row.Cells["Lokasi penyimpanan"].Value?.ToString();

            // Parse tanggal expired
            if (DateTime.TryParseExact(row.Cells["Date Expired"].Value?.ToString(),
                "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime tgl))
            {
                dateTimePicker1.Value = tgl;
            }

            btnSimpan.Text = "Update";
            btnSimpan.BackColor = Color.Orange;
            modeEdit = false;
            label9.Visible = false;
        }
    }
}
