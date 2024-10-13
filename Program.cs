using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinqQurey1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1  finding number less then 10
            /* int[] array = { 1, 32, 3, 22, 12, 11 };


             var numbersLess10 = from i in array
                                 where i < 10
                                 select i;
             foreach (var i in numbersLess10)
             {
                 Console.WriteLine(i);
             }
             Console.ReadLine();*/


            //2  finding length of string array 

            /*string[] names = { "VGRR", "SS", "AK", "SGS", "KB" };

            var output = from name in names

                         where name.Length > 2
                         select name;
            foreach (var name in output)
            { 
                Console.WriteLine(name);
        }
            Console.ReadLine();*/


            string[] fruits = { "apply", "carrot", "orange" };
            IEnumerable<string> fruitsWithoInName = from fruit in fruits
                                                    where fruit.Contains('o')
                                                    where fruit.Contains('t')
                                                    select fruit;
            foreach (var name in fruitsWithoInName)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            
        }

    }
}
