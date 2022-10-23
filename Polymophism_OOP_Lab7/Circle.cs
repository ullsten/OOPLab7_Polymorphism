using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_test
{
    public class Circle : Geometry
    {
        protected double Area { get; set; } 
        protected double Perimeter { get; set;}
        protected double Radius { get; set; }
        protected double VolumeSphere { get; set; }
        public Circle(double radius = 15)           //Print Area at start
        {
            Area = GetArea(radius, radius);             
        }
        public override double GetArea(double radius, double notActiveRadius)       //Area Calculation
        {
            Area = Math.PI * radius * radius;
            Console.WriteLine("Area as circle: " + Math.Round(Area, 2) + " cm3");
            return Area;
        }
        public override double GetPerimeter(double radius, double notActiveRadius = 0)      //Perimeter calculation
        {
            Perimeter = 2 * Math.PI * radius;
            Console.WriteLine("Perimeter as circle: " + Math.Round(Perimeter,2) + " cm3");
            return Perimeter;
        }
        public double GetVolumeSphere(double radius)                                    //Calculate volume of sphere
        {
            VolumeSphere = (float)(4.0 / 3 * Math.PI * radius * radius * radius);
            Console.WriteLine("Volume as sphere: " + Math.Round(VolumeSphere,2) + " cm3");
            return VolumeSphere;
        }
        public override string ToString()                //Could use ToString() for print 
        {
            return "Area as circle: " + Area + "cm3";
        }
    }
}
