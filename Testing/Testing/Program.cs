using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(GetCountry("Ion"));
        }

        static string GetCountry(string name)
        {
            if (name == "Ion")
                return "Romania";
            if (name == "John")
                return "USA";
        }
    }
}
