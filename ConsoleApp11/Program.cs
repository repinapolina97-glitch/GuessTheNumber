using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("============================================");
            Console.WriteLine("              УГАДАЙ ЧИСЛО                  ");
            Console.WriteLine("============================================");

            Random random = new Random();
            int secretNumber = random.Next(1, 101);

            Console.WriteLine("Я загадал число от 1 до 100. Попробуй угадать!");
            Console.WriteLine();

            int guess = 0;
            int attempts = 0;
            int low = 1;
            int high = 100;

            while (guess != secretNumber)
            {
                attempts++;

                Console.Write($"Попытка #{attempts} (число от {low} до {high}). Твой вариант: ");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Ошибка! Введите целое число.");
                    attempts--;
                    continue;
                }

                if (guess < secretNumber)
                {
                    Console.WriteLine("Слишком маленькое число!");
                    if (guess > low) low = guess + 1;
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Слишком большое число!");
                    if (guess < high) high = guess - 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine("============================================");
            Console.WriteLine($"Поздравляю! Ты угадал число {secretNumber} за {attempts} попыток!");
            Console.WriteLine("============================================");

            Console.WriteLine("\nНажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
