using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> groceries = new List<string>
        {
            "Bananas"
            "Apples",
            "Bread",
            "Milk",
            "Eggs",
            "Rice"
        };
        foreach (var item in groceries)
        {
            Console.WriteLine(item);
        }
    }
}
