using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class Car
    {
        public Car()
        {
            Make = "make";
            Model = "model";
            Year = 1;
            Price = 1.00;
        }

        private string carMake;
        public string Make
        {
            get
            {
                return carMake;
            }
            set
            {
                carMake = value;
            }
        }
        private string carModel;
        public string Model
        {
            get
            {
                return carModel;
            }
            set
            {
                carModel = value;
            }
        }
        private int carYear;
        public int Year
        {
            get
            {
                return carYear;
            }
            set
            {
                carYear = value;
            }
        }
        private double carPrice;
        public double Price
        {
            get
            {
                return carPrice;
            }
            set
            {
                carPrice = value;
            }
        }
        public override string ToString()
        {
            string temp = carMake + ", " + carModel + ": " + carYear + " -- " + carPrice;
            return temp;
        }
    }
}
