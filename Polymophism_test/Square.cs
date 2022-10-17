using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_test
{
    
    public class Square : Drawing
    {
        protected double Area { get; set; }
        protected double Perimeter { get; set; }

        protected double sides { get; set; }

        protected int height { get; set; }

        public Square()
        {
            this.sides = 5;
            this.height = 12;
        }
        public override void GetArea()
        {
            Area = sides * height;
            Console.WriteLine("Area: " + Area + " cm3");
        }
        public override void GetPerimeter()
        {
            Perimeter = sides * 4;
            Console.WriteLine("Perimeter: " + Perimeter + " cm");
        }
        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Square");
            GetArea();
            GetPerimeter();
            Console.ResetColor();

        }
    }
}
