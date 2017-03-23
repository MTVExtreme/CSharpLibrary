using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_Creation
{

    class Program
    {
        static void Main(string[] args)
        {
            BasicCar();
            run();
        }

        //Run Method to run everything
        

        static void BasicCar()
        {
            DateTime dt = DateTime.Now;

            double maxSpeed;
            string carName;
           // string value;
            short manufactureYear;
            bool run = false;

            short b;
            double a;

            Car car = new Car();

            //Has user type Car name
            Console.Write("Please enter the Car's name: ");
            car.carName = Console.ReadLine();
            while (run == false)
            {

                //manufacture year
                Console.Write("\nNow please enter the Car's manufacture year: ");
                if (short.TryParse(Console.ReadLine(), out b))
                {
                    car.manufactureYear = b;
                    run = true;

                    //checking for errors with input values
                    if (car.manufactureYear < 1900)
                    {
                        run = false;
                        Console.Write("\nError: Woah that's a OLD car but for this program we need a car made after 1900. Hit enter to continue.");
                    }
                    else if (car.manufactureYear > (dt.Year + 1))
                    {
                        run = false;
                        Console.Write("\nError: Holy Cow! Are you from the future? Please enter a car dated before {0}. Hit enter to continue.", (dt.Year + 1));
                    }
                }
                else
                {
                    //checking for errors with input values
                    Console.Write("\nError: Input must be a number. Hit enter to continue.");
                    Console.ReadLine();
                }
                // _manufactureYear = short.Parse(Console.ReadLine());

            }
            run = false;

            while (run == false)
            {
                Console.Write("\nFinally please enter the Car's max speed in MPH: ");
                if (double.TryParse(Console.ReadLine(), out a))
                {
                    car.maxSpeed = a;
                    run = true;
                    //checking for errors with input values
                    if (car.maxSpeed > 300 || car.maxSpeed < 1)
                    {
                        Console.Write("\nError: Number is out of bounds. Has to be between 1 and 300. Press enter to continue");
                        run = false;
                    }
                }
                else
                {
                    //checking for errors with input values
                    Console.Write("\nError: Input must be a number. Hit enter to continue.");
                    Console.ReadLine();
                }          
            }
            run = false;

            //run();
        }

        static  void spCar()
        {

        }

    }
}

