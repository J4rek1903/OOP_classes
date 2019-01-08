using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_classes
{
    class Program
    {

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l=1,double w=1)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 10;
            r.width = 5;
            Console.WriteLine("Rectangle area : {0}", r.Area());
            Console.WriteLine("Square area : {0}", MathShape.GetArea("square", 5, 5));

            //------------------------------------------------------------
            //------------------------------------------------------------


            Car c1 = new Car()
            {
                CarBrand = "BMW",
                CarModel = "i8"
            };

            Car c2 = new Car()
            {
                CarBrand = "Audi",
                CarModel = "S8"
            };

            c1.SetCarID(12345, "Mr.Brown");
            c2.SetCarID(34567, "Mr.Smith");

            c2.GetInfo();
            c2.CarModel = "A6";

            c2.GetCarINFO();

            Console.ReadLine();
        }

        
    }
}
