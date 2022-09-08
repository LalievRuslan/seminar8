/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных 
чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

//Ищем как объявлять трехмерный массив
//поскольку в задаче не сказано, каким образом мы его будем задавать, 
//зададим его с фиксированным размером, чтобы много не выводить на экран

int[,,] treeDimensionalArray = new int [2,2,2];

//Применяем методы
treeDimensionalArray = GetTreeDimensionalArray(treeDimensionalArray);
PrintTreeDimensionalArray(treeDimensionalArray);

//сделаем метод по заполнению трехмерного массива числами используя обычный сумматор, тогда числа точно не будут повторяться

int[,,] GetTreeDimensionalArray(int[,,] array)
{
    int sum = 1;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = sum;
                sum = sum + array[i,j,k];
            }
        }
    }
    return array;
}


//теперь сделаем метод для построчного вывода
void PrintTreeDimensionalArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}