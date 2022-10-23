using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_test
{
    public class Parallelogram : Geometry    //Could also inherits from rectangle becuase they are parallelogram(also rhombus)
    {
        protected double Area { get; set; }
        protected double Perimeter { get; set;}
        protected double baseWidth{get; set;}
        protected double height {get; set;}
        protected double width { get; set; }
        protected double length { get; set; }
        public Parallelogram(double height = 14, double width = 7, double lenght = 10)      //Print Area at start
        {
            Area =  GetArea(lenght, height);                                        
        }
        public override double GetArea(double lenght, double height) //Area
        {
            Area = lenght * height;
            Console.WriteLine("Area as parallelogram: " + Area + " cm2");
            return Area;
        }
        public override double GetPerimeter(double width, double length) //Perimeter
        {
            Perimeter = 2 * (length + width);
            Console.WriteLine("Perimeter: " + Perimeter + " cm");
            return Perimeter;
        }
        public override string ToString()               //Could use ToString() for print 
        {
            return "Area as parallelogram: " + Area + "cm2";
        }
    }
}
