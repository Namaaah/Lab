using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab
{
    public class MyTextBox : UserControl
    {
        private TextBox textBox = new TextBox();

        private int borderRadius = 15;
        private Color borderColor = Color.Gray;
        private Color focusBorderColor = Color.DodgerBlue;
        private bool isFocused = false;

        public MyTextBox()
        {
            this.BackColor = Color.White;
            this.Padding = new Padding(10);

            textBox.BorderStyle = BorderStyle.None;
            textBox.Dock = DockStyle.Fill;

            textBox.Enter += (s, e) =>
            {
                isFocused = true;
                this.Invalidate();
            };

            textBox.Leave += (s, e) =>
            {
                isFocused = false;
                this.Invalidate();
            };

            this.Controls.Add(textBox);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;
            rect.Inflate(-1, -1);

            using (GraphicsPath path = GetRoundedRect(rect, borderRadius))
            using (Pen pen = new Pen(isFocused ? focusBorderColor : borderColor, 1.5f))
            {
                this.Region = new Region(path);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            return path;
        }

        // Optional: expose Text property
        public override string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }
    }
}