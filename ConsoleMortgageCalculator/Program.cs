using System;

namespace ConsoleMortgageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Mortgage Calculator!");


                Console.WriteLine("Enter remaining amount:");
                var mortgageAmount = Convert.ToDecimal(Console.ReadLine());


                Console.WriteLine("Enter APR:");
                var apr = Convert.ToDecimal(Console.ReadLine());


                Console.WriteLine("Last Paid Interest Amount:");
                var lastPaidInterest = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Last Paid Principal Amount:");
                var lastPaidPrincipal = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Extra Paid Principal Amount:");
                var extraPayment = Convert.ToDecimal(Console.ReadLine());

                var currentPayment = lastPaidInterest + lastPaidPrincipal;

                int monthsPaid = 0;
                decimal totalInterest = 0;

                while (mortgageAmount > 0)
                {
                    var monthlyInterest = Math.Round(mortgageAmount * (apr / 100 / 12), 2);

                    totalInterest += monthlyInterest;

                    var principal = currentPayment - monthlyInterest;


                    mortgageAmount -= (principal + extraPayment);

                    monthsPaid++;

                    Console.WriteLine($"Month {monthsPaid} - Principal: ${(principal + extraPayment)}, Interest: ${monthlyInterest}, Remaining: ${mortgageAmount} ");
                }


                Console.WriteLine(Math.Floor(monthsPaid / 12f) + " Years and " + monthsPaid % 12 + " Months");
                Console.WriteLine("Total Interest Paid: " + totalInterest);

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");                
            }
        }
    }
}
