// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая
//  покажет количество чётных чисел в массиве.
Console.WriteLine("Введите желаемое колличество чисел в массиве");
int number = Convert.ToInt32(Console.ReadLine());
int count =0;
int[] array = new  int[number];
    for(int i = 0; i < number; i++ ) {
        array[i] = new Random().Next(99,1000);
        Console.Write(array[i] +" ");
            if(array[i] % 2 == 0) {
                count += 1;
            }
    }      
    Console.WriteLine($"Колличество четных чисел в массиве равно {count}");