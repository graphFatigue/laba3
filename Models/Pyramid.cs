using System;
using System.Drawing;
using System.Windows.Forms;

namespace Models
{
    public class Pyramid : Figure
    {

        private int k;
        public Pyramid(Point startPoint, float length, float width, float height, Form form) : base(startPoint, length, width, height, form)
        {
            Name = "Pyramid";
            k = Width == 0 ? 0 : 1;
        }

        public override void Draw(PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Green);
            Graphics formGraphics = MainForm.CreateGraphics();

            float X = (float)StartPoint.X;
            float Y = (float)StartPoint.Y;

            float Y2 = Y + (float)(Height / Math.Sqrt(2));
            float Y3 = Height - 2 * (float)(Height - Height / Math.Sqrt(2)) + Y;

            e.Graphics.DrawLine(myPen, X + Length / 2, Y, (X + Length / 2), (Y + Height));
            e.Graphics.DrawLine(myPen, k * (X + Length / 2), k * Y, k * X, k * Y2);
            e.Graphics.DrawLine(myPen, k * (X + Length / 2), k * Y, k * (X + Length), k * Y2);

            e.Graphics.DrawLine(myPen, k * (X + Length / 2), k * (Y + Height), k * X, k * Y2);
            e.Graphics.DrawLine(myPen, k * (X + Length / 2), k * (Y + Height), k * (X + Length), k * Y2);

            e.Graphics.DrawLine(myPen, k * (X + Length / 2), k * Y3, k * X, k * Y2);
            e.Graphics.DrawLine(myPen, k * (X + Length / 2), k * Y3, k * (X + Length), k * Y2);

            myPen.Dispose();
            formGraphics.Dispose();
        }

        public override float Perimeter() => (float)(4 * Math.Sqrt((Length * Length + Width * Width) / 2 + Height * Height) + 2 * (Width + Length));
        public override float Area() => (float)(2 * Math.Sqrt((Length * Length + Width * Width) / 2 + Height * Height - Width * Width) * Width +
                                        2 * Math.Sqrt((Length * Length + Width * Width) / 2 + Height * Height - Length * Length) * Length +
                                        Width * Length) / 10;

        public override void FillFigure(Graphics gr)
        {
            var _points = new System.Drawing.Point[4];
            _points[0] = new System.Drawing.Point((int)(StartPoint.X + Length / 2), (int)StartPoint.Y);
            _points[1] = new System.Drawing.Point((int)(k * (StartPoint.X + Length)), (int)(k * StartPoint.Y + (float)(Height / Math.Sqrt(2))));
            _points[2] = new System.Drawing.Point((int)(StartPoint.X + Length / 2), (int)(StartPoint.Y + Height));
            _points[3] = new System.Drawing.Point((int)(k * StartPoint.X), _points[1].Y);

            gr.FillPolygon(Brushes.Green, _points);
        }
    }
}