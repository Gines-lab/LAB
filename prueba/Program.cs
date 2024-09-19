using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] values = { "12.3", "45", "ABC", "11", "DEF" };

        decimal total = 0m;
        StringBuilder message = new StringBuilder();

        foreach (var value in values)
        {
            if (decimal.TryParse(value, out decimal number))
            {
                total += number;
            }
            else
            {
                message.Append(value + " ");
            }
        }

        Console.WriteLine($"Message: {message.ToString().Trim()}");
        Console.WriteLine($"Total: {total}");
    }
}
