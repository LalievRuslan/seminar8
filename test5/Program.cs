/*Задача 62(). Напишите программу, которая заполнит спирально массив 4 на 4. 
( - необязательная)
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] array = new int [4,4];
int sideA = array.GetLength(0);
int sideB = array.GetLength(1);//обозначаем стороны массива
int beginI = 0;
int finalI = 0;
int beginJ = 0; 
int finalJ = 0;//точки начала и конца прямоугольника
int sum = 1;//переменная,которой будем заполнять массив
int i = 0;
int j = 0;
//заполняем массив
while(sum <= sideA * sideB)
{
    array[i,j] = sum;//заполняем массив
    if(i == beginI && j < sideB - finalJ - 1)//обходим прямоугольник
    {
        j++;
    }
    else if(j == sideB - finalJ - 1 && i < sideA - finalI - 1)
    {
        i++;
    }
    else if(i == sideA- finalI -1 && j > beginJ)
    {
        j--;
    }
    else
    {
        i--;
    }
    if((i == beginI + 1) && (j == beginJ) && (beginJ != sideB - finalJ - 1))//после обхода увеличиваем отступы
    {
        beginI++;
        beginJ++;
        finalI++;
        finalJ++;
    }
    sum++;
}
//выводим его на экран
PrintArray(array);

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

//решение честно свистнуто с языка с++ и переложено на с#
//работает для любых размеров массива