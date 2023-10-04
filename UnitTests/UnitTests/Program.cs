// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Hello, World!");
    }


    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static bool IsOdd(int value)
    {
        return value % 2 == 1;
    }
}

