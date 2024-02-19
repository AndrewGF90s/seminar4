// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая
//  покажет количество чётных чисел в массиве.
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new  int[number];
    for(int i = 0; i < number; i++ ) {
        array[i] = new Random().Next(99,1000);

    }
    for(int i = 0; i < number; i++ ) {
        Console.WriteLine(array[i] +"");
    }