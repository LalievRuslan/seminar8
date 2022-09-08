/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с
наименьшей суммой элементов: 1 строка*/

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

//Задаем метод, который будет считать сумму элементов в каждой строке и выдавать одномерный массив, заполненный суммами строк
int[] SumRow(int[,] array)
{
    int[] result = new int [array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           result[i] = result[i] + array[i,j];
        }
    }
    return result;
}

//задаем метод, который будет находить минимальный элемент одномерного массива и возвращать его индекс
int MinValueIndex(int[] array)
{
    int result = 0;
    int minValue = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < minValue)
        {
            result = i;
            minValue = array[i];
        }
    }
    return result;
}

//задаем рандомом количество строк, так как массив должен быть прямоугольным столбцы равны строкам
int rows = new Random().Next(2,10);
int columns = rows;

//заполняем массив случайными числами и выводим на экран
int[,] array = GetArray(rows, columns, 0, 20);
PrintArray(array);
Console.WriteLine();

//применяем методы по нахождению суммы строк и выводу НОМЕРА строки
//поскольку в примере указан номер, а не индекс, просто прибавим единицу
int[] sumRow = SumRow(array);
for(int i = 0; i < sumRow.Length; i++)
{
    Console.Write($"{sumRow[i]} ");//для наглядности выведем суммы строк
}
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов равен {MinValueIndex(sumRow) + 1}");