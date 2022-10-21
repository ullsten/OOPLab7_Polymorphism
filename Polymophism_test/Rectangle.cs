using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_test
{
    public class Rectangle : Geometry
    {
        protected double Area { get; set; }
        protected double width { get; set; }
        protected double height { get; set; }
        protected double lenght { get; set; }
        protected double Perimeter { get; set; }
        protected double Volume { get; set; }

        public Rectangle(double width = 10, double height = 25)
        {
            Area = GetArea(width, height);
        }
        public override double GetArea(double width, double height)         //Area calculation
        {
            Area = width * height;
            Console.WriteLine("Area as rectangle: " + Area + " cm2");
            return Area;
        }
        public override double GetPerimeter(double width, double height)            //Perimeter calculation
        {
            Perimeter = (width + height) * 2;
            Console.WriteLine("Perimeter as rectangle: " + Perimeter + " cm");
            return Perimeter;
        }
        public override double GetVolume(double width, double height, double lenght)            //Volume calculation
        {
            Volume = width * height * lenght;
            Console.WriteLine("Volume as rectangle: " + Volume + " cm3");
            return Volume;
        }
        public override string ToString()           //Could use ToString() for print 
        {
            return "Area as rectangle: " + Area;
        }
    }
}
