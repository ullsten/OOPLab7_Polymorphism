using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_test
{
    public class Circle : Drawing
    {
        protected double Area { get; set; }
        protected double Perimeter { get; set;}
        protected double radius { get; set; }
        protected float Volume { get; set; }
        public Circle()
        {
            this.radius = 15;    
        }
        public override void GetArea()
        {
            Area = Math.PI * radius * radius;
            Console.WriteLine("Area: " + Math.Round(Area,1) + " cm3"); 
        }
        public override void GetPerimeter()
        {
            Perimeter = 2 * Math.PI * radius;
            Console.WriteLine("Perimeter: " + Math.Round(Perimeter,2) + " cm3");
        }
        public void GetVolumeSphere() //Calculate volume of sphere
        {
            Volume = (float)(4.0 / 3 * Math.PI * radius * radius * radius);
            Console.WriteLine("Volume sphere: " + Math.Round(Volume,1) + " cm3");
        }
        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Circle");
            GetArea();
            GetPerimeter();
            GetVolumeSphere();
            Console.ResetColor();
        }
    }
}
