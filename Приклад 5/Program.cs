using System;
using System.Text.RegularExpressions; 

class Program
{
    static void Main(string[] args)
    {
        string data1 = "Петро, Микола, Андрій, Микола"; 
        Regex myReg = new Regex(", "); 
        string[] names = myReg.Split(data1); 

        // Вывод массива имен для проверки
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
