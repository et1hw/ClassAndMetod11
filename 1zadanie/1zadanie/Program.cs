using System;

class Program
{
    // Метод public который умножает два числа 
    public static int MultiplyNumbers(int a, int b)
    {
        return a * b;
    }

    // Метод  private проверяет является ли число положительным
    private static bool IsPositive(int number)
    {
        return number > 0;
    }

    static void Main()
    {
        // Запрос 1  числа
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());  

        // Запрос 2 числа
        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());  

        // Вызов метода для умножения чисел
        int product = MultiplyNumbers(num1, num2);
        Console.WriteLine($"Произведение чисел {num1} и {num2} равно: {product}");

        // Проверка
        bool isPositive = IsPositive(product);
        Console.WriteLine($"Произведение положительное? {isPositive}");
    }
}


