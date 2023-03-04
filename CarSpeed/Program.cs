using System;

namespace OOPTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            //input car information
            int YearModel = 1968;
            string Make = "Ford";
            string Model = "Mustang";
            int Speed = 60;

            int maxSpeed = 100;

            Car modelCar = new Car(YearModel, Make, Model, Speed);
            Console.WriteLine($"{modelCar.yearModel} {modelCar.make} {modelCar.model} {modelCar.speed}km/h");
            Console.WriteLine("To end this, please press \"E\"");

            string option = "a";

            do
            {
                Console.Write("More Speed, current Speed, less Speed (MCL)?: ");
                option = Console.ReadLine().ToUpper();

                if (option.StartsWith("M"))
                {
                    if (Speed < maxSpeed)
                    {
                    Speed = modelCar.Accelerate(Speed);
                    Console.WriteLine($"You are driving at the speed of {Speed} kilometers/hour.");
                    }
                    else
                    {
                        Console.WriteLine($"You are driving at the speed of {Speed} kilometers/hour.");
                        Console.WriteLine("Car is running on max Speed");
                    }
                }
                else if (option.StartsWith("C"))
                {
                    Speed = modelCar.CurrentSpeed(Speed);
                    Console.WriteLine($"You are driving at the speed of {Speed} kilometers/hour.");
                }
                else if (option.StartsWith("L"))
                {
                    if (Speed > 0)
                    {
                    Speed = modelCar.Brake(Speed);
                    Console.WriteLine($"You are driving at the speed of {Speed} kilometers/hour.");
                    }
                    else
                    {
                        Console.WriteLine("You are currently not mo-ving at all");
                    }
                }
                else if (option.StartsWith("E"))
                {
                    //this ends the process
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            } while (option != "E");
        }
    }
}
