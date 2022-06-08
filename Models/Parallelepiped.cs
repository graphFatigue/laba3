using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Models
{
    public class Parallelepiped : Figure
    {
        public Parallelepiped(Point startPoint, float length, float width, float height, Form form) :
            base(startPoint, length, width, height, form)
        {
            Name = "Parallelepiped";
        }

        public override void Draw(PaintEventArgs e)
        {
            Pen myPen = new Pen(System.Drawing.Color.Green);
            Graphics formGraphics = MainForm.CreateGraphics();

            Point SecondPoint = new Point(StartPoint.X + Height, StartPoint.Y + Height);

            Figure rectangle1 = new Rectangle(StartPoint, Length, Width, MainForm);
            Figure rectangle2 = new Rectangle(SecondPoint, Length, Width, MainForm);

            float X = (float)StartPoint.X;
            float Y = (float)StartPoint.Y;

            rectangle1.Draw(e);
            rectangle2.Draw(e);

            e.Graphics.DrawLine(myPen, X, Y, X + Height, Y + Height);
            e.Graphics.DrawLine(myPen, X + Length, Y, X + Height + Length, Y + Height);
            e.Graphics.DrawLine(myPen, X, Y + Width, X + Height, Y + Height + Width);
            e.Graphics.DrawLine(myPen, X + Length, Y + Width, X + Height + Length, Y + Height + Width);

            myPen.Dispose();
            formGraphics.Dispose();
        }

        public override float Perimeter() => 4 * (Height + Width + Length);
        public override float Area() => 2 * (Height * Length + Height * Width + Length * Width);
        public override void FillFigure(Graphics gr)
        {
            var _points = new System.Drawing.Point[6];
            _points[0] = new System.Drawing.Point((int)(StartPoint.X + Width), (int)StartPoint.Y);
            _points[1] = new System.Drawing.Point(_points[0].X, (int)(_points[0].Y + Length));
            _points[2] = new System.Drawing.Point((int)(_points[1].X - Width), _points[1].Y);
            _points[3] = new System.Drawing.Point((int)(_points[2].X - Width), (int)(_points[2].Y - Length));
            _points[4] = new System.Drawing.Point(_points[3].X, (int)(_points[3].Y - Length));
            _points[5] = new System.Drawing.Point((int)(_points[4].X + Width), _points[4].Y);

            gr.FillPolygon(Brushes.Red, _points);
        }
    }
}