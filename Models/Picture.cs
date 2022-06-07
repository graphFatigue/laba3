using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Models
{
    public class Picture
    {
        private List<Figure> _figures;

        private Form _mainform;

        public Bitmap Pic;
        public Graphics picGr;

        public List<Figure> Figures
        {
            get => _figures;
            private set => _figures = value;
        }


        public Picture(Form form)
        {
            _mainform = form;
            _figures = new List<Figure>();

            Pic = new Bitmap(1020, 600);
            picGr = Graphics.FromImage(Pic);
        }

        public Picture(Form form, params Figure[] figures)
        {
            _mainform = form;
            _figures = new List<Figure>();
            Pic = new Bitmap(2000, 1100);
            picGr = Graphics.FromImage(Pic);

            var PicClone = new Bitmap(1020, 600);
            var pcGr = Graphics.FromImage(PicClone);
            foreach (Figure f in figures)
            {
                _figures.Add(f);
                f.FillFigure(picGr);
            }
        }

        public void AddForm(Form f)
        {
            _mainform = f;
            foreach (Figure fig in _figures)
            {
                fig.MainForm = f;
            }
        }

        public void Add(Figure figure)
        {
            _figures.Add(figure);
        }

        public void DeleteAll()
        {
            _figures.Clear();
        }

        public double TotalArea()
        {
            double result = 0.0;
            foreach (Figure f in _figures)
            {
                result += f.Area();
            }

            return result;
        }



        public double TotalPerim()
        {
            double result = 0.0;
            foreach (Figure f in _figures)
            {
                result += f.Perimeter();
            }

            return result;
        }

        public void MoveFigures(double i, double j)
        {
            foreach (Figure f in _figures)
            {
                f.StartPoint.X += i;
                f.StartPoint.Y += j;
            }
        }

        public void ChangeSize(double k)
        {
            foreach (Figure f in _figures)
            {
                if (f.GetType().Name == "Pyramid")
                {
                    k *= (float)(1 - 1 / Math.Pow(1.01, f.Width == 0 ? 1 : f.Width)) *
                         (float)(1 - 1 / Math.Pow(1.01, f.Height == 0 ? 1 : f.Height)) *
                         (float)(1 - 1 / Math.Pow(1.01, f.Length == 0 ? 1 : f.Length));
                }

                f.Height *= (float)k;
                f.Width *= (float)k;
                f.Length *= (float)k;
                f.StartPoint.X *= (float)k;
                f.StartPoint.Y *= (float)k;
            }
        }


        public void Merge(Picture image)
        {
            foreach (Figure f in image.Figures)
            {
                this.Add(f);
            }
            image.Figures.Clear();
        }

        public void Draw(PaintEventArgs e)
        {
            foreach (Figure f in Figures)
            {
                f.Draw(e);
            }
        }

        public string Save()
        {
            string jsonTypeNameAuto = JsonConvert.SerializeObject(_figures, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });

            string path = AppDomain.CurrentDomain.BaseDirectory;
            if (File.Exists(Path.Combine(path, "Image.json")))
            {
                File.Delete(Path.Combine(path, "Image.json"));
            }
            using (StreamWriter sw = File.CreateText(Path.Combine(path, "Image.json")))
            {
                sw.WriteLine(jsonTypeNameAuto);
                sw.Close();
            }
            return jsonTypeNameAuto;
        }

    }
}