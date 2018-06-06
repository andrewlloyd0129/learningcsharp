using System;
namespace LearningCSharp.ControlFlow
{
    public class IfElseSwitchCase
    {
        public void IfElse()
        {
            int hour = 2;

            if (hour > 0 && hour < 12)
                Console.WriteLine("It's morning.");
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            bool isGoldCustomer = false;

            /* float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f; */

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
        }

        public void CaseSwitch()
        {
            

        }

    }
}
