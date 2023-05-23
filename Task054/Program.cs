// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArray(int[,] arr)
{
   Random rnd = new Random(); 
   for(int i = 0; i < arr.GetLength(0); i++)
   {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 11);
        }
   } 
}

void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)//переключатель строк
    {
        for (int ij = 0; ij < arr.GetLength(1)-1; ij++)
        {
            for (int j = arr.GetLength(1) - 1; j > 0; j--) //перебор столбцов
            {
                if (arr[i, j] > arr[i, j - 1])              //замена местами
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, j - 1];
                    arr[i, j - 1] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void Task054()
{
    int[,] arr = new int[3, 4];
    FillArray(arr);
    PrintArray(arr);
    SortArray(arr);
    PrintArray(arr);
}

Task054();

