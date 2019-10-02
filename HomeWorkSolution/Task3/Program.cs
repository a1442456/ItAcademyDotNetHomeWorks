using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        const double bankRate = 0.0016;
        static void Main(string[] args)
        {
            decimal startDeposit = 5000;
            DateTime depositeDate = new DateTime(2019, 9, 1);
            CalculateDeposit(startDeposit, depositeDate, 120);

            Console.ReadLine();
        }

        /// <summary>
        /// Calculate deposit.
        /// </summary>
        /// <param name="startDeposit">Start value.</param>
        /// <returns>Return deposit value included bank rate.</returns>
        static void CalculateDeposit(decimal startDeposit, DateTime depositeDate, int monthCount)
        {
            decimal addedMoney;
            for (int month = 1; month <= monthCount; month++)
            {
                addedMoney = startDeposit * (decimal)bankRate;
                startDeposit += startDeposit * (decimal)bankRate;
                Console.WriteLine(String.Format("{0} Added Money:({2,30}) Deposite status:({1,30})", depositeDate.AddMonths(month).ToShortDateString(), startDeposit, addedMoney));
            }
        }
    }
}
