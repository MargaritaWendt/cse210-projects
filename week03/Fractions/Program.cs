using System;
using System.Runtime.Serialization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Fraction n1 = new Fraction();
        Console.WriteLine(n1.GetTop());
        Console.WriteLine(n1.GetBottom());

        Fraction n2 = new Fraction(6);
        Console.WriteLine(n2.GetTop());
        Console.WriteLine(n2.GetBottom());

        Fraction n3 = new Fraction(6, 7);
        Console.WriteLine(n3.GetTop());
        Console.WriteLine(n3.GetBottom());
    }
}