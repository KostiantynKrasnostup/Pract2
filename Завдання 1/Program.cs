using System; 
using System.Text.RegularExpressions; 

class Program
{
    static void Main(string[] args)
    {
        // Запитуємо логін у користувача
        Console.Write("Введіть логін: ");
        string login = Console.ReadLine();

        // Створюємо об'єкт регулярного виразу для перевірки логіна
        Regex loginRegex = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{1,9}$");

        // Перевіряемо, чи відповідає логін регулярному виразу
        if (loginRegex.IsMatch(login))
        {
            // Якщо логін коректний, виводимо повідомлення
            Console.WriteLine("Логін коректний");
        }
        else
        {
            // Якщо логін некоректний, виводимо повідомлення
            Console.WriteLine("Логін некоректний");
        }
    }
}