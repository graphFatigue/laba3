using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Models
{
    public class Cube : Parallelepiped
    {
        public Cube(Point startPoint, float length, Form form) :
            base(startPoint, length, length, (float)(length / (Math.Sqrt(2) + 1)), form)
        {
            Name = "Cube";
        }
    }
}