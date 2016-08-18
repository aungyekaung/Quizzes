using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes
{
    class CSDay5Quiz
    {
        public static void Main(String[] args)
        {
            int[,] theArray = new int[,]
            {
                {5,3}, {2,9}, {2,9},
                {5,1}, {7,1}, {8,3},
                {0,3}, {2,2}, {9,7}
            };

            int count = 0;

            Console.WriteLine("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < theArray.GetLength(0); i++)
            {
                for (int j = 0; j < theArray.GetLength(1); j++)
                {
                    if (theArray[i,j] == input)
                    {
                        count++;
                    }
                }
            }
            if (count > 0)
            {
                Console.WriteLine("The number of {0} is {1}.", input, count);
            }
            else
            {
                Console.WriteLine("There is no {0} in the array.", input);
            }
        }
    }
}
