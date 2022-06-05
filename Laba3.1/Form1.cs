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
        public Form1()
        {
            InitializeComponent();
            Models.Point point = new Models.Point(100, 100);
            Models.Point point1 = new Models.Point(50, 400);
            // NewPoint point2 = new NewPoint(400, 150);
            //Figure f = new Cube(point, 200, this);
            //
            _figure = new Models.Rectangle(point1, 400, 500, this);
            //_figure.ChangeSize(3);
            //_figure = new Pyramid(new NewPoint(120, 400), 100, 300, 100, this);
             Figure f1 = new Square(point, 200, this);
            // Figure f2 = new Pyramid(point1, 100, 10, 100, this);
            // Figure f3 = new ShadedRectangle(point2, 100, 300, this);
            //Figure f4 = new Parallelepiped(new NewPoint(200, 300), 50, 50, 150, this);

            _image = new Picture(this, f1, _figure);//, f4, f);

            // Figure f4 = new Parallelepiped(new NewPoint(200, 330), 100, 150, 150, this);
            // Figure f5 = new Cube(new NewPoint(500, 100), 200, this);
            //  MyImage img = new MyImage(this, f4, f5);
            //  _image.Merge(img);
            // f5.ChangeSize(2);
            // f5.MoveFigure(300, 100);
            // _image.ChangeSize(1);
            // _image.MoveFigures(-200, 100);
             _image.Save();
        }

        //private void Form1_Click(object sender, EventArgs e)
        //{
        //    if (_figure != null)
        //        this.txtFigure.Text = _figure.ToString();
        //    if (_image != null)
        //        this.txtFigure.Text = _image.ToString();
        //    _image.Save();
        //}

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _figure?.Draw(e);
            _image?.Draw(e);
        }
    }
}
