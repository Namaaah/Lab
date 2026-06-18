using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Lab
{
    public class DatabaseHelper
    {
        private static string dbPath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory, "pasien.db");
        private static string connectionString = $"Data Source={dbPath};";
        private static string logPath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory, "activity_log.txt");

        // Buat tabel saat pertama kali
        public static void InitDatabase()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();

                // Tabel pasien
                string query = @"CREATE TABLE IF NOT EXISTS Pasien (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nama TEXT NOT NULL,
                Gender TEXT,
                Umur INTEGER,
                GolonganDarah TEXT,
                Penyakit TEXT
                )";
                using (var cmd = new SqliteCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                //tabel petugas
                string queryPetugas = @"CREATE TABLE IF NOT EXISTS Petugas (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nama TEXT NOT NULL,
                Gender TEXT,
                Umur INTEGER,
                Shift TEXT,
                Kelas TEXT
                )";

                using (var cmd = new SqliteCommand(queryPetugas, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // tabel obat 
                string queryObat = @"CREATE TABLE IF NOT EXISTS Obat (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                NamaObat TEXT NOT NULL,
                JenisObat TEXT,
                Jumlah INTEGER,
                TanggalExpired TEXT,
                LokasiPenyimpanan TEXT
                 )";
                using (var cmd = new SqliteCommand(queryObat, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                string queryLog = @"CREATE TABLE IF NOT EXISTS ActivityLog (
                  Id INTEGER PRIMARY KEY AUTOINCREMENT,
                  Waktu TEXT NOT NULL,
                  Keterangan TEXT NOT NULL
                )";
                using (var cmd = new SqliteCommand(queryLog, conn))
                    cmd.ExecuteNonQuery();


            }

        }


        // Simpan data pasien
        public static void SimpanPasien(string nama, string gender, int umur, string golDarah, string penyakit)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Pasien (Nama, Gender, Umur, GolonganDarah, Penyakit) VALUES (@nama, @gender, @umur, @golDarah, @penyakit)";
                using (var cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@umur", umur);
                    cmd.Parameters.AddWithValue("@golDarah", golDarah);
                    cmd.Parameters.AddWithValue("@penyakit", penyakit);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Ambil semua data pasien
        public static DataTable GetSemuaPasien()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, Nama, Gender, Umur, GolonganDarah AS 'Gol darah', Penyakit FROM Pasien";
                using (var cmd = new SqliteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
        }

        public static void HapusPasien(int id)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Pasien WHERE Id = @id";
                using (var cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdatePasien(int id, string nama, string gender, int umur, string golDarah, string penyakit)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE Pasien SET 
            Nama = @nama, 
            Gender = @gender, 
            Umur = @umur, 
            GolonganDarah = @golDarah, 
            Penyakit = @penyakit 
            WHERE Id = @id";
                using (var cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@umur", umur);
                    cmd.Parameters.AddWithValue("@golDarah", golDarah);
                    cmd.Parameters.AddWithValue("@penyakit", penyakit);
                    cmd.ExecuteNonQuery();
                }
            }

        }


        // Simpan data petugas
        public static void SimpanPetugas(string nama, string gender, int umur, string shift, string kelas)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Petugas (Nama, Gender, Umur, Shift, Kelas) VALUES (@nama, @gender, @umur, @shift, @kelas)";
                using (var cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@umur", umur);
                    cmd.Parameters.AddWithValue("@shift", shift);
                    cmd.Parameters.AddWithValue("@kelas", kelas);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Ambil semua data petugas
        public static DataTable GetSemuaPetugas()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, Nama, Gender, Umur, Shift, Kelas FROM Petugas";
                using (var cmd = new SqliteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
        }

        public static void HapusPetugas(int id)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Petugas WHERE Id = @id";
                using (var cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdatePetugas(int id, string nama, string gender, int umur, string shift, string kelas)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE Petugas SET 
            Nama = @nama, 
            Gender = @gender, 
            Umur = @umur, 
            Shift = @shift, 
            Kelas = @kelas 
            WHERE Id = @id";
                using (var cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@umur", umur);
                    cmd.Parameters.AddWithValue("@shift", shift);
                    cmd.Parameters.AddWithValue("@kelas", kelas);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SimpanObat(string namaObat, string jenisObat, int jumlah, string tanggalExpired, string lokasiPenyimpanan)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Obat (NamaObat, JenisObat, Jumlah, TanggalExpired, LokasiPenyimpanan) VALUES (@nama, @jenis, @jumlah, @expired, @lokasi)";
                using (var cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", namaObat);
                    cmd.Parameters.AddWithValue("@jenis", jenisObat);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@expired", tanggalExpired);
                    cmd.Parameters.AddWithValue("@lokasi", lokasiPenyimpanan);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Ambil semua obat
        public static DataTable GetSemuaObat()
        {
            var dt = new DataTable();
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, NamaObat AS 'Nama', JenisObat AS 'Jenis', Jumlah, TanggalExpired AS 'Date Expired', LokasiPenyimpanan AS 'Lokasi penyimpanan' FROM Obat";
                using (var cmd = new SqliteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        // Update obat
        public static void UpdateObat(int id, string namaObat, string jenisObat, int jumlah, string tanggalExpired, string lokasiPenyimpanan)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE Obat SET 
            NamaObat = @nama, JenisObat = @jenis, Jumlah = @jumlah, 
            TanggalExpired = @expired, LokasiPenyimpanan = @lokasi 
            WHERE Id = @id";
                using (var cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nama", namaObat);
                    cmd.Parameters.AddWithValue("@jenis", jenisObat);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@expired", tanggalExpired);
                    cmd.Parameters.AddWithValue("@lokasi", lokasiPenyimpanan);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Hapus obat
        public static void HapusObat(int id)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Obat WHERE Id = @id";
                using (var cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Tambah log
        public static void TambahLog(string keterangan)
        {
            string isiLog = $"[{DateTime.Now:dd/MM/yyyy HH:mm}]  {keterangan}";
            File.AppendAllText(logPath, isiLog, Encoding.UTF8);
        }

        // Ambil semua log (terbaru di atas)
        public static List<string> GetActivityLog()
        {
            if (!File.Exists(logPath))
                return new List<string>();

            // Baca semua baris, balik urutannya agar terbaru di atas
            string[] lines = File.ReadAllLines(logPath, Encoding.UTF8);
            var logs = new List<string>(lines);

            return logs;
        }

        public static Dictionary<string, int> GetTotalPerJenisObat()
        {
            var result = new Dictionary<string, int>();
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT JenisObat, SUM(Jumlah) as Total FROM Obat GROUP BY JenisObat";
                using (var cmd = new SqliteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string jenis = reader["JenisObat"]?.ToString() ?? "Lainnya";
                        int total = Convert.ToInt32(reader["Total"]);
                        result[jenis] = total;
                    }
                }
            }
            return result;
        }
        public static void ClearLog()
        {
            if (File.Exists(logPath))
                File.WriteAllText(logPath, string.Empty, Encoding.UTF8);
        }


    }
}
