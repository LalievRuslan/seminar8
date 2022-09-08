/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

/*Вспоминаем что-то про матрицы:
Матрицу P можно умножить на матрицу K только в том случае, 
если число столбцов матрицы P равняется числу строк матрицы K. 
Матрицы, для которых данное условие не выполняется, умножать нельзя.
Соответственно, задавая массивы, нужно прописать, что число строк у второй матрицы должно быть равно
числу столбцов у первой.
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

//теперь вспоминаем что-то про нахождение произведения матриц и создаем метод,
//который будет брать два массива и выдавать третий, который является их произведением
int[,] MatrixProduct(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int [firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            for(int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                result[i,j] = result[i,j] + firstMatrix[i,k] * secondMatrix[k,j];//главное не запутаться в индексах
            }
        }
    }
    return result;
}

//задаем рандомом количество строк и столбцов массива
int rows = new Random().Next(2,5);
int columns = new Random().Next(2,5);

//задаем две матрицы и выводим их на экран, причем количество столбцов первой матрицы будет равно количеству строк второй и наобарот
int[,] firstMatrix = GetArray(rows, columns, 1, 5);
int[,] secondMatrix = GetArray(columns, rows, 1, 5);
PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
Console.WriteLine();

//применяем метод и находим матрицу - произведение и выводим ее на экран
int[,] resultMatrix = MatrixProduct(firstMatrix, secondMatrix);
Console.WriteLine("Результирующая матрица равна:");
PrintArray(resultMatrix);