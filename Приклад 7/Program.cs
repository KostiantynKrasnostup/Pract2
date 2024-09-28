using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string data = "nikolay, Sergey, oleg"; 
        Regex myRegIgnoreCase = new Regex(@"Sergey", RegexOptions.IgnoreCase);
        Regex myReg = new Regex(@"Sergey");

        Console.WriteLine(myRegIgnoreCase.IsMatch(data)); 
        Console.WriteLine(myReg.IsMatch(data)); 
    }
}
