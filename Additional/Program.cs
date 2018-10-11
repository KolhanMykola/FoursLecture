using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"Learn C# by stepping through the basics with Bob: get the tools, see how to write code, debug features, explore customizations, and much more ! Search for and focus on the information you need, in this C# for beginners course, which has topics separated out into individual videos. Get to know the grammar, create and use methods, manipulate strings, and see how to handle events. Plus, get a look at next steps as you learn to develop Windows and web applications.";
            int counter = 0, temp1 = 0;
            string temp = null;
            int[] array = { -4, -3, 0, 1, 2, -2, -1, 3, 4 };
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int length = numbers.Length;
            int halfOfArrayLength = length / 2;

            try
            {
                Console.WriteLine(input.Substring(input.IndexOf('!')).Replace("cs", "c's"));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong(. Youve got /n{e}");
            }

            for (int i = 0; i < input.Length - 1; i++)
            {
                temp = input.Substring(i, 2);
                if (temp == "et")
                {
                    counter++;
                }
            }

            Console.WriteLine("The number of 'et' string: {0}", counter);

            counter = 0;
            foreach (var element in array)
            {
                if (element > 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("The number of values that are greater than zero: {0}", counter);

            for (int i = 0; i < halfOfArrayLength; i++)
            {
                temp1 = numbers[i];
                numbers[i] = numbers[length - i - 1];
                numbers[length - i - 1] = temp1;
            }

            Console.WriteLine("Reversed array:");

            foreach (int i in numbers)
            {
                Console.Write($"{i} \t");
            }

            Console.ReadKey();
        }
    }
}
