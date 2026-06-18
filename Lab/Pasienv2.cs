using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab
{
    public partial class Pasienv2 : UserControl
    {

        int kedip = 0;
        int selectedId = -1; // penympanan id pasien untuk di edit 
        bool modeEdit = false;
        private Dashboard _dashboard; // menyimpan referensi ke Dashboard


        public Pasienv2(Dashboard dashboard = null)
        {
            InitializeComponent();
            _dashboard = dashboard; // simpan referensinya
            DatabaseHelper.InitDatabase(); // Pindah ke sini, bukan di Load
            MuatDataPasien();              // Pindah ke sini juga
        }

        private void RefreshLog()
        {
            _dashboard?.RefreshDashboard();
        }


        public void MuatDataPasien()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            DataTable dt = DatabaseHelper.GetSemuaPasien();
            dataGridView1.DataSource = dt;

            // Sembunyikan kolom Id DULU sebelum hitung apapun
            if (dataGridView1.Columns["Id"] != null)
                dataGridView1.Columns["Id"].Visible = false;

            // Hitung langsung dari DataTable, bukan dari datagrid
            int totalPria = 0;
            int totalWanita = 0;
            foreach (DataRow row in dt.Rows)
            {
                string nilaiGender = row["Gender"]?.ToString().ToUpper() ?? "";
                if (nilaiGender == "MALE") totalPria++;
                if (nilaiGender == "FEMALE") totalWanita++;
            }

            label8.Text = dt.Rows.Count.ToString();
            tPria.Text = totalPria.ToString();
            tWanita.Text = totalWanita.ToString();
        }


        private void Buttons2_Click(object sender, EventArgs e)
        {
            string nama = txtNama?.textBox?.Text ?? string.Empty;
            string gender = cbGender?.SelectedItem?.ToString() ?? string.Empty;
            string umur = txtUmur?.textBox?.Text ?? string.Empty;
            string darah = (txtDarah?.textBox?.Text ?? string.Empty).ToUpper();
            string penyakit = txtPenyakit?.textBox?.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(umur) || string.IsNullOrWhiteSpace(darah) ||
                string.IsNullOrWhiteSpace(penyakit))
            {
                label6.Visible = true;
                kedip = 0;
                timer1.Start();
                txtNama?.textBox?.Focus();
                return;
            }

            if (!int.TryParse(umur, out int umurInt))
            {
                label6.Text = "Umur harus berupa angka";
                label6.Visible = true;
                kedip = 0;
                timer1.Start();
                txtUmur?.textBox?.Focus();
                return;
            }

            if (selectedId == -1)
            {
                // Mode Simpan biasa
                DatabaseHelper.SimpanPasien(nama, gender, umurInt, darah, penyakit);
                // ↓ TAMBAH DI SINI
                DatabaseHelper.TambahLog(
                    $"Admin menambahkan pasien: Nama: \"{nama}\" | Gender: \"{gender}\" | " +
                    $"Umur: \"{umurInt}\" | Gol darah: \"{darah}\" | Penyakit: \"{penyakit}\""
                );
            }
            else
            {
                // ↓ AMBIL DATA LAMA DULU SEBELUM UPDATE
                string namaLama = dataGridView1.SelectedRows[0].Cells["Nama"].Value?.ToString();
                string genderLama = dataGridView1.SelectedRows[0].Cells["Gender"].Value?.ToString();
                string umurLama = dataGridView1.SelectedRows[0].Cells["Umur"].Value?.ToString();
                string darahLama = dataGridView1.SelectedRows[0].Cells["Gol darah"].Value?.ToString();
                string penyakitLama = dataGridView1.SelectedRows[0].Cells["Penyakit"].Value?.ToString();

                // Mode Update (HAPUS panggilan UpdatePasien yang kedua di bawah)
                DatabaseHelper.UpdatePasien(selectedId, nama, gender, umurInt, darah, penyakit);
                // ↓ TAMBAH DI SINI
                DatabaseHelper.TambahLog(
                    $"Admin mengubah pasien: Nama: \"{namaLama}\" → \"{nama}\" | " +
                    $"Gender: \"{genderLama}\" → \"{gender}\" | Umur: \"{umurLama}\" → \"{umurInt}\" | " +
                    $"Gol darah: \"{darahLama}\" → \"{darah}\" | Penyakit: \"{penyakitLama}\" → \"{penyakit}\""
                );
                ResetModeEdit();
            }
            MuatDataPasien();
            BersihkanForm();
            RefreshLog();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label6.ForeColor == Color.Red)
                label6.ForeColor = Color.White;
            else
                label6.ForeColor = Color.Red;

            kedip++;

            if (kedip >= 10)
            {
                timer1.Stop();
                label6.Visible = false;
                label6.ForeColor = Color.Red;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih pasien yang akan dihapus.");
                return;
            }

            DataGridViewRow selectionRow = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(selectionRow.Cells["Id"].Value);
            string nama = selectionRow.Cells["Nama"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Hapus data pasien '{nama}'?",
                "Konfirmasi hapus ",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // ↓ AMBIL DATA LENGKAP DULU SEBELUM HAPUS
                string gender = selectionRow.Cells["Gender"].Value?.ToString();
                string umur = selectionRow.Cells["Umur"].Value?.ToString();
                string darah = selectionRow.Cells["Gol darah"].Value?.ToString();
                string penyakit = selectionRow.Cells["Penyakit"].Value?.ToString();

                DatabaseHelper.HapusPasien(id);
                // ↓ TAMBAH DI SINI
                DatabaseHelper.TambahLog(
                    $"Admin menghapus pasien: Nama: \"{nama}\" | Gender: \"{gender}\" | " +
                    $"Umur: \"{umur}\" | Gol darah: \"{darah}\" | Penyakit: \"{penyakit}\""
                );
                MuatDataPasien();
                RefreshLog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit = true;
            label9.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Klik di header, abaikan
            if (!modeEdit) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Simpan Id row yang dipilih
            selectedId = Convert.ToInt32(row.Cells["Id"].Value);

            // Load data ke form
            txtNama.textBox.Text = row.Cells["Nama"].Value?.ToString();
            cbGender.SelectedItem = row.Cells["Gender"].Value?.ToString();
            txtUmur.textBox.Text = row.Cells["Umur"].Value?.ToString();
            txtDarah.textBox.Text = row.Cells["Gol darah"].Value?.ToString();
            txtPenyakit.textBox.Text = row.Cells["Penyakit"].Value?.ToString();

            // Ubah tombol Simpan menjadi mode Update
            Buttons2.Text = "Update";
            Buttons2.BackColor = Color.Orange;
            modeEdit = false;
            label9.Visible = false;
        }

        private void ResetModeEdit()
        {
            selectedId = -1;
            modeEdit = false;
            Buttons2.Text = "Simpan";
            Buttons2.BackColor = Color.Green; // Sesuaikan warna aslinya
        }

        private void BersihkanForm()
        {
            txtNama?.textBox?.Clear();
            txtUmur?.textBox?.Clear();
            txtDarah?.textBox?.Clear();
            txtPenyakit?.textBox?.Clear();
            cbGender.SelectedIndex = -1;
            txtNama?.textBox?.Focus();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tPria_Click(object sender, EventArgs e)
        {

        }


    }
}
