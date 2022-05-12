using System;
using System.Collections.Generic;

namespace task_dictionary
{
    class task_dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();

            //first method how to add vaules in dict

            countries.Add("uk", "United Kingdom");
            countries.Add("rus", "Russia");
            countries.Add("aus", "Australia");

            //second mehtod how to add values in dict

            countries["chn"] = "China";
            countries["esp"] = "Spain";
            string new_country = Console.ReadLine();

            //validating an existing key

            if (countries.ContainsKey(new_country))
            {
                Console.WriteLine("This key already exists");
            }
            else
            {
                Console.WriteLine("No such key exists");
            }

            Console.ReadKey();
        }
    }
}
