using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes
{
    class CSDay4Quiz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bank of ISS.");
            Console.WriteLine("Enter your PIN:");
            int PIN = Convert.ToInt32(Console.ReadLine()); //always be careful to convert the string to integer.
            int truePIN = 123456;
            int count = 1;

            for (int i=0; i<3; i++)
            {
                if (PIN == truePIN)
                {
                    i = 3;
                    Console.WriteLine("PIN accepted. You can access your account now.");
                    break; //needbreak
                }
                
                else if (count < 3 && PIN != truePIN)
                    {
                        Console.WriteLine("Incorrect PIN. Please try again.");
                        count = count + 1;
                        PIN = Convert.ToInt32(Console.ReadLine());
                    }
                
                else
                {
                    Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
                }
            }
        }
    }
}
