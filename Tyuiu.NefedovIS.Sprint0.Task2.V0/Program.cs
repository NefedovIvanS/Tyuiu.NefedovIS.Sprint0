﻿using Tyuiu.NefedovIS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.NefedovIS.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Игорь"));
            Console.ReadKey();
        }
    }
}
