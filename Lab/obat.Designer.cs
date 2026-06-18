namespace Lab
{
    partial class obat
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(obat));
            shapedPanel1 = new ShapedPanel();
            cbjenis = new ReaLTaiizor.Controls.PoisonComboBox();
            label9 = new Label();
            btnEdit = new MyButtons();
            btnHapus = new MyButtons();
            label7 = new Label();
            btnSimpan = new MyButtons();
            label6 = new Label();
            txtpenyimpanan = new ReaLTaiizor.Controls.CyberTextBox();
            label5 = new Label();
            txtjumlah = new ReaLTaiizor.Controls.CyberTextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtobat = new ReaLTaiizor.Controls.CyberTextBox();
            dataGridView1 = new DataGridView();
            nama = new DataGridViewTextBoxColumn();
            jenis = new DataGridViewTextBoxColumn();
            jumlah = new DataGridViewTextBoxColumn();
            expired = new DataGridViewTextBoxColumn();
            rak = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            shapedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // shapedPanel1
            // 
            shapedPanel1.BackColor = SystemColors.ControlLightLight;
            shapedPanel1.BorderColor = Color.DimGray;
            shapedPanel1.Controls.Add(cbjenis);
            shapedPanel1.Controls.Add(label9);
            shapedPanel1.Controls.Add(btnEdit);
            shapedPanel1.Controls.Add(btnHapus);
            shapedPanel1.Controls.Add(label7);
            shapedPanel1.Controls.Add(btnSimpan);
            shapedPanel1.Controls.Add(label6);
            shapedPanel1.Controls.Add(txtpenyimpanan);
            shapedPanel1.Controls.Add(label5);
            shapedPanel1.Controls.Add(txtjumlah);
            shapedPanel1.Controls.Add(dateTimePicker1);
            shapedPanel1.Controls.Add(label4);
            shapedPanel1.Controls.Add(panel1);
            shapedPanel1.Controls.Add(pictureBox2);
            shapedPanel1.Controls.Add(label3);
            shapedPanel1.Controls.Add(label1);
            shapedPanel1.Controls.Add(label2);
            shapedPanel1.Controls.Add(txtobat);
            shapedPanel1.Edge = 40;
            shapedPanel1.Location = new Point(22, 90);
            shapedPanel1.Name = "shapedPanel1";
            shapedPanel1.Size = new Size(314, 470);
            shapedPanel1.TabIndex = 0;
            // 
            // cbjenis
            // 
            cbjenis.FormattingEnabled = true;
            cbjenis.ItemHeight = 23;
            cbjenis.Items.AddRange(new object[] { "Pereda nyeri", "Penurun panas", "Obat pencernaan", "Obat alergi", "Antiseptik", "Obat luka luar", "Obat gosok" });
            cbjenis.Location = new Point(21, 181);
            cbjenis.Name = "cbjenis";
            cbjenis.Size = new Size(154, 29);
            cbjenis.TabIndex = 30;
            cbjenis.UseSelectable = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display Semib", 11F);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(10, 383);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 28;
            label9.Text = "Edit Mode";
            label9.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.SkyBlue;
            btnEdit.BorderRadius = 10;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(109, 415);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(93, 40);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.DimGray;
            btnHapus.BorderRadius = 10;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(216, 415);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(87, 40);
            btnHapus.TabIndex = 26;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(10, 383);
            label7.Name = "label7";
            label7.Size = new Size(151, 20);
            label7.TabIndex = 25;
            label7.Text = "*Data harus lengkap";
            label7.Visible = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Orange;
            btnSimpan.BorderRadius = 10;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(10, 415);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(93, 40);
            btnSimpan.TabIndex = 24;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(25, 288);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 17;
            label6.Text = "Lokasi penyimpanan";
            // 
            // txtpenyimpanan
            // 
            txtpenyimpanan.Alpha = 20;
            txtpenyimpanan.BackColor = Color.Transparent;
            txtpenyimpanan.Background_WidthPen = 3F;
            txtpenyimpanan.BackgroundPen = true;
            txtpenyimpanan.ColorBackground = Color.White;
            txtpenyimpanan.ColorBackground_Pen = Color.DarkGray;
            txtpenyimpanan.ColorLighting = Color.FromArgb(29, 200, 238);
            txtpenyimpanan.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtpenyimpanan.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtpenyimpanan.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtpenyimpanan.Font = new Font("Arial", 10F);
            txtpenyimpanan.ForeColor = Color.FromArgb(41, 38, 38);
            txtpenyimpanan.Lighting = false;
            txtpenyimpanan.LinearGradientPen = false;
            txtpenyimpanan.Location = new Point(25, 309);
            txtpenyimpanan.Name = "txtpenyimpanan";
            txtpenyimpanan.PenWidth = 15;
            txtpenyimpanan.RGB = false;
            txtpenyimpanan.Rounding = true;
            txtpenyimpanan.RoundingInt = 20;
            txtpenyimpanan.Size = new Size(200, 40);
            txtpenyimpanan.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtpenyimpanan.TabIndex = 16;
            txtpenyimpanan.Tag = "Cyber";
            txtpenyimpanan.TextAlign = HorizontalAlignment.Left;
            txtpenyimpanan.TextButton = "";
            txtpenyimpanan.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtpenyimpanan.Timer_RGB = 300;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(198, 163);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 14;
            label5.Text = "Jumlah";
            // 
            // txtjumlah
            // 
            txtjumlah.Alpha = 20;
            txtjumlah.BackColor = Color.Transparent;
            txtjumlah.Background_WidthPen = 3F;
            txtjumlah.BackgroundPen = true;
            txtjumlah.ColorBackground = Color.White;
            txtjumlah.ColorBackground_Pen = Color.DarkGray;
            txtjumlah.ColorLighting = Color.FromArgb(29, 200, 238);
            txtjumlah.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtjumlah.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtjumlah.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtjumlah.Font = new Font("Arial", 9F);
            txtjumlah.ForeColor = Color.FromArgb(41, 38, 38);
            txtjumlah.Lighting = false;
            txtjumlah.LinearGradientPen = false;
            txtjumlah.Location = new Point(198, 181);
            txtjumlah.Name = "txtjumlah";
            txtjumlah.PenWidth = 15;
            txtjumlah.RGB = false;
            txtjumlah.Rounding = true;
            txtjumlah.RoundingInt = 20;
            txtjumlah.Size = new Size(72, 37);
            txtjumlah.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtjumlah.TabIndex = 13;
            txtjumlah.Tag = "Cyber";
            txtjumlah.TextAlign = HorizontalAlignment.Left;
            txtjumlah.TextButton = "";
            txtjumlah.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtjumlah.Timer_RGB = 300;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(25, 245);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(127, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(21, 163);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Jenis obat";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Location = new Point(16, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 1);
            panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(25, 227);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 6;
            label3.Text = "Tanggal expired";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(21, 81);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 5;
            label1.Text = "Nama obat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(59, 22);
            label2.Name = "label2";
            label2.Size = new Size(197, 20);
            label2.TabIndex = 4;
            label2.Text = "Form penginsian data obat";
            // 
            // txtobat
            // 
            txtobat.Alpha = 20;
            txtobat.BackColor = Color.Transparent;
            txtobat.Background_WidthPen = 3F;
            txtobat.BackgroundPen = true;
            txtobat.ColorBackground = Color.White;
            txtobat.ColorBackground_Pen = Color.DarkGray;
            txtobat.ColorLighting = Color.FromArgb(29, 200, 238);
            txtobat.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtobat.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtobat.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtobat.Font = new Font("Arial", 10F);
            txtobat.ForeColor = Color.FromArgb(41, 38, 38);
            txtobat.Lighting = false;
            txtobat.LinearGradientPen = false;
            txtobat.Location = new Point(21, 102);
            txtobat.Name = "txtobat";
            txtobat.PenWidth = 15;
            txtobat.RGB = false;
            txtobat.Rounding = true;
            txtobat.RoundingInt = 20;
            txtobat.Size = new Size(200, 40);
            txtobat.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtobat.TabIndex = 1;
            txtobat.Tag = "Cyber";
            txtobat.TextAlign = HorizontalAlignment.Left;
            txtobat.TextButton = "";
            txtobat.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtobat.Timer_RGB = 300;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nama, jenis, jumlah, expired, rak });
            dataGridView1.Location = new Point(362, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(542, 395);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // nama
            // 
            nama.HeaderText = "Nama";
            nama.Name = "nama";
            nama.ReadOnly = true;
            // 
            // jenis
            // 
            jenis.HeaderText = "Jenis";
            jenis.Name = "jenis";
            jenis.ReadOnly = true;
            // 
            // jumlah
            // 
            jumlah.HeaderText = "Jumlah";
            jumlah.Name = "jumlah";
            jumlah.ReadOnly = true;
            // 
            // expired
            // 
            expired.HeaderText = "Date Expired";
            expired.Name = "expired";
            expired.ReadOnly = true;
            // 
            // rak
            // 
            rak.HeaderText = "Lokasi penyimpanan";
            rak.Name = "rak";
            rak.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(728, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // obat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(shapedPanel1);
            Name = "obat";
            Size = new Size(934, 577);
            shapedPanel1.ResumeLayout(false);
            shapedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ShapedPanel shapedPanel1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.CyberTextBox txtobat;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private ReaLTaiizor.Controls.CyberTextBox txtjumlah;
        private Label label6;
        private ReaLTaiizor.Controls.CyberTextBox txtpenyimpanan;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn jenis;
        private DataGridViewTextBoxColumn jumlah;
        private DataGridViewTextBoxColumn expired;
        private DataGridViewTextBoxColumn rak;
        private Label label9;
        private MyButtons btnEdit;
        private MyButtons btnHapus;
        private Label label7;
        private MyButtons btnSimpan;
        private System.Windows.Forms.Timer timer1;
        private ReaLTaiizor.Controls.PoisonComboBox cbjenis;
    }
}
