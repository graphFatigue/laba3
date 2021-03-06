using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Laba3._1
{
    public partial class Form1 : Form
    {
        
        private Figure _figure;
        private Picture _image;
        private Figure[] _figures;
        public Form1()
        {
            InitializeComponent();
            Models.Point point = new Models.Point(100, 300);
            Models.Point point1 = new Models.Point(650, 200);
            Models.Point point2 = new Models.Point(250, 150);
            Models.Point point3 = new Models.Point(500, 400);


            Figure f = new Cube(point, 200, this);
            //_figure = new Models.Rectangle(point1, 200, 300, this);
            //_figure.ChangeSize(3);
            _figure = new Pyramid(new Models.Point(20, 50), 200, 300, 200, this);
             //Figure f1 = new Square(point, 200, this);
            // Figure f2 = new Pyramid(point1, 100, 10, 100, this);
             Figure f3 = new ShadedRectangle(point2, 300, 100, this);
            //Figure f4 = new Parallelepiped(new Models.Point(200, 300), 50, 50, 150, this);


            _figures = new[] {f, _figure, f3 };


            _image = new Picture(this, _figures);//, f4, f);

            Figure f4 = new Parallelepiped(point3, 100, 150, 150, this);
            Figure f5 = new Cube(point1, 100, this);
            Picture img = new Picture(this, f4, f5);
             
            // f5.ChangeSize(2);
            // f5.MoveFigure(300, 100);
            //_image.ChangeSize(0.5);
            //_image.MoveFigures(-200, 100);
             _image.Merge(img);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _figure?.Draw(e);
            _image?.Draw(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _image.Save();
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)//повертає повний стан зображення у вигляді рядка
        {
            if (_image.Figures != null)
            {
                foreach (var fig in _image.Figures)//_figures)
                {
                    this.txtFigure.Text += fig.ToString();
                }
                this.txtFigure.Text += " Total area: " + _image.TotalArea();
                this.txtFigure.Text += " Total perimeter: " + _image.TotalPerim();
            }
            button2.Visible = false;
        }

      

    }
}
