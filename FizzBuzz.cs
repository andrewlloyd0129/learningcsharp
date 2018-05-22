using System;
using System.Linq;

namespace LearningCSharp
{
    public class FizzBuzz
    {
        public FizzBuzz(int[] arg)
        {
            string answer = "";
            for (int i = 0; i < arg.Length; i++)
            {
                if (arg[i] % 5 == 0 && arg[i] % 3 == 0)
                {
                    answer += "FizzBuzz,";
                }
                else if (arg[i] % 5 == 0)
                {
                    answer += "Buzz,";
                }
                else if (arg[i] % 3 == 0)
                {
                    answer += "Fizz,";
                }
                else
                {
                    answer += "" + arg[i] + ",";
                }
            }
            Console.WriteLine(answer);
            
        }

        public static int[] setArg()
        {
            Console.WriteLine("Enter an integer");
            string start = Console.ReadLine();
            Console.WriteLine("how many things do you want");
            string end = Console.ReadLine();
            int startInt = Convert.ToInt32(start);
            int endInt = Convert.ToInt32(end);
            int[] array = Enumerable.Range(startInt, endInt).ToArray();
            return array;
        }

    }
}


