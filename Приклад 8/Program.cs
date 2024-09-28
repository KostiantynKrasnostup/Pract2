using System;
using System.Text.RegularExpressions; 

class Program
{
    
    static string GetDomain(string url)
    {
        
        Regex re = new Regex(@"https?://", RegexOptions.IgnoreCase);
        url = re.Replace(url, ""); 

        Regex reWww = new Regex(@"^www\.", RegexOptions.IgnoreCase);
        url = reWww.Replace(url, ""); 

        int end = url.IndexOf('/');

        if (end != -1)
            url = url.Substring(0, end);

        return url;
    }

    static void Main(string[] args)
    {
        string url1 = "https://krypton.com.ua/tutorial/csharp/";
        string url2 = "https://krypton.com.ua/tutorial/ci-10-net-6/";

        Console.WriteLine(GetDomain(url1)); 
        Console.WriteLine(GetDomain(url2)); 
    }
}
