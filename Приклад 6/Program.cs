using System;
using System.Text.RegularExpressions; 

class Program
{
    static void Main(string[] args)
    {
        Regex myReg = new Regex(@"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$"); 
        Console.WriteLine(myReg.IsMatch("email@email.com")); 
        Console.WriteLine(myReg.IsMatch("email@email")); 
        Console.WriteLine(myReg.IsMatch("@email.com")); 
    }
}
