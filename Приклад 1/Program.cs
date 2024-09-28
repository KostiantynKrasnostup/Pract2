using System;
using System.Text.RegularExpressions; 

class Program
{
    static void Main(string[] args)
    {
        string data1 = "Петро, Андрій, Микола";
        string data2 = "Петро, Андрій, Олександр";
        Regex myReg = new Regex("Микола"); 

        Console.WriteLine(myReg.IsMatch(data1)); 
        Console.WriteLine(myReg.IsMatch(data2)); 
    }
}
