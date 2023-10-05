using System;
using System.Collections.Generic;
using System.Text;

namespace BrakeShoes;

public static class Program
{
    private static List<string> _mvps = new List<string>();
    private static List<string> _numbers = new List<string>();
    
    public static void Main(string[] args)
    {
        for (int i = 0; i < 2; i++) {
            Console.WriteLine("ЧАСТЬ " + (i + 1));
            Work();
        }
    }

    private static void Work()
    {
        _mvps.Clear();
        _numbers.Clear();
        
        Console.Write("Введите количество полей типа Номер МВПС (ЭД4М - 0091): ");
        var N = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 0; i < N; i++)
        {
            _mvps.Add(Console.ReadLine()?.Replace(" ", "") ?? string.Empty);
        }
        
        Console.WriteLine("\nВведите номера ТБ аналогично (без количества): ");
        for (int i = 0; i < N; i++) {
            _numbers.Add(Console.ReadLine() ?? string.Empty);
        }
        
        Console.WriteLine("\nРезультат:");
        var sb = new StringBuilder();
        for (int i = 0; i < N; i++) {
            sb.Append(_mvps[i] + " тормозные башмаки №№" + _numbers[i] + " в наличии сверены с книгой учета " +
                      "ПУ-80 и соответствуют описи, находящейся на электропоезде.\n");
        }
        
        Console.WriteLine(sb.ToString());
    }
}