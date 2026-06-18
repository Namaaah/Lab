namespace Lab
{
    partial class Pasienv2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pasienv2));
            shapedPanel1 = new ShapedPanel();
            label9 = new Label();
            btnEdit = new MyButtons();
            btnHapus = new MyButtons();
            cbGender = new ReaLTaiizor.Controls.CyberComboBox();
            label6 = new Label();
            label5 = new Label();
            txtDarah = new ReaLTaiizor.Controls.CyberTextBox();
            Buttons2 = new MyButtons();
            label4 = new Label();
            txtPenyakit = new ReaLTaiizor.Controls.CyberTextBox();
            label3 = new Label();
            txtUmur = new ReaLTaiizor.Controls.CyberTextBox();
            label2 = new Label();
            label1 = new Label();
            txtNama = new ReaLTaiizor.Controls.CyberTextBox();
            dataGridView1 = new DataGridView();
            nama = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            umur = new DataGridViewTextBoxColumn();
            darah = new DataGridViewTextBoxColumn();
            penyakit = new DataGridViewTextBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            shapedPanel2 = new ShapedPanel();
            label8 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            shapedPanel3 = new ShapedPanel();
            tPria = new Label();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            shapedPanel4 = new ShapedPanel();
            tWanita = new Label();
            label12 = new Label();
            pictureBox3 = new PictureBox();
            shapedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            shapedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            shapedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            shapedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // shapedPanel1
            // 
            shapedPanel1.BackColor = Color.FromArgb(46, 125, 50);
            shapedPanel1.Controls.Add(label9);
            shapedPanel1.Controls.Add(btnEdit);
            shapedPanel1.Controls.Add(btnHapus);
            shapedPanel1.Controls.Add(cbGender);
            shapedPanel1.Controls.Add(label6);
            shapedPanel1.Controls.Add(label5);
            shapedPanel1.Controls.Add(txtDarah);
            shapedPanel1.Controls.Add(Buttons2);
            shapedPanel1.Controls.Add(label4);
            shapedPanel1.Controls.Add(txtPenyakit);
            shapedPanel1.Controls.Add(label3);
            shapedPanel1.Controls.Add(txtUmur);
            shapedPanel1.Controls.Add(label2);
            shapedPanel1.Controls.Add(label1);
            shapedPanel1.Controls.Add(txtNama);
            shapedPanel1.Location = new Point(15, 121);
            shapedPanel1.Name = "shapedPanel1";
            shapedPanel1.Size = new Size(342, 440);
            shapedPanel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display Semib", 11F);
            label9.ForeColor = Color.Aqua;
            label9.Location = new Point(22, 358);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 23;
            label9.Text = "Edit Mode";
            label9.Visible = false;
            label9.Click += label9_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.SkyBlue;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(125, 381);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 40);
            btnEdit.TabIndex = 22;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.DimGray;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(235, 381);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(92, 40);
            btnHapus.TabIndex = 21;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(22, 358);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 19;
            label6.Text = "*Data harus lengkap";
            label6.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(31, 212);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 18;
            label5.Text = "Golongan darah";
            // 
            // txtDarah
            // 
            txtDarah.Alpha = 20;
            txtDarah.BackColor = Color.Transparent;
            txtDarah.Background_WidthPen = 3F;
            txtDarah.BackgroundPen = true;
            txtDarah.ColorBackground = Color.FromArgb(129, 199, 132);
            txtDarah.ColorBackground_Pen = Color.ForestGreen;
            txtDarah.ColorLighting = Color.FromArgb(29, 200, 238);
            txtDarah.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtDarah.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtDarah.Cursor = Cursors.IBeam;
            txtDarah.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtDarah.Font = new Font("Arial Rounded MT Bold", 10F);
            txtDarah.ForeColor = Color.Black;
            txtDarah.Lighting = false;
            txtDarah.LinearGradientPen = false;
            txtDarah.Location = new Point(22, 230);
            txtDarah.Name = "txtDarah";
            txtDarah.PenWidth = 15;
            txtDarah.RGB = false;
            txtDarah.Rounding = true;
            txtDarah.RoundingInt = 30;
            txtDarah.Size = new Size(292, 40);
            txtDarah.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtDarah.TabIndex = 17;
            txtDarah.Tag = "Cyber";
            txtDarah.TextAlign = HorizontalAlignment.Left;
            txtDarah.TextButton = "";
            txtDarah.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtDarah.Timer_RGB = 300;
            // 
            // Buttons2
            // 
            Buttons2.BackColor = Color.Orange;
            Buttons2.FlatAppearance.BorderSize = 0;
            Buttons2.FlatStyle = FlatStyle.Flat;
            Buttons2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buttons2.ForeColor = Color.White;
            Buttons2.Location = new Point(12, 381);
            Buttons2.Name = "Buttons2";
            Buttons2.Size = new Size(98, 40);
            Buttons2.TabIndex = 16;
            Buttons2.Text = "Simpan";
            Buttons2.UseVisualStyleBackColor = false;
            Buttons2.Click += Buttons2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(31, 282);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "Penyakit";
            // 
            // txtPenyakit
            // 
            txtPenyakit.Alpha = 20;
            txtPenyakit.BackColor = Color.Transparent;
            txtPenyakit.Background_WidthPen = 3F;
            txtPenyakit.BackgroundPen = true;
            txtPenyakit.ColorBackground = Color.FromArgb(129, 199, 132);
            txtPenyakit.ColorBackground_Pen = Color.ForestGreen;
            txtPenyakit.ColorLighting = Color.FromArgb(29, 200, 238);
            txtPenyakit.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtPenyakit.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtPenyakit.Cursor = Cursors.IBeam;
            txtPenyakit.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtPenyakit.Font = new Font("Arial Rounded MT Bold", 10F);
            txtPenyakit.ForeColor = Color.Black;
            txtPenyakit.Lighting = false;
            txtPenyakit.LinearGradientPen = false;
            txtPenyakit.Location = new Point(22, 300);
            txtPenyakit.Name = "txtPenyakit";
            txtPenyakit.PenWidth = 15;
            txtPenyakit.RGB = false;
            txtPenyakit.Rounding = true;
            txtPenyakit.RoundingInt = 30;
            txtPenyakit.Size = new Size(292, 40);
            txtPenyakit.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtPenyakit.TabIndex = 8;
            txtPenyakit.Tag = "Cyber";
            txtPenyakit.TextAlign = HorizontalAlignment.Left;
            txtPenyakit.TextButton = "";
            txtPenyakit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtPenyakit.Timer_RGB = 300;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nama, gender, umur, darah, penyakit });
            dataGridView1.Location = new Point(381, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(543, 440);
            dataGridView1.TabIndex = 1;
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
            // darah
            // 
            darah.HeaderText = "Gol darah";
            darah.Name = "darah";
            darah.ReadOnly = true;
            // 
            // penyakit
            // 
            penyakit.HeaderText = "Penyakit";
            penyakit.Name = "penyakit";
            penyakit.ReadOnly = true;
            // 
            // timer1
            // 
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // shapedPanel2
            // 
            shapedPanel2.BorderColor = Color.FromArgb(0, 192, 0);
            shapedPanel2.Controls.Add(label8);
            shapedPanel2.Controls.Add(label7);
            shapedPanel2.Controls.Add(pictureBox1);
            shapedPanel2.Location = new Point(27, 24);
            shapedPanel2.Name = "shapedPanel2";
            shapedPanel2.Size = new Size(233, 78);
            shapedPanel2.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SeaGreen;
            label8.Location = new Point(64, 29);
            label8.Name = "label8";
            label8.Size = new Size(33, 37);
            label8.TabIndex = 2;
            label8.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(19, 9);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 1;
            label7.Text = "Jumlah pasien";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(144, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // shapedPanel3
            // 
            shapedPanel3.BorderColor = Color.FromArgb(0, 192, 0);
            shapedPanel3.Controls.Add(tPria);
            shapedPanel3.Controls.Add(label10);
            shapedPanel3.Controls.Add(pictureBox2);
            shapedPanel3.Location = new Point(364, 25);
            shapedPanel3.Name = "shapedPanel3";
            shapedPanel3.Size = new Size(233, 78);
            shapedPanel3.TabIndex = 3;
            // 
            // tPria
            // 
            tPria.AutoSize = true;
            tPria.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tPria.ForeColor = Color.SeaGreen;
            tPria.Location = new Point(64, 29);
            tPria.Name = "tPria";
            tPria.Size = new Size(33, 37);
            tPria.TabIndex = 2;
            tPria.Text = "0";
            tPria.Click += tPria_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(37, 9);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 1;
            label10.Text = "Jumlah pria";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(153, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // shapedPanel4
            // 
            shapedPanel4.BorderColor = Color.FromArgb(0, 192, 0);
            shapedPanel4.Controls.Add(tWanita);
            shapedPanel4.Controls.Add(label12);
            shapedPanel4.Controls.Add(pictureBox3);
            shapedPanel4.Location = new Point(679, 25);
            shapedPanel4.Name = "shapedPanel4";
            shapedPanel4.Size = new Size(233, 78);
            shapedPanel4.TabIndex = 4;
            // 
            // tWanita
            // 
            tWanita.AutoSize = true;
            tWanita.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tWanita.ForeColor = Color.SeaGreen;
            tWanita.Location = new Point(64, 29);
            tWanita.Name = "tWanita";
            tWanita.Size = new Size(33, 37);
            tWanita.TabIndex = 2;
            tWanita.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkGreen;
            label12.Location = new Point(19, 9);
            label12.Name = "label12";
            label12.Size = new Size(111, 20);
            label12.TabIndex = 1;
            label12.Text = "Jumlah wanita";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(151, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // Pasienv2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(shapedPanel4);
            Controls.Add(shapedPanel3);
            Controls.Add(shapedPanel2);
            Controls.Add(dataGridView1);
            Controls.Add(shapedPanel1);
            Name = "Pasienv2";
            Size = new Size(934, 577);
            shapedPanel1.ResumeLayout(false);
            shapedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            shapedPanel2.ResumeLayout(false);
            shapedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            shapedPanel3.ResumeLayout(false);
            shapedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            shapedPanel4.ResumeLayout(false);
            shapedPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ShapedPanel shapedPanel1;
        private DataGridView dataGridView1;
        private Label label1;
        private ReaLTaiizor.Controls.CyberTextBox txtNama;
        private Label label4;
        private ReaLTaiizor.Controls.CyberTextBox txtPenyakit;
        private Label label3;
        private ReaLTaiizor.Controls.CyberTextBox txtUmur;
        private Label label2;
        private MyButtons Buttons2;
        private Label label5;
        private ReaLTaiizor.Controls.CyberTextBox txtDarah;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn umur;
        private DataGridViewTextBoxColumn darah;
        private DataGridViewTextBoxColumn penyakit;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
        private ShapedPanel shapedPanel2;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label8;
        private ReaLTaiizor.Controls.CyberComboBox cbGender;
        private ShapedPanel shapedPanel3;
        private Label tPria;
        private Label label10;
        private PictureBox pictureBox2;
        private ShapedPanel shapedPanel4;
        private Label tWanita;
        private Label label12;
        private PictureBox pictureBox3;
        private MyButtons btnHapus;
        private MyButtons btnEdit;
        private Label label9;
    }
}
