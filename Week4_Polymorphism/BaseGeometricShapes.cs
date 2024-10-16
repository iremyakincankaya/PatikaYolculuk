using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Polymorphism
{
    public class BaseGeometricShapes
    {
        //Properties -> Width ve Height
        public double _width { get; set; }
        public double _height { get; set; }

        public virtual void AreaCalculatin(double width, double height)
        {
            Console.WriteLine($"Area = {width * height}");
        }
    }
    public class Square : BaseGeometricShapes { }
    public class Rectangle : BaseGeometricShapes { }
    public class Rectangular : BaseGeometricShapes
    {
        public override void AreaCalculatin(double width, double height)
        {
            Console.WriteLine($"Area of Rectangular = {width * height / 2}");
        }
    }
}
