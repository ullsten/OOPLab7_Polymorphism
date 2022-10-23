using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_test
{
    public abstract class Geometry
    {
        public Geometry()
        {
            
        }
        public virtual double GetArea(double baseWwidth, double baseLenght)
        {
            return baseWwidth * baseLenght;
        }
        public virtual double GetPerimeter(double baseWidth, double baseHeight)
        {
            return baseWidth + baseHeight;
        }
        public virtual double GetVolume(double baseWidth, double baseHeight, double baseLenght)
        {
            return baseWidth + baseHeight + baseLenght;
        }
    }
}
