using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Lab
{
    public partial class Form1 : Form
    {    
        public Form1()
        {   
            InitializeComponent();
            pictureBox7.BringToFront();
        }

        private void myButtons1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void cyberTextBox3_Load(object sender, EventArgs e)
        {

        }

        private void Buttons2_Click(object sender, EventArgs e)
        {


            if (textBox1.TextButton.Trim() == "" && textBox2.TextButton.Trim() == "")
            {

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                label7.Visible = true;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseHelper.InitDatabase();

        }

        private void textBox1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox6.Visible = true;
            pictureBox6.BringToFront();
            textBox2.Password = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            pictureBox7.BringToFront();
            textBox2.Password = true;
        }
    }

}
