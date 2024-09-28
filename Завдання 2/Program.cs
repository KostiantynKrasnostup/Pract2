using System;
using System.Text.RegularExpressions;

class Program
{
    // Головна функція програми
    static void Main(string[] args)
    {
        // Запитуємо вхідну строку від користувача
        Console.Write("Введіть вхідну строку: ");
        string input = Console.ReadLine();

        // Фільтруємо вхідну строку за допомогою функції FilterInput
        string filteredInput = FilterInput(input);

        // Виводимо результат фільтрації
        Console.WriteLine("Фільтрована вхідна строка: " + filteredInput);
    }

    // Функція фільтрації вхідної строки
    static string FilterInput(string input)
    {
        // Оголошуємо масиви слів для заміни та їх заміни
        string[] wordsToReplace = { "bad", "evil", "ugly" };
        string[] replacements = { "good", "nice", "beautiful" };

        // Створюємо регулярний вираз для пошуку слів для заміни
        string pattern = string.Join("|", wordsToReplace.Select(Regex.Escape));

        // Створюємо об'єкт Regex для пошуку та заміни слів
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        // Фільтруємо вхідну строку за допомогою регулярного виразу
        string filteredInput = regex.Replace(input, match =>
        {
            // Перевіряємо кожне слово для заміни
            for (int i = 0; i < wordsToReplace.Length; i++)
            {
                // Якщо слово співпадає з одним з слів для заміни, то замінюємо його
                if (match.Value.Equals(wordsToReplace[i], StringComparison.OrdinalIgnoreCase))
                {
                    return replacements[i];
                }
            }
            // Якщо слово не співпадає з жодним з слів для заміни, то залишаємо його без змін
            return match.Value;
        });

        // Повертаємо результат фільтрації
        return filteredInput;
    }
}