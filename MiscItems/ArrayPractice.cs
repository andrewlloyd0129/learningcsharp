using System;
namespace LearningCSharp.MiscItems
{
    public class ArrayPractice
    {
        public Array JoiningArrays()
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int length = array1.Length + array2.Length;

            int[] answer = new int[length];
            int k = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                answer[k] = array1[i];
                k++;
                answer[k] = array2[i];
                k++;
            }
                
               


            for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }

            return null;
        }
    }
}