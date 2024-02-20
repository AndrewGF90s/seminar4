// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при 
// вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
int q = 8912;
int leftDigit = number / 100 ; 
int midleDigit = number %100 / 10;
int rightDigit = number % 10;
int sumNumber = leftDigit + midleDigit + rightDigit;
 

 for (;;) {giveMenumber ();}
 giveMenumber (); {

    Console.WriteLine("Введите целое, трехзначное  число");
int number = Convert.ToInt32(Console.ReadLine());
 
    if (number > 99 && number <1000) {
        if(number % 2 == 0 || number % 2 == 1 ) {
       
            if (number == q) {
                break;
            }
            else if (sumNumber % 2 == 0) {
                break;
            }
        }

    } 

    }
    
    Console.WriteLine($" {leftDigit}Введите {midleDigit}целое{rightDigit} число{sumNumber}");



