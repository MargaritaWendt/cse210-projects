using System;
using System.Runtime.Serialization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Fraction n1 = new Fraction();
        Console.WriteLine(n1.GetFractionString());
        Console.WriteLine(n1.GetDecimalValue());

        Fraction n2 = new Fraction(6);
        Console.WriteLine(n2.GetFractionString());
        Console.WriteLine(n2.GetDecimalValue());

        Fraction n3 = new Fraction(6, 7);
        Console.WriteLine(n3.GetFractionString());
        Console.WriteLine(n3.GetDecimalValue());
    }
}