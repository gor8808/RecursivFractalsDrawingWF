using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursivFractalsDrawing
{
    public partial class Form1 : Form
    {
        Color colorForDrawing;

        public Form1()
        {
            InitializeComponent();
            colorForDrawing = Color.Green;
            foreach (MenuItem item in mainMenu1.MenuItems)
            {
                item.Visible = false;
            }
            ResetUIValues();
        }

        private void ResetUIValues()
        {
            ResetBinaryTree_Click(null, null);
            ResetTimeTables_Click(null, null);
        }

        private void SelectDrawingColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorForDrawing = colorDialog1.Color;
            }
        }
        private void SelectBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BinarytreePicCanvas.BackColor = colorDialog1.Color;
            }
        }
        private void TimeTables_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.Clear(BinarytreePicCanvas.BackColor);
            gr.SmoothingMode = SmoothingMode.AntiAlias;


            int.TryParse(CircleR.Text, out int r);
            float diametre = 2 * r;
            float.TryParse(MultiplyScale.Text, out float multiplyScale);
            int n = (int)PointsCount.Value;
            float angleScale = (float)Math.PI * 2 / n;
            float.TryParse(XMinTimeTable.Text, out float xmin);
            float.TryParse(YMinTimeTable.Text, out float ymin);
            float.TryParse(XMaxTimeTable.Text, out float xmax);
            float.TryParse(YMaxTimeTable.Text, out float ymax);


            Pen pen = new Pen(Brushes.White);
            float height = TimestablesPicCanvas.Height;
            float width = TimestablesPicCanvas.Height;
            RectangleF rect = new RectangleF(
                    xmin, ymin, xmax - xmin, ymax - ymin);
            PointF[] pts =
            {
                    new PointF(0, height),
                    new PointF(width, height),
                    new PointF(0, 0),
                };
            gr.Transform = new Matrix(rect, pts);

            pen.Color = Color.Red;
            gr.DrawLine(pen, xmin, 0, xmax, 0);
            gr.DrawLine(pen, 0, ymin, 0, ymax);
            for (int x = (int)xmin; x <= xmax; x++)
            {
                gr.DrawLine(pen, x, -0.1f, x, 0.1f);
            }
            for (int y = (int)ymin; y <= ymax; y++)
            {
                gr.DrawLine(pen, -0.1f, y, 0.1f, y);
            }
            pen.Color = Color.White;
            BinarytreePicCanvas.BackColor = Color.Black;
            gr.DrawEllipse(pen, 0 - r, 0 - r, diametre, diametre);

            List<PointF> points = new List<PointF>();
            float angle = (float)Math.PI;
            PointF centre = new PointF(0, 0);
            for (int i = 0; i < n; i++)
            {
                points.Add(GetPointByLengthAndAngle(centre, r, angle));
                angle += angleScale;
            }
            pen.Color = colorForDrawing;
            DrawTableLines(n, points, multiplyScale, 0, gr, pen);
        }

        private void DrawTableLines(int n, List<PointF> points, float multiplyScale, int i, Graphics gr, Pen pen)
        {
            if (i < n)
            {
                float multiplyResult = 0;
                if (i * multiplyScale >= n)
                {
                    multiplyResult = (i * multiplyScale) - n;
                    while (multiplyResult >= n)
                    {
                        multiplyResult -= n;
                    }
                }
                else
                {
                    multiplyResult = i * multiplyScale;
                }
                gr.DrawLine(pen, points[i], points[(int)multiplyResult]);
                i++;
                DrawTableLines(n, points, multiplyScale, i, gr, pen);
            }
            else
            {
                return;
            }
        }

        private void BinaryTree_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BinarytreePicCanvas.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            PointF root = new PointF(BinarytreePicCanvas.ClientSize.Width / 2, BinarytreePicCanvas.ClientSize.Height - 4);
            float.TryParse(LengthScaleValue.Text, out float lengthScale);
            int deep = (int)DeepValue.Value;
            float angleScale = (float)(Math.PI / 180f * (float)AngleScaleValue.Value);
            float length = (float)LengthValue.Value;
            Pen pen = new Pen(colorForDrawing, 1);
            DrawBranch(e.Graphics, pen, deep, root, length, (float)Math.PI / -2, lengthScale, angleScale);
        }
        private void DrawBranch(Graphics gr, Pen pen, int deep, PointF p1, float length, float angle, float lengthScale, float angleScale)
        {
            PointF point = new PointF((float)(p1.X + length * Math.Cos(angle)), (float)(p1.Y + length * Math.Sin(angle)));
            gr.DrawLine(pen, p1, point);
            if (deep > 1)
            {
                DrawBranch(gr, pen, deep - 1, point, length * lengthScale, angle + angleScale, lengthScale, angleScale);
                DrawBranch(gr, pen, deep - 1, point, length * lengthScale, angle - angleScale, lengthScale, angleScale);
            }
        }
        private PointF GetPointByLengthAndAngle(PointF p1, float length, float angle)
        {
            return new PointF((float)(p1.X + Math.Cos(angle) * length), (float)(p1.Y + Math.Sin(angle) * length));
        }
        private void ResetBinaryTree_Click(object sender, EventArgs e)
        {
            LengthValue.Value = 100;
            LengthScaleValue.Text = "0.6";
            DeepValue.Value = 10;
            AngleScaleValue.Value = 35;
            colorForDrawing = Color.Green;
            BinarytreePicCanvas.BackColor = Color.White;
        }

        private void BinaryTree_ValueChanged(object sender, EventArgs e)
        {
            BinarytreePicCanvas.Refresh();
        }

        private void ResetTimeTables_Click(object sender, EventArgs e)
        {
            PointsCount.Value = 100;
            MultiplyScale.Text = "2";
            CircleR.Text = "50";
            XMinTimeTable.Text = "-60";
            XMaxTimeTable.Text = "60";
            YMinTimeTable.Text = "-60";
            YMaxTimeTable.Text = "60";
            colorForDrawing = Color.Green;
            TimestablesPicCanvas.BackColor = Color.White;
            TimestablesPicCanvas.Refresh();
        }

        private void TimeTables_ValueChanged(object sender, EventArgs e)
        {
            TimestablesPicCanvas.Refresh();
        }
        private void EnterHome_Click(object sender, EventArgs e)
        {
            string setType = string.Empty;
            if (FractalType.SelectedItem == null)
            {
                setType = "Binarytree";
            }
            else
            {
                setType = FractalType.SelectedItem.ToString().Replace(" ", string.Empty);
            }
            foreach (Panel p in Controls)
            {
                p.Visible = false;
            }
            foreach (MenuItem item in mainMenu1.MenuItems)
            {
                item.Visible = true;
            }
            Panel panelToActivate = (Panel)(Controls.Find(setType, true)[0]);
            panelToActivate.Visible = true;

        }
        private void HomeMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Panel p in Controls)
            {
                p.Visible = false;
            }
            foreach (MenuItem item in mainMenu1.MenuItems)
            {
                item.Visible = false;
            }
            Panel panelToActivate = (Panel)(Controls.Find("HomePanel", true)[0]);
            panelToActivate.Visible = true;
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            Panel active = null;
            foreach (Panel p in Controls)
            {
                if (p.Visible == true)
                {
                    active = p;
                    break;
                }
            }
            if (active == null || active.Name == "HomePanel")
            {
                return;
            }
            string picCanvasName = active.Name + "PicCanvas";
            PictureBox picCanvas = (PictureBox)(Controls.Find(picCanvasName, true)[0]);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filaName = saveFileDialog.FileName;
                if (filaName.IndexOf(".") == -1)
                {
                    picCanvas.Image.Save(filaName + ".png");
                }
                else
                {
                    picCanvas.Image.Save(filaName);
                }
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeTypeMenuItem_Click(object sender, EventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            string setType = menuItem.Text.Replace(" ", string.Empty);
            foreach (Panel p in Controls)
            {
                p.Visible = false;
            }
            Panel panelToActivate = (Panel)(Controls.Find(setType, true)[0]);
            panelToActivate.Visible = true;
        }
    }
}
