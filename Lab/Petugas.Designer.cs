namespace Lab
{
    partial class Petugas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Petugas));
            shapedPanel3 = new ShapedPanel();
            pictureBox2 = new PictureBox();
            SIANG = new Label();
            label10 = new Label();
            shapedPanel2 = new ShapedPanel();
            PAGI = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            nama = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            umur = new DataGridViewTextBoxColumn();
            shift = new DataGridViewTextBoxColumn();
            kelas = new DataGridViewTextBoxColumn();
            shapedPanel1 = new ShapedPanel();
            label9 = new Label();
            btnEdit = new MyButtons();
            btnHapus = new MyButtons();
            label6 = new Label();
            Buttons2 = new MyButtons();
            cbShift = new ReaLTaiizor.Controls.CyberComboBox();
            cbGender = new ReaLTaiizor.Controls.CyberComboBox();
            label5 = new Label();
            label4 = new Label();
            txtKelas = new ReaLTaiizor.Controls.CyberTextBox();
            label3 = new Label();
            txtUmur = new ReaLTaiizor.Controls.CyberTextBox();
            label2 = new Label();
            label1 = new Label();
            txtNama = new ReaLTaiizor.Controls.CyberTextBox();
            shapedPanel4 = new ShapedPanel();
            pictureBox3 = new PictureBox();
            SORE = new Label();
            label11 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            shapedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            shapedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            shapedPanel1.SuspendLayout();
            shapedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // shapedPanel3
            // 
            shapedPanel3.BorderColor = Color.FromArgb(0, 192, 0);
            shapedPanel3.Controls.Add(pictureBox2);
            shapedPanel3.Controls.Add(SIANG);
            shapedPanel3.Controls.Add(label10);
            shapedPanel3.Location = new Point(365, 20);
            shapedPanel3.Name = "shapedPanel3";
            shapedPanel3.Size = new Size(233, 78);
            shapedPanel3.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(143, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // SIANG
            // 
            SIANG.AutoSize = true;
            SIANG.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SIANG.ForeColor = Color.SeaGreen;
            SIANG.Location = new Point(64, 29);
            SIANG.Name = "SIANG";
            SIANG.Size = new Size(33, 37);
            SIANG.TabIndex = 2;
            SIANG.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(37, 9);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 1;
            label10.Text = "Shift siang";
            // 
            // shapedPanel2
            // 
            shapedPanel2.BorderColor = Color.FromArgb(0, 192, 0);
            shapedPanel2.Controls.Add(PAGI);
            shapedPanel2.Controls.Add(label7);
            shapedPanel2.Controls.Add(pictureBox1);
            shapedPanel2.Location = new Point(29, 20);
            shapedPanel2.Name = "shapedPanel2";
            shapedPanel2.Size = new Size(233, 78);
            shapedPanel2.TabIndex = 6;
            // 
            // PAGI
            // 
            PAGI.AutoSize = true;
            PAGI.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PAGI.ForeColor = Color.SeaGreen;
            PAGI.Location = new Point(64, 29);
            PAGI.Name = "PAGI";
            PAGI.Size = new Size(33, 37);
            PAGI.TabIndex = 2;
            PAGI.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(39, 9);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 1;
            label7.Text = "Shift pagi";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(131, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nama, gender, umur, shift, kelas });
            dataGridView1.Location = new Point(381, 121);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(543, 440);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // nama
            // 
            nama.HeaderText = "Nama";
            nama.Name = "nama";
            nama.ReadOnly = true;
            // 
            // gender
            // 
            gender.HeaderText = "Gender";
            gender.Name = "gender";
            gender.ReadOnly = true;
            // 
            // umur
            // 
            umur.HeaderText = "Umur";
            umur.Name = "umur";
            umur.ReadOnly = true;
            // 
            // shift
            // 
            shift.HeaderText = "Shift";
            shift.Name = "shift";
            shift.ReadOnly = true;
            // 
            // kelas
            // 
            kelas.HeaderText = "Kelas";
            kelas.Name = "kelas";
            kelas.ReadOnly = true;
            // 
            // shapedPanel1
            // 
            shapedPanel1.BackColor = Color.FromArgb(46, 125, 50);
            shapedPanel1.Controls.Add(label9);
            shapedPanel1.Controls.Add(btnEdit);
            shapedPanel1.Controls.Add(btnHapus);
            shapedPanel1.Controls.Add(label6);
            shapedPanel1.Controls.Add(Buttons2);
            shapedPanel1.Controls.Add(cbShift);
            shapedPanel1.Controls.Add(cbGender);
            shapedPanel1.Controls.Add(label5);
            shapedPanel1.Controls.Add(label4);
            shapedPanel1.Controls.Add(txtKelas);
            shapedPanel1.Controls.Add(label3);
            shapedPanel1.Controls.Add(txtUmur);
            shapedPanel1.Controls.Add(label2);
            shapedPanel1.Controls.Add(label1);
            shapedPanel1.Controls.Add(txtNama);
            shapedPanel1.Location = new Point(17, 117);
            shapedPanel1.Name = "shapedPanel1";
            shapedPanel1.Size = new Size(338, 440);
            shapedPanel1.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display Semib", 11F);
            label9.ForeColor = Color.Aqua;
            label9.Location = new Point(18, 359);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 28;
            label9.Text = "Edit Mode";
            label9.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.SkyBlue;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(121, 382);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 40);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.DimGray;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(231, 382);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(92, 40);
            btnHapus.TabIndex = 26;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(18, 359);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 25;
            label6.Text = "*Data harus lengkap";
            label6.Visible = false;
            // 
            // Buttons2
            // 
            Buttons2.BackColor = Color.Orange;
            Buttons2.FlatAppearance.BorderSize = 0;
            Buttons2.FlatStyle = FlatStyle.Flat;
            Buttons2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buttons2.ForeColor = Color.White;
            Buttons2.Location = new Point(8, 382);
            Buttons2.Name = "Buttons2";
            Buttons2.Size = new Size(98, 40);
            Buttons2.TabIndex = 24;
            Buttons2.Text = "Simpan";
            Buttons2.UseVisualStyleBackColor = false;
            Buttons2.Click += Buttons2_Click_1;
            // 
            // cbShift
            // 
            cbShift.BackColor = Color.FromArgb(129, 199, 132);
            cbShift.ColorArrow = Color.Green;
            cbShift.ColorBackground = Color.FromArgb(129, 199, 132);
            cbShift.ColorBackground_Pen = Color.FromArgb(129, 199, 132);
            cbShift.ColorItemHover = Color.Transparent;
            cbShift.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cbShift.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cbShift.CyberComboBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cbShift.DrawMode = DrawMode.OwnerDrawFixed;
            cbShift.DropDownStyle = ComboBoxStyle.DropDownList;
            cbShift.FlatStyle = FlatStyle.Flat;
            cbShift.Font = new Font("Arial Rounded MT Bold", 10F);
            cbShift.ForeColor = Color.Black;
            cbShift.FormattingEnabled = true;
            cbShift.ItemHeight = 28;
            cbShift.Items.AddRange(new object[] { "Pagi", "Siang", "Sore" });
            cbShift.Location = new Point(22, 230);
            cbShift.Name = "cbShift";
            cbShift.RGB = false;
            cbShift.RoundingInt = 20;
            cbShift.Size = new Size(292, 34);
            cbShift.TabIndex = 21;
            cbShift.Timer_RGB = 300;
            // 
            // cbGender
            // 
            cbGender.BackColor = Color.FromArgb(129, 199, 132);
            cbGender.ColorArrow = Color.Green;
            cbGender.ColorBackground = Color.FromArgb(129, 199, 132);
            cbGender.ColorBackground_Pen = Color.FromArgb(129, 199, 132);
            cbGender.ColorItemHover = Color.Transparent;
            cbGender.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cbGender.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cbGender.CyberComboBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cbGender.DrawMode = DrawMode.OwnerDrawFixed;
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FlatStyle = FlatStyle.Flat;
            cbGender.Font = new Font("Arial Rounded MT Bold", 10F);
            cbGender.ForeColor = Color.Black;
            cbGender.FormattingEnabled = true;
            cbGender.ItemHeight = 28;
            cbGender.Items.AddRange(new object[] { "Male", "Female", "Croisant" });
            cbGender.Location = new Point(22, 100);
            cbGender.Name = "cbGender";
            cbGender.RGB = false;
            cbGender.RoundingInt = 20;
            cbGender.Size = new Size(292, 34);
            cbGender.TabIndex = 20;
            cbGender.Timer_RGB = 300;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(31, 212);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 18;
            label5.Text = "Shift";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(31, 282);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "Kelas";
            // 
            // txtKelas
            // 
            txtKelas.Alpha = 20;
            txtKelas.BackColor = Color.Transparent;
            txtKelas.Background_WidthPen = 3F;
            txtKelas.BackgroundPen = true;
            txtKelas.ColorBackground = Color.FromArgb(129, 199, 132);
            txtKelas.ColorBackground_Pen = Color.ForestGreen;
            txtKelas.ColorLighting = Color.FromArgb(29, 200, 238);
            txtKelas.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtKelas.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtKelas.Cursor = Cursors.IBeam;
            txtKelas.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtKelas.Font = new Font("Arial Rounded MT Bold", 10F);
            txtKelas.ForeColor = Color.Black;
            txtKelas.Lighting = false;
            txtKelas.LinearGradientPen = false;
            txtKelas.Location = new Point(22, 300);
            txtKelas.Name = "txtKelas";
            txtKelas.PenWidth = 15;
            txtKelas.RGB = false;
            txtKelas.Rounding = true;
            txtKelas.RoundingInt = 30;
            txtKelas.Size = new Size(292, 40);
            txtKelas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtKelas.TabIndex = 8;
            txtKelas.Tag = "Cyber";
            txtKelas.TextAlign = HorizontalAlignment.Left;
            txtKelas.TextButton = "";
            txtKelas.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtKelas.Timer_RGB = 300;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(31, 145);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Umur";
            // 
            // txtUmur
            // 
            txtUmur.Alpha = 20;
            txtUmur.BackColor = Color.Transparent;
            txtUmur.Background_WidthPen = 3F;
            txtUmur.BackgroundPen = true;
            txtUmur.ColorBackground = Color.FromArgb(129, 199, 132);
            txtUmur.ColorBackground_Pen = Color.ForestGreen;
            txtUmur.ColorLighting = Color.FromArgb(29, 200, 238);
            txtUmur.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtUmur.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtUmur.Cursor = Cursors.IBeam;
            txtUmur.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtUmur.Font = new Font("Arial Rounded MT Bold", 10F);
            txtUmur.ForeColor = Color.Black;
            txtUmur.Lighting = false;
            txtUmur.LinearGradientPen = false;
            txtUmur.Location = new Point(22, 163);
            txtUmur.Name = "txtUmur";
            txtUmur.PenWidth = 15;
            txtUmur.RGB = false;
            txtUmur.Rounding = true;
            txtUmur.RoundingInt = 30;
            txtUmur.Size = new Size(292, 40);
            txtUmur.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtUmur.TabIndex = 6;
            txtUmur.Tag = "Cyber";
            txtUmur.TextAlign = HorizontalAlignment.Left;
            txtUmur.TextButton = "";
            txtUmur.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtUmur.Timer_RGB = 300;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(31, 82);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Gender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(31, 14);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.Alpha = 20;
            txtNama.BackColor = Color.Transparent;
            txtNama.Background_WidthPen = 3F;
            txtNama.BackgroundPen = true;
            txtNama.ColorBackground = Color.FromArgb(129, 199, 132);
            txtNama.ColorBackground_Pen = Color.ForestGreen;
            txtNama.ColorLighting = Color.FromArgb(29, 200, 238);
            txtNama.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtNama.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtNama.Cursor = Cursors.IBeam;
            txtNama.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtNama.Font = new Font("Arial Rounded MT Bold", 10F);
            txtNama.ForeColor = Color.Black;
            txtNama.Lighting = false;
            txtNama.LinearGradientPen = false;
            txtNama.Location = new Point(22, 32);
            txtNama.Name = "txtNama";
            txtNama.PenWidth = 15;
            txtNama.RGB = false;
            txtNama.Rounding = true;
            txtNama.RoundingInt = 30;
            txtNama.Size = new Size(292, 40);
            txtNama.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNama.TabIndex = 2;
            txtNama.Tag = "Cyber";
            txtNama.TextAlign = HorizontalAlignment.Left;
            txtNama.TextButton = "";
            txtNama.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNama.Timer_RGB = 300;
            // 
            // shapedPanel4
            // 
            shapedPanel4.BorderColor = Color.FromArgb(0, 192, 0);
            shapedPanel4.Controls.Add(pictureBox3);
            shapedPanel4.Controls.Add(SORE);
            shapedPanel4.Controls.Add(label11);
            shapedPanel4.Location = new Point(677, 20);
            shapedPanel4.Name = "shapedPanel4";
            shapedPanel4.Size = new Size(233, 78);
            shapedPanel4.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(131, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(90, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // SORE
            // 
            SORE.AutoSize = true;
            SORE.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SORE.ForeColor = Color.SeaGreen;
            SORE.Location = new Point(64, 29);
            SORE.Name = "SORE";
            SORE.Size = new Size(33, 37);
            SORE.TabIndex = 2;
            SORE.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(37, 9);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 1;
            label11.Text = "Shift sore";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // Petugas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(shapedPanel4);
            Controls.Add(shapedPanel3);
            Controls.Add(shapedPanel2);
            Controls.Add(dataGridView1);
            Controls.Add(shapedPanel1);
            Name = "Petugas";
            Size = new Size(934, 577);
            shapedPanel3.ResumeLayout(false);
            shapedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            shapedPanel2.ResumeLayout(false);
            shapedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            shapedPanel1.ResumeLayout(false);
            shapedPanel1.PerformLayout();
            shapedPanel4.ResumeLayout(false);
            shapedPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ShapedPanel shapedPanel3;
        private Label SIANG;
        private Label label10;
        private ShapedPanel shapedPanel2;
        private Label PAGI;
        private Label label7;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn umur;
        private DataGridViewTextBoxColumn shift;
        private DataGridViewTextBoxColumn kelas;
        private ShapedPanel shapedPanel1;
        private ReaLTaiizor.Controls.CyberComboBox cbGender;
        private Label label5;
        private Label label4;
        private ReaLTaiizor.Controls.CyberTextBox txtKelas;
        private Label label3;
        private ReaLTaiizor.Controls.CyberTextBox txtUmur;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.CyberTextBox txtNama;
        private ShapedPanel shapedPanel4;
        private Label SORE;
        private Label label11;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.CyberComboBox cbShift;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private Label label9;
        private MyButtons btnEdit;
        private MyButtons btnHapus;
        private Label label6;
        private MyButtons Buttons2;
    }
}
