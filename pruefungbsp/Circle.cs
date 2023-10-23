using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruefungbsp
{
    internal class Circle
    {
        private readonly static double pi = 3.1415;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public Circle() : this(10) { }
        private double Radius { get; set; }
        public double Durchmesser
        {
            get
            {
                return 2 * Radius;
            }
        }
        public double BerechneFlaeche()
        { return Radius * Radius * pi; }
        public static double BerechneUmfang(double radius)
        {
            return radius * 2 * pi;
        }
        public double BerechneUmfang()
        {
            return Radius * 2 * pi;
        }
    }
}













