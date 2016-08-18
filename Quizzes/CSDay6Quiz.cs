using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzes
{
    class CSDay6Quiz
    {
        static int[] minIncomeArray = new int[]
        {
            20000, 30000, 40000, 80000,
            120000, 160000, 200000, 32000
        };

        static double[] taxRateArray = new double[]
        {
            0.02, 0.035, 0.07, 0.115,
            0.15, 0.17, 0.18, 0.20
        };
        static int[] basePayableAmountArray = new int[]
        {
            0, 200, 550, 3350,
            7950, 13950, 20750, 42350
        };

        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable = CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }

        public static int AskForIncome()
        {
            Console.WriteLine("Please enter your annual taxable income:");
            int income = Convert.ToInt32(Console.ReadLine()); //'T' is in capital
            return income;
        }

        public static int GetTaxBracket(int annIncome)
        {
            int txBkt = 0;
            
            for (int i = 0; i < minIncomeArray.Length; i++)
            {
                int arrayval = minIncomeArray[i];
               if (annIncome < minIncomeArray[i]) //because the bracket will only start working once it comes into range
                {
                    txBkt = i-1;
                    i = minIncomeArray.Length;
                }
            }
            return txBkt;
        }

        public static double CalculateIncomeTax(int annIncome, int txBkt)
        {
            double taxPay = 0.00;
            if (txBkt == -1)
            {
                taxPay = 0.00;
            }
            else
            {
                taxPay = taxRateArray[txBkt] * (annIncome - minIncomeArray[txBkt]) + basePayableAmountArray[txBkt];
            }
            return taxPay;
        }

        public static void PrintResult (int annIncome, double taxPay)
        {
            Console.WriteLine("For taxable annual income of ${0:0.00}, the tax payable amount is ${1:0.00}.", annIncome, taxPay);
        }
        }
}
