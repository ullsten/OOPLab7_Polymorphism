using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_test
{
    public class Rectangle : Drawing
    {
        protected double Area { get; set; }
        protected double width { get; set; }
        protected double height { get; set; }
        protected double lenght { get; set; }
        protected double Perimeter { get; set; }
        protected double Volume { get; set; }

        public Rectangle()
        {
            this.width = 10;
            this.height = 25;
            this.lenght = 5;
        }
        public override void GetArea()
        {
            Area = width * height;
            Console.WriteLine("Area: " + Area + " cm2");
        }
        public override void GetPerimeter()
        {
            Perimeter = (width + height) * 2;
            Console.WriteLine("Perimeter: " + Perimeter + " cm");
        }
        public override void GetVolume()
        {
            Volume = width * height * lenght;
            //Console.WriteLine("Volume of rectangle is: " + Volume + " cm3");
            Console.WriteLine("Volume: " + Volume + " cm3");
        }
        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Rectangle");
            GetArea();
            GetPerimeter();
            GetVolume();
            Console.ResetColor();
        }
    }
}
