using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using Models;
//using Models;

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
            Models.Point point = new Models.Point(100, 100);
            Models.Point point1 = new Models.Point(50, 400);
            Models.Point point2 = new Models.Point(400, 150);
            //Figure f = new Cube(point, 200, this);
            //
            _figure = new Models.Rectangle(point1, 200, 300, this);
            //_figure.ChangeSize(3);
            //_figure = new Pyramid(new NewPoint(120, 400), 100, 300, 100, this);
             Figure f1 = new Square(point, 200, this);
            // Figure f2 = new Pyramid(point1, 100, 10, 100, this);
             Figure f3 = new ShadedRectangle(point2, 100, 300, this);
            //Figure f4 = new Parallelepiped(new NewPoint(200, 300), 50, 50, 150, this);
            _figures = new[] {f1, _figure, f3 };
            _image = new Picture(this, _figures);//, f4, f);

            // Figure f4 = new Parallelepiped(new NewPoint(200, 330), 100, 150, 150, this);
            // Figure f5 = new Cube(new NewPoint(500, 100), 200, this);
            //  MyImage img = new MyImage(this, f4, f5);
            //  _image.Merge(img);
            // f5.ChangeSize(2);
            // f5.MoveFigure(300, 100);
            // _image.ChangeSize(1);
            // _image.MoveFigures(-200, 100);
             
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
            //_image.MoveFigures(100, 20);
            //InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_figures != null)
            {
                foreach (var fig in _figures)
                {
                    this.txtFigure.Text += fig.ToString();
                }
            }
            button2.Visible = false;
        }

    }
}
