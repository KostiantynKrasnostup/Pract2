using System;
using System.Text.RegularExpressions; 

class Program
{
    static void Main(string[] args)
    {
        string data1 = "Петро, Микола, Андрій, Микола"; 
        Regex myReg = new Regex("Микола"); 
        data1 = myReg.Replace(data1, "Максим"); 
        Console.WriteLine(data1); 
    }
}
