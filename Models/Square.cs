using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Models
{
    public class Square : Rectangle
    {
        public Square(Point startPoint, float length, Form form) : base(startPoint, length, length, form)
        {
            Name = "Square";
        }
    }
}