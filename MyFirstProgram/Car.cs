using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    public class Car 
    {
        private string _name;
        private string _model;
        private string _fourdoor;
        public double _engine;
        private string _transmission;

        public Car(string name, string model, bool fourdoor, double engine, string transmission)
        {
            _name = name;
            _model = model;
            _engine = engine;
            _transmission = transmission;

            if (fourdoor)
            {
                _fourdoor = "car have doors";
                AlertNotFamilyCar();
            }
            else
            {
                _fourdoor = "car do not have doors";
                AlertFamilyCar();
            }
            Console.WriteLine
            (
              $"This car is {_name} and model is {_model}, {_fourdoor}, engine is {_engine} and transmission type is {_transmission}."
            );
        }

        private void AlertNotFamilyCar()
        {
            Console.WriteLine("maybe it would not be great family car");
        }

        private void AlertFamilyCar()
        {
            Console.WriteLine("it would be great family car");
        }

    }

}