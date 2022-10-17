using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_test
{
    public abstract class Drawing
    {   
        
        public Drawing()
        {
            
        }
        public virtual void GetArea()
        {
            Console.WriteLine("This is baseArea");
        }
        public virtual void GetPerimeter()
        {
            Console.WriteLine("This is basePerimeter");
        }
        public virtual void GetVolume()
        {
            Console.WriteLine("This is baseVolume");
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("This is basePrintInfo!");
        }

    }
}
