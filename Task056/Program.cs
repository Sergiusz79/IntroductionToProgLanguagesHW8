// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void SumStringArray(int[] str, int[,] arr)
{   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            str[i] += arr[i,j];    
        }
    }
    return; 
}

void MinStringArray(int[] str)
{
   int strmin = 0;
   for (int i = 1; i < str.GetLength(0); i++)
   {
        if (str[i-1] > str[i]) {strmin = i+1;}
   }
   Console.WriteLine($"Cтрока > {strmin} < имеет самую минимальную сумму.");
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

void Task056()
{
    int[,] arr = new int[4, 5];
    int[] str = new int[arr.GetLength(0)];
    FillArray(arr);
    PrintArray(arr);
    SumStringArray(str, arr);
    MinStringArray(str);
}


Task056();

