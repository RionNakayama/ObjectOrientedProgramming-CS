using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask4
{
    class Car
    {

        public Car(int YearModel, string Make, string Model, int Speed)
        {
            yearModel = YearModel;
            make = Make;
            model = Model;
            speed = Speed;
        }

        public int yearModel { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int speed { get; set; }

        public int Accelerate(int Speed)
        {
            return Speed + 5;
        }

        public int Brake(int Speed)
        {
            return Speed - 5;
        }

        public int CurrentSpeed(int Speed)
        {
            return Speed;
        } 
    }
}
