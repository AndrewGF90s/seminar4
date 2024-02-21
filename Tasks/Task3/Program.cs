// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при 
// вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

bool exit = true;
while (exit == true)
{
    Console.WriteLine("Введите целое, трехзначное  число");
    string number = Console.ReadLine();
    if (number != "q")
    {
        int number1 = Convert.ToInt32(number);
        int leftDigit = number1 / 100;
        int midleDigit = number1 % 100 / 10;
        int rightDigit = number1 % 10;
        int sumNumber = leftDigit + midleDigit + rightDigit;
        if (number1 < 99 && number1 < 1000)
        {
            Console.WriteLine($" Вы ввели не трехзначное  число  попробуйте ещё");
        }
        else if (number1 % 1 != 0)
        {
            Console.WriteLine($" Вы ввели не целое число ");
        }
        else if (sumNumber % 2 == 0)
        {
            Console.WriteLine($"Сумма введенных чилел четная ");
            exit = false;
        }
    }
    else
    {
        Console.WriteLine("Вы ввели символ q");
        exit = false;
    }

}



