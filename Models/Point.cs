using Newtonsoft.Json;

namespace Models
{
    public class Point
    {
        private double _x;

        private double _y;

        public double X
        {
            get => _x;
            set => _x = value >= 0 ? value : -value;
        }

        public double Y
        {
            get => _y;
            set => _y = value >= 0 ? value : -value;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}