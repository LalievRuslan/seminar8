/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

//Задаем метод для заполнения двумерного массива
int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i,j] = new Random().Next(min,max);
        }
    }
    return result;
}

//задаем метод для вывода двумерного массива на экран
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

//Задаем метод сортировки по строкам
void SortArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           for(int k = j + 1; k < array.GetLength(1); k++)//применим пузырьковый метод сортировки для каждой строки
           {
             if(array[i,j] < array[i,k])
            {
                int temp = array[i,j];
                array[i,j] = array[i,k];
                array[i,k] = temp;
            }
           }
        }
    }
}

//задаем рандомом количество строк и столбцов массива
int rows = new Random().Next(2,10);
int columns = new Random().Next(2,10);

//заполняем массив случайными числами и выводим на экран
int[,] array = GetArray(rows, columns, 0, 20);
PrintArray(array);
Console.WriteLine();

//применяем метод сортировки по строкам и выводим результат
SortArray(array);
PrintArray(array);