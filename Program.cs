using System;
using System.Linq;
using LearningCSharp.ControlFlow;
using LearningCSharp.LearningClasses;
using LearningCSharp.MiscItems;

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

            /* var result = Calculator.Add(4, 5);
             Console.WriteLine(result); */

            /* var dataTypes = new DataTypes();
            dataTypes.Arrays();
            dataTypes.Strings(); */

            /* var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName); */

            var hour = new IfElseSwitchCase();
            hour.IfElse();

        }
      
    }
}