
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursLecture
{
    enum WeekDays
    {
        monday = 1,
        tuesday = 2,
        wednesday = 3,
        thursday = 4,
        friday = 5,
        saturday = 6,
        sunday = 7
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[,] input = {
                {"John and Mary have a discussion","1"},
                {"John and Mary interview","3"},
                {"F2F","4"},
                {"General meeting","7"}
            };

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        if (input[i, j].Length < 10)
                            Console.Write($"{input[i, j].ToLower()}");
                        else
                        {
                            Console.Write($"{input[i, j].ToLower().Substring(0, 10)}...");
                        }
                    }
                    else
                        Console.Write(" on "+(WeekDays)int.Parse(input[i, j]));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
