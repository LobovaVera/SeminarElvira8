// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
void Main()
{
    Console.WriteLine("Введите число строк");
    int size1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Введите число столбцов");
    int size2 = int.Parse(Console.ReadLine());
    int[,] arr = new int[size1, size2];

    if (size1 != size2)
    {
        Console.WriteLine("Мы не можем заменить строки на столбцы");
       

    }
    else
    {
        GetArray(arr);
        PrintArray(arr);
        SwitchRowsAndCols(arr);     
    
    }


}


void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
 
}

void SwitchRowsAndCols(int[,] arr)
{ int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newArr[i,j] = arr[j,i];


        }
    }
    Console.WriteLine("Новый массив");
    PrintArray (newArr);

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