using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 5, 8, 2, 10, 7, 1, 6 };

        Console.WriteLine("ваше число");
        int userInput = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < userInput)
            {
                count++;
            }
        }

        Console.WriteLine("Кол-во элементов меньше" + userInput + ": " + count);

    }
}
