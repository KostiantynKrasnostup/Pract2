using System;
using System.Text.RegularExpressions; 

class Program
{
    static void Main(string[] args)
    {
        string data1 = "Петро, Микола, Андрій, Микола"; 
        Regex myReg = new Regex("Микола"); 
        MatchCollection matches = myReg.Matches(data1); 

        Console.WriteLine(matches.Count); 
        foreach (Match m in matches)
        {
            Console.WriteLine(m.Value); 
        }
    }
}
