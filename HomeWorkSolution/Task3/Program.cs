using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        const double bankRate = 0.02;
        static void Main(string[] args)
        {
            decimal startDeposit = 1000;
            DateTime depositeDate = new DateTime(2019, 9, 1);
            bool isHighPrecision = new bool();
            Console.WriteLine("Enter monthes count");
            uint monthesCount = ReadAnswerFromUser();
            Console.WriteLine("isHighPrecision false:");
            CalculateDeposit(startDeposit, depositeDate, monthesCount, isHighPrecision);

            isHighPrecision = true;
            Console.WriteLine("\nisHighPrecision true:");
            CalculateDeposit(startDeposit, depositeDate, monthesCount, isHighPrecision);
            
            Console.ReadLine();
        }

        /// <summary>
        /// Calculate deposit.
        /// </summary>
        /// <param name="currentDeposit">Start value.</param>
        /// <returns>Return deposit value included bank rate.</returns>
        static void CalculateDeposit(decimal currentDeposit, DateTime depositeDate, uint monthCount, bool isHighPrecision)
        {
            Console.WriteLine(string.Format("{0} Deposit money at start: {1}; Bank rate: {2}% ", depositeDate.ToShortDateString(), currentDeposit, bankRate));
            decimal addedMoney;
            for (int month = 1; month <= monthCount; month++)
            {
                addedMoney = currentDeposit * (decimal)bankRate;
                currentDeposit += currentDeposit * (decimal)bankRate;
                if (!isHighPrecision)
                    Console.WriteLine(String.Format("{0} Added money:({2:N2}) Deposite status:({1:N2})", depositeDate.AddMonths(month).ToShortDateString(), currentDeposit, addedMoney));
                else
                    Console.WriteLine(String.Format("{0} Added money:({2,-30}) Deposite status:({1,-30})", depositeDate.AddMonths(month).ToShortDateString(), currentDeposit, addedMoney));
            }
        }

        /// <summary>
        /// Reads user entered char.
        /// </summary>
        /// <returns>Return char.</returns>
        static uint ReadAnswerFromUser()
        {
            Console.Write("Your answer is:");
            try
            {
                return uint.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return ReadAnswerFromUser();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                return ReadAnswerFromUser();
            }
        }
    }
}
