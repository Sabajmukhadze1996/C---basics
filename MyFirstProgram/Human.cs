using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace MyFirstProgram
{
   public class Human
    {
        
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        public Human(string eyeColor, int age)
        {
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        public void IntroduceMyself ()
        {
            Console.WriteLine("Hi, my firstname is " + " " + firstName 
             + " and my last name is "  + lastName + eyeColor);
        }

    }
}
