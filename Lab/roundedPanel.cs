using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab
{
    public class ShapedPanel : Panel
    {
        private Color _borderColor = Color.White;
        private int _edge = 50;
        private float _borderWidth = 2.0f; // ← baru

        private Pen pen;

        public ShapedPanel()
        {
            pen = new Pen(_borderColor, _borderWidth);
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                pen?.Dispose();
                pen = null;
            }
            base.Dispose(disposing);
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Color of the border.")]
        [DefaultValue(typeof(Color), "White")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                if (_borderColor == value) return;
                _borderColor = value;
                RecreatePen(); // ← pakai helper
                Invalidate();
            }
        }

        public bool ShouldSerializeBorderColor() => _borderColor != Color.White;
        public void ResetBorderColor() => BorderColor = Color.White;

        // ─── Property baru ───────────────────────────────────────────
        [Browsable(true)]
        [Category("Appearance")]
        [Description("Thickness of the border in pixels.")]
        [DefaultValue(2.0f)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float BorderWidth
        {
            get { return _borderWidth; }
            set
            {
                if (_borderWidth == value) return;
                _borderWidth = Math.Max(0.1f, value); // minimal 0.1
                RecreatePen();
                Invalidate();
            }
        }

        public bool ShouldSerializeBorderWidth() => _borderWidth != 2.0f;
        public void ResetBorderWidth() => BorderWidth = 2.0f;
        // ─────────────────────────────────────────────────────────────

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Radius of the rounded corners.")]
        [DefaultValue(50)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Edge
        {
            get { return _edge; }
            set
            {
                if (_edge == value) return;
                _edge = value;
                Invalidate();
            }
        }

        public bool ShouldSerializeEdge() => _edge != 50;
        public void ResetEdge() => Edge = 50;

        // Helper recreate pen pakai color + width terbaru
        private void RecreatePen()
        {
            pen?.Dispose();
            pen = new Pen(_borderColor, _borderWidth);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ExtendedDraw(e);
            DrawBorder(e.Graphics);
        }

        private Rectangle GetLeftUpper(int e) => new Rectangle(0, 0, e, e);
        private Rectangle GetRightUpper(int e) => new Rectangle(Width - e, 0, e, e);
        private Rectangle GetRightLower(int e) => new Rectangle(Width - e, Height - e, e, e);
        private Rectangle GetLeftLower(int e) => new Rectangle(0, Height - e, e, e);

        private void ExtendedDraw(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(GetLeftUpper(Edge), 180, 90);
                path.AddLine(Edge, 0, Width - Edge, 0);
                path.AddArc(GetRightUpper(Edge), 270, 90);
                path.AddLine(Width, Edge, Width, Height - Edge);
                path.AddArc(GetRightLower(Edge), 0, 90);
                path.AddLine(Width - Edge, Height, Edge, Height);
                path.AddArc(GetLeftLower(Edge), 90, 90);
                path.AddLine(0, Height - Edge, 0, Edge);
                path.CloseFigure();
                Region = new Region(path);
            }
        }

        private void DrawSingleBorder(Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            graphics.DrawArc(pen, new Rectangle(0, 0, Edge, Edge), 180, 90);
            graphics.DrawArc(pen, new Rectangle(Width - Edge - 1, 0, Edge, Edge), 270, 90);
            graphics.DrawArc(pen, new Rectangle(Width - Edge - 1, Height - Edge - 1, Edge, Edge), 0, 90);
            graphics.DrawArc(pen, new Rectangle(0, Height - Edge - 1, Edge, Edge), 90, 90);
            graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
        }

        private void DrawBorder(Graphics graphics) => DrawSingleBorder(graphics);
    }
}