using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        decimal danielleTotal = 0;
        decimal edwardTotal = 0;
        decimal francisTotal = 0;

        decimal grandTotal = 0;

        while (true)
        {
            Console.WriteLine("Enter a salesperson initial");
            string initial = Console.ReadLine().ToUpper();

            if (initial == "Z")
            {
                break;
            }

            Console.WriteLine("Enter amount of sale");
            string saleInput = Console.ReadLine();
            decimal saleAmount;

            if (!decimal.TryParse(saleInput, out saleAmount))
            {
                Console.WriteLine("Invalid sale amount - please enter a valid number");
                continue;
            }
            switch (initial)
            {
                case "D":
                    danielleTotal += saleAmount;
                    break;
                case "E":
                    edwardTotal += saleAmount;
                    break;
                case "F":
                    francisTotal += saleAmount;
                    break;
                default:
                    Console.WriteLine("Sorry - invalid salesperson");
                    continue;
            }

            grandTotal += saleAmount;
        }
        string topSalesperson = "";
        decimal topSales = 0;

        if (danielleTotal > topSales)
        {
            topSales = danielleTotal;
            topSalesperson = "D";
        }

        if (edwardTotal > topSales)
        {
            topSales = edwardTotal;
            topSalesperson = "E";
        }

        if (francisTotal > topSales)
        {
            topSales = francisTotal;
            topSalesperson = "F";
        }


        Console.WriteLine("Danielle sold: {0}",
            danielleTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("Edward sold: {0}",
            edwardTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("Francis sold: {0}",
            francisTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));


        Console.WriteLine("Total sales were: {0}",
            grandTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));

        {
            Console.WriteLine("{0} sold the most", topSalesperson);
        }

        Console.ReadKey();
    }
}