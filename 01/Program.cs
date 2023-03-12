using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console.ReadLine());

        string[] arr = new string[n];
        for (int i = 0; i < n; i++) {
            Console.Write($"Введите строку {i + 1}: ");
            arr[i] = Console.ReadLine();
        }

        string[] result = new string[n];
        int j = 0;
        for (int i = 0; i < n; i++) {
            if (arr[i].Length <= 3) {
                result[j] = arr[i];
                j++;
            }
        }

        Console.WriteLine("Массив строк, длина которых меньше или равна 3:");
        for (int i = 0; i < j; i++) {
            Console.WriteLine(result[i]);
        }
    }
}