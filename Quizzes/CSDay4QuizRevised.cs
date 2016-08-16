using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes
{
    class CSDay4QuizRevised
    {
       public static void Main (String[] args)
        {
            Console.WriteLine("Welcome to the Bank of ISS.");
            Console.WriteLine("Enter your PIN:");

            int pin = getPIN();


        }
        public static int getPIN()
        {
            int pin = Convert.ToInt32(Console.ReadLine());
            return pin;
        }
    }
}
