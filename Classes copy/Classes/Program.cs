using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Currency[] currencies = new Currency[7];

            currencies[0] = new Currency();
            currencies[0].Setup("ten", 10.0m, "tens");

            currencies[1] = new Currency();
            currencies[1].Setup("five", 5.0m, "fives");

            currencies[2] = new Currency();
            currencies[2].Setup("one", 1.0m, "ones");

            currencies[3] = new Currency();
            currencies[3].Setup("quarter", 0.25m, "quarters");

            currencies[4] = new Currency();
            currencies[4].Setup("nickle", 0.1m, "nickles");

            currencies[5] = new Currency();
            currencies[5].Setup("dime", 0.05m, "dimes");

            currencies[6] = new Currency();
            currencies[6].Setup("penny", 0.01m, "pennies");

            decimal change = 17.23m;

            for (int i = 0; i < currencies.Length; i++)
            {
                while (change > currencies[i].value)
                {
                    currencies[i].count++;
                    change -= currencies[i].value;
                }
            }
            for (int i = 0; i < currencies.Length; i++)
            {
                if (currencies[i].count > 0)
                {
                    if (currencies[i].count == 1)
                    {
                        Console.WriteLine(currencies[i].count + " " + currencies[i].name);
                    }
                    else
                    {
                        Console.WriteLine(currencies[i].count + " " + currencies[i].pluralName);
                    }
                }

            }
            Console.ReadLine();
        }
    }
    class Currency
    {
        public string name;
        public int count;
        public decimal value;
        public string pluralName;

        public void Setup(string givenName, decimal givenValue, string givenPlural)
        {
            name = givenName;
            value = givenValue;
            pluralName = givenPlural;
            count = 0;


        }
    }
}
