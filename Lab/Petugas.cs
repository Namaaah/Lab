using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab
{
    public partial class Petugas : UserControl
    {
        int kedip = 0;
        int selectedId = -1; // penympanan id pasien untuk di edit 
        bool modeEdit = false;
        private Dashboard _dashboard;

        public Petugas(Dashboard dashboard = null)
        {
            InitializeComponent();
            _dashboard = dashboard;
            DatabaseHelper.InitDatabase(); 
            MuatDataPetugas();              
        }

        private void RefreshLog()
        {
            _dashboard?.RefreshDashboard();
        }



        public void MuatDataPetugas()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            DataTable dt = DatabaseHelper.GetSemuaPetugas();
            dataGridView1.DataSource = dt;

            // Sembunyikan kolom Id DULU sebelum hitung apapun
            if (dataGridView1.Columns["Id"] != null)
                dataGridView1.Columns["Id"].Visible = false;

            // Hitung langsung dari DataTable, bukan dari datagrid
            int pagi = 0;
            int siang = 0;
            int sore = 0;
            foreach (DataRow row in dt.Rows)
            {
                string jadwalShift = row["Shift"]?.ToString().ToUpper() ?? "";
                if (jadwalShift == "PAGI") pagi++;
                if (jadwalShift == "SIANG") siang++;
                if (jadwalShift == "SORE") sore++;
            }

            PAGI.Text = pagi.ToString();
            SIANG.Text = siang.ToString();
            SORE.Text = sore.ToString();
        }
        private void Buttons2_Click_1(object sender, EventArgs e)
        {
            string nama = txtNama?.textBox?.Text ?? string.Empty;
            string gender = cbGender?.SelectedItem?.ToString() ?? string.Empty;
            string umur = txtUmur?.textBox?.Text ?? string.Empty;
            string shift = cbShift?.SelectedItem?.ToString() ?? string.Empty;
            string kelas = txtKelas?.textBox?.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(umur) || string.IsNullOrWhiteSpace(shift) ||
                string.IsNullOrWhiteSpace(kelas))
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
                DatabaseHelper.SimpanPetugas(nama, gender, umurInt, shift, kelas);
                // ↓ TAMBAH DI SINI
                DatabaseHelper.TambahLog(
                    $"Admin menambahkan petugas: Nama: \"{nama}\" | Gender: \"{gender}\" | " +
                    $"Umur: \"{umurInt}\" | Shift: \"{shift}\" | Kelas: \"{kelas}\""
                );
            }
            else
            {
                // ↓ AMBIL DATA LAMA DULU
                string namaLama = dataGridView1.SelectedRows[0].Cells["Nama"].Value?.ToString();
                string genderLama = dataGridView1.SelectedRows[0].Cells["Gender"].Value?.ToString();
                string umurLama = dataGridView1.SelectedRows[0].Cells["Umur"].Value?.ToString();
                string shiftLama = dataGridView1.SelectedRows[0].Cells["Shift"].Value?.ToString();
                string kelasLama = dataGridView1.SelectedRows[0].Cells["Kelas"].Value?.ToString();

                DatabaseHelper.UpdatePetugas(selectedId, nama, gender, umurInt, shift, kelas);
                // ↓ TAMBAH DI SINI
                DatabaseHelper.TambahLog(
                    $"Admin mengubah petugas: Nama: \"{namaLama}\" → \"{nama}\" | " +
                    $"Gender: \"{genderLama}\" → \"{gender}\" | Umur: \"{umurLama}\" → \"{umurInt}\" | " +
                    $"Shift: \"{shiftLama}\" → \"{shift}\" | Kelas: \"{kelasLama}\" → \"{kelas}\""
                );
                ResetModeEdit();
            }
            MuatDataPetugas();
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

     

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeEdit = true;
            label9.Visible = true;
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
            cbShift.SelectedIndex = -1;
            txtKelas?.textBox?.Clear();
            cbGender.SelectedIndex = -1;
            txtNama?.textBox?.Focus();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
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
            cbShift.SelectedItem = row.Cells["Shift"].Value?.ToString();
            txtKelas.textBox.Text = row.Cells["Kelas"].Value?.ToString();

            // Ubah tombol Simpan menjadi mode Update
            Buttons2.Text = "Update";
            Buttons2.BackColor = Color.Orange;
            modeEdit = false;
            label9.Visible = false;
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih petugas yang akan dihapus.");
                return;
            }

            DataGridViewRow selectionRow = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(selectionRow.Cells["Id"].Value);
            string nama = selectionRow.Cells["Nama"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Hapus data petugas '{nama}'?",
                "Konfirmasi hapus ",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
              
                string gender = selectionRow.Cells["Gender"].Value?.ToString();
                string umur = selectionRow.Cells["Umur"].Value?.ToString();
                string shift = selectionRow.Cells["Shift"].Value?.ToString();
                string kelas = selectionRow.Cells["Kelas"].Value?.ToString();

                DatabaseHelper.HapusPetugas(id);
              
                DatabaseHelper.TambahLog(
                    $"Admin menghapus petugas: Nama: \"{nama}\" | Gender: \"{gender}\" | " +
                    $"Umur: \"{umur}\" | Shift: \"{shift}\" | Kelas: \"{kelas}\""
                );

                MessageBox.Show($"_dashboard null? {_dashboard == null}");

                MuatDataPetugas();
                RefreshLog();
            }
        }
    }
}

