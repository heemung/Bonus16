using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class CarApp
    {
        private string userinput;
        public string UserInput
        {
            get
            {
                return userinput;
            }
            set
            {
                userinput = value;
            }
        }

        public void CreateObjectAndPrint(string userInput)
        {
            int userNum = int.Parse(userInput);
            Car objCar = new Car();
            List<Car> storeCars = new List<Car>();

            for (int i = 0; i < userNum; i++)
            {
                Console.Write("Ok, what is the make? ");
                objCar.Make = Console.ReadLine();
                Console.Write("The model? ");
                objCar.Model = Console.ReadLine();
                Console.Write("The year? ");
                objCar.Year = int.Parse(Console.ReadLine());
                Console.Write("Finally the price? ");
                objCar.Price = double.Parse(Console.ReadLine());

                storeCars.Add(objCar);
            }
            foreach(Car c in storeCars)
            {
                Console.WriteLine(c.ToString());
            }
        }
        public CarApp()
        {

        }
    }
}
