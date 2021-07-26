using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_provision
{
    class Program
    {
        static void Main(string[] args)
        {
            double Monthly;
            double Yearly;
            double Sales;
            double Total;
            double Price = 1.25;
            double percentage = 0;
            double a;
            double countA = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("How many units have you sold this month?");
                    Monthly = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid: try again");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("How many units have you sold in the last 12 months?");
                    Yearly = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid: try again");
                }
            }
            Sales = Monthly * Price;
            Total = (Sales * 0.03) + (Monthly * 4);
            if (Yearly > 20000)
            {
                a = Yearly - 20000;
                while (a >= 1000)
                {
                    a = a - 1000;
                    countA = countA + 2;
                }
                percentage += countA;
            }
            if (Yearly > 10000)
            {
                if (Yearly <= 20000)
                {
                    a = Yearly - 10000;
                    while (a >= 1000)
                    {
                        a = a - 1000;
                        countA = countA + 1.5;
                    }
                    percentage += countA;
                }
                else if (Yearly > 20000)
                {
                    percentage += 15;
                }
                percentage += 10;
            }
            if (Yearly <= 10000)
            {
                a = Yearly;
                while (a >= 1000)
                {
                    a = a - 1000;
                    countA = countA + 1;
                }
                percentage += countA;
            }
            if (percentage > 50)
            {
                percentage = 50;
            }
            percentage = percentage / 100 + 1;
            Total = Total * percentage;
            Console.WriteLine("Your payment this month is: " + Total);
        }
    }
    // berekening is per maand
    // 3% van omzet + 4 euro per sale
    // verhoging van bovenstaande bedrag met percentage dat afhankelijk is van hoeveelheid sales van afgelopen 12 maanden
        // voor eerste 10000: 1% per 1000
        // voor tweede 10000: 1,5% per 1000
        // boven 20000: 2% per 1000
    // percentage nooit hoger dan 50%
}
