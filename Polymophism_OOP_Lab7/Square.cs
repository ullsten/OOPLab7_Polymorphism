using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_test
{
    
    public class Square : Geometry
    {
        protected double Area { get; set; }
        protected double Perimeter { get; set; }

        protected double sides { get; set; }

        protected int height { get; set; }

        public Square(double sides = 5, double height = 12)             //Prints area at start
        {
            Area = GetArea(sides, height); 
        }
        public override double GetArea(double sides, double height)            //Area calculation
        {
            Area = sides * height;
            Console.WriteLine("Area as square: " + Area + " cm3");
            return Area;   
        }
        public override double GetPerimeter(double sides = 5, double notActiveSides = 0)        //Perimeter calculation
        {
            Perimeter = sides * 4;
            Console.WriteLine("Perimeter as square: " + Perimeter + " cm");
            return Perimeter;   
        }
        public override string ToString()                                                   //Could use ToString() for print
        {
            return "Area as square: " + Area;
        }
    }
}
