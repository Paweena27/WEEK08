using System;


namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] jagged = new string[2][];
            jagged[0] = new string[] { "Europe", "Asia", "North America", "South America", "Africa", "Oceania", "Antarctica" };
            jagged[1] = new string[] { "Greece", "	Ghana" };

            Console.WriteLine(" List_names of countries in the world : " + (string.Join(",", jagged[0])));
            Console.WriteLine("capital_names of of countries in the world : " + (string.Join(",", jagged[1])));
            Console.ReadKey();
        }
    }
}
