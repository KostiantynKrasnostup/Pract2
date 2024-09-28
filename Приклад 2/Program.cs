using System;
using System.Text.RegularExpressions; 

class Program
{
    static void Main(string[] args)
    {
        string data1 = "Петро, Андрій, Микола"; 
        Regex myReg = new Regex("Микола"); 
        Match match = myReg.Match(data1); 

        Console.WriteLine(match.Value); 
        Console.WriteLine(match.Index);
    }
}
