//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
void Main()
{
    int[,] arr = new int[5, 6];
    int rows = arr.GetLength(0) - 1;
    Console.WriteLine(rows);

    int cols = arr.GetLength(1) - 1;
    Console.WriteLine(cols);

    arr = GetArray(arr);
    PrintArray(arr);
    int[,] newArray = SwitchRows(arr, rows, cols);
    PrintArray(newArray);

}

int[,] GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
int[,] SwitchRows(int[,] arr, int rows, int cols)
{

    int temp = 0;
    for (int j = 0; j < cols; j++)
    {
        temp = arr[0, j];
        arr[0, j] = arr[rows, j];
        arr[rows, j] = temp;

    }

    return arr;

}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" array = {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Main();
