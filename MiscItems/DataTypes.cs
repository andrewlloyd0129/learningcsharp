using System;
namespace LearningCSharp.MiscItems
{
    public class DataTypes
    {
        public void Arrays()
        {
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            flags[1] = false;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Jack", "John", "Mary" };

        }

        public void Strings()
        {
            string firstName = "Andrew";
            var middleName = "Brett";
            String lastName = "Lloyd";

            var fullName = firstName + " " + middleName + " " + lastName;
            var firstLastName = string.Format("My first and last name are {0} {1}", firstName, lastName);
            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "Hi John\nLook into the following paths c:\\folder1\\folder2";
            Console.WriteLine(text);

            var verbatimText = @"Hi John
Look into the following paths c:\folder1\folder2";
            Console.WriteLine(verbatimText);
        }
    }
}
