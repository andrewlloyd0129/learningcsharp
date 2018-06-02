using System;
using System.Linq;
using LearningCSharp.LearningClasses;

namespace LearningCSharp
{

    class Program
    {
        static void Main(string[] args)
        {

            // FizzBuzz fizzBuzz = new FizzBuzz(FizzBuzz.setArg());

            /*var andrew = new Person();
            andrew.FirstName = "Andrew";
            andrew.LastName = "Lloyd";
            andrew.Introduce(); */

            var result = Calculator.Add(4, 5);
            Console.WriteLine(result);

        }
      
    }
}
