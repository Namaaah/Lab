using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel; // Wajib untuk mendukung atribut Designer dan DefaultValue

namespace Lab
{
    public class MyButtons : Button
    {
        // Fields / Variabel Internal
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;

        // --- PROPERTI PUBLIK (Akses via Designer & Code Serialization) ---

        [Category("Custom Properties")]
        [Description("Mengatur ketebalan border button.")]
        [DefaultValue(0)] // Memastikan Designer tahu nilai default dan melakukan serialisasi saat berubah
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate(); // Menggambar ulang button secara real-time
            }
        }

        [Category("Custom Properties")]
        [Description("Mengatur radius kebulatan sudut button.")]
        [DefaultValue(20)]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }

        [Category("Custom Properties")]
        [Description("Mengatur warna border button.")]
        [DefaultValue(typeof(Color), "PaleVioletRed")] // Format khusus DefaultValue untuk tipe data Color
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        // Constructor
        public MyButtons()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        // Methods / Fungsi Pembentuk Path Rounded
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2F; // Menghitung diameter untuk AddArc

            path.StartFigure();

            // Pojok Kiri Atas
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);

            // Pojok Kanan Atas
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);

            // Pojok Kanan Bawah
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);

            // Pojok Kiri Bawah
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();

            return path;
        }

        // Menggambar Ulang Komponen
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Perbaikan 1: Terapkan SmoothingMode.AntiAlias di awal agar semua elemen halus
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Area untuk permukaan tombol (sama seperti sebelumnya)
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);

            // Perbaikan 2: Kalkulasi area border kustom untuk mengatasi pemotongan di sisi kanan
            // Kita hitung penyusutan (inset) berdasarkan ketebalan border.
            float rectBorderShrinkage = 0.5f; // Nilai dasar penyusutan
            if (borderSize >= 1)
            {
                // JIKA ada border, tambahkan penyusutan agar border tidak terpotong
                rectBorderShrinkage += (float)borderSize / 2f;
            }

            RectangleF rectBorder = new RectangleF(
                rectBorderShrinkage,
                rectBorderShrinkage,
                this.Width - (rectBorderShrinkage * 2F),
                this.Height - (rectBorderShrinkage * 2F));

            if (borderRadius > 2) // Kondisi untuk Button Bulat (Rounded)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))

                // Gunakan area rectBorder yang sudah dikecilkan (dihitung penyusutannya)
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius))

                // Pen ini digunakan untuk membuat tepi tombol asli tampak halus (HD)
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;

                    // Membuat fisik button melengkung sesuai path
                    this.Region = new Region(pathSurface);

                    // Menggambar permukaan border luar untuk hasil anti-alias yang halus (HD)
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // Menggambar border kustom jika ukuran border >= 1
                    if (borderSize >= 1)
                    {
                        // Gambar border kustom menggunakan pathBorder yang dikecilkan
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else // Kondisi untuk Button Kotak Normal
            {
                // Membuat fisik button kotak normal
                this.Region = new Region(rectSurface);

                // Menggambar border kustom kotak jika ukuran border >= 1
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.Parent != null)
            {
                this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
            }
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}