using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Models
{
    public class ShadedRectangle : Rectangle
    {
        public override void Draw(PaintEventArgs e)
        {
            base.Draw(e);

            Pen myPen = new Pen(System.Drawing.Color.Green);
            Graphics formGraphics = MainForm.CreateGraphics();

            float X = (float)StartPoint.X;
            float Y = (float)StartPoint.Y;

            e.Graphics.DrawLine(myPen, X, Y, X + (float)Length, Y + (float)Width);
            e.Graphics.DrawLine(myPen, X + (float)Length / 2, Y, X + (float)Length, Y + (float)Width / 2);
            e.Graphics.DrawLine(myPen, X, Y + (float)Width / 2, X + (float)Length / 2, Y + (float)Width);

            

            myPen.Dispose();
            formGraphics.Dispose();
        }

        public ShadedRectangle(Point startPoint, float length, float width, Form form) : base(startPoint, length, width, form)
        {
            Name = "ShadedRectangle";
        }
    }
}