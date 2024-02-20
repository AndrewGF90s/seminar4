
// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]
int[] array = {1,3,5,6,7,8};
int temp = 0;
       for (int i = 0, j = array.Length -1; i < j ; i++, j--) {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
       }
        for (int i = 0;i < array.Length; i++) {
             Console.Write(array[i]+ " "); 
        }
                

