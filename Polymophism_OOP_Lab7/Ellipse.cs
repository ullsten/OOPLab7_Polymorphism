using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_test
{
    internal class Ellipse : Geometry
    {
        protected double Area { get; set; }
        protected double Perimeter { get; set; }
        protected double MajorRadiusA { get; set; }
        protected double MinorRadiusB { get; set; }
        public Ellipse(double MajorRadiusA = 10, double MinorRadiusB = 36)
        {
            Area = GetArea(MajorRadiusA, MinorRadiusB);
        }
        public override double GetArea( double MajorRadiusA = 10, double MinorRadiusB = 36)
        {
            Area = Math.PI * MajorRadiusA * MinorRadiusB;
            Console.WriteLine("Area as ellipse: " + Math.Round(Area, 2) + " m2");
            return Area;
        }
        public override double GetPerimeter(double MajorRadiusA, double MinorRadiusB)
        {
            Perimeter = Math.PI * (3 * (MajorRadiusA + MinorRadiusB) - Math.Sqrt((3 * MajorRadiusA + MinorRadiusB) * (MajorRadiusA + MinorRadiusB * 3)));
            Console.WriteLine("Perimeter as ellipse: " + Math.Round(Perimeter, 2) + " cm2");
            return Perimeter;
        }
        public override string ToString()                //Could use ToString() for print 
        {
            return "Area as ellipse: " + Math.Round(Area, 3) + "cm2";
        }
    }
}
