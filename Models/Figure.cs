using System.Drawing;
using System.Windows.Forms;
using System;
using Newtonsoft.Json;

namespace Models
{

    public abstract class Figure
    {
        public Point StartPoint { get; set; }

        [JsonIgnore]
        public Form MainForm { get; set; }

        public float Length { get; set; }

        public float Width { get; set; }

        public float Height { get; set; }

        public string Name { get; set; }

        public Figure(Point startPoint, float length, float width, float height, Form form)
        {
            StartPoint = startPoint;
            MainForm = form;
            Length = length;
            Width = width;
            Height = height;
        }

        public virtual void Draw(PaintEventArgs e)
        {
            Pen myPen = new Pen(System.Drawing.Color.Red);
            Graphics formGraphics = MainForm.CreateGraphics();
        }

        public void MoveFigure(double i, double j)
        {
            StartPoint.X += i;
            StartPoint.Y += j;
        }

        public void ChangeSize(float k)
        {
            Height *= k;
            Width *= k;
            Length *= k;
        }

        public virtual float Perimeter()
        {
            return 0;
        }

        public virtual float Area()
        {
            return 0;
        }

        public override string ToString()
        {
            return " Name: " + Name +
                   " X: " + StartPoint.X +
                   " Y: " + StartPoint.Y +
                   " Length: " + Length +
                   " Width: " + Width +
                   " Height: " + Height +
                   " Area: " + Area() +
                   " Perimeter: " + Perimeter();
        }

        public Point this[int i, int j]
        {
            get => StartPoint;
            set
            {
                StartPoint.X = i;
                StartPoint.Y = j;
            }
        }

        public abstract void FillFigure(Graphics gr);
    }
}
