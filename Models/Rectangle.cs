using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Models
{
    public class Rectangle : Figure
    {
        public Rectangle(Point startPoint, float length, float width, Form form) : base(startPoint, length, width, 0, form)
        {
            Name = "Rectangle";
        }

        public override void Draw(PaintEventArgs e)
        {
            Pen myPen = new Pen(System.Drawing.Color.Green);
            Graphics formGraphics = MainForm.CreateGraphics();

            float X = (float)StartPoint.X;
            float Y = (float)StartPoint.Y;

            e.Graphics.DrawLine(myPen, X, Y, X + Length, Y);
            e.Graphics.DrawLine(myPen, X, Y + Width, X + Length, Y + Width);

            e.Graphics.DrawLine(myPen, X, Y, X, Y + Width);
            e.Graphics.DrawLine(myPen, X + Length, Y, X + Length, Y + Width);

            myPen.Dispose();
            formGraphics.Dispose();
        }

        public override float Perimeter() => 2 * (Length + Width);

        public override float Area() => Length * Width;

        public override void FillFigure(Graphics gr)
        {
            gr.FillRectangle(Brushes.Green, (float)StartPoint.X, (float)StartPoint.Y, Width, Length);
        }
    }
}