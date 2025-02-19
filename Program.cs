using System;
using System.Runtime.CompilerServices;
public class Calculator
{
    public int a { get; set; }
    public int b { get; set; }
    public Calculator(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public void Subtract(int a, int b)
    {
        Console.WriteLine($"choose wisly 1: {a}-{b} 2: {b}-{a}");
        string t = Console.ReadLine();
        if (t == "1")
        {
            int c = a - b;
            Console.WriteLine(c);
        }
        else if (t == "2")
        { 
            int c = b - a;
            Console.WriteLine(c);
        }
    }
    public void Add(int a,int b) 
    {
        int c = a + b;
        Console.WriteLine(c);
    }
    public void Multiply(int a,int b) 
    {
        int c = a * b;
        Console.WriteLine(c);
    }
    public void Divide(int a, int b)
    {
        Console.WriteLine($"choose wisly 1: {a}/{b} 2: {b}/{a}");
        string t = Console.ReadLine();
        if (t == "1")
        {
            if (b != 0)
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            else 
            { 
                Console.WriteLine("actually i can't let you do this but... i think nobody is watching for us so, it's infinity");
            }
        }
        else if (t == "2")
        {
            if (a != 0)
            {
                int c = b / a;
                Console.WriteLine(c);
            }
            else 
            { 
                Console.WriteLine("actually i can't let you do this but... i think nobody is watching for us so, it's infinity"); 
            }
        }
    }
}
class Programm
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator(1,2);
        calc.Add(1,3);
        calc.Subtract(2,4);
        calc.Divide(3,5);
        
    }
}