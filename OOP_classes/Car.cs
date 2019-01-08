using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_classes
{
    class Car
    {
        static int numOfCars = 0;

        private string carB;
        protected string BrandModel;

        public Car()
        :this("none", "none") { numOfCars++; }

        public Car(string carB = "none")
        :this(carB, "none") { numOfCars++; }

        public Car(string carB="none",string model = "none")
        {
            CarBrand = carB;
            BrandModel = model;
            numOfCars++;
        }

        public void GetInfo()
        {
            Console.WriteLine("{0} {1}",CarBrand,BrandModel);
        }

        public static int CarCount()
        {
            return numOfCars;
        }

        protected CarIDinfo carId = new CarIDinfo();

        public void SetCarID(int carID, string Owner)
        {
            carId.IDnum = carID;
            carId.Owner = Owner;
        }

        public void GetCarINFO()
        {
            Console.WriteLine($"{CarBrand} {CarModel} is owned by {carId.Owner} and has the ID of {carId.IDnum} ");
        }

        public string CarBrand
        {
            get { return carB; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    carB = "none";
                }
                else
                {
                    carB = value;
                }
            }
        }

        public string CarModel
        {
            get { return BrandModel; }
            set
            {
                if (value.Length > 15)
                {
                    BrandModel = "none";
                }
                else
                {
                    BrandModel = value;
                }
            }
        }  


    }
}
