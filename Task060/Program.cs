// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int EnterNumbers(string msg)
{
    int num;
    System.Console.WriteLine(msg);
    while (!int.TryParse(Console.ReadLine(), out num))
    {
         Console.WriteLine("This is not number! Please enter number!");
    }
    return num;
}

void FillArray(int[,,] arr)
{
   Random rnd = new Random();
 
   for(int i = 0; i < arr.GetLength(0); i++)
   {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int z = 0; z < arr.GetLength(2); z++)
            {
                arr[i, j, z] = rnd.Next(1, 51);
                if (i != 0 & j != 0 & z != 0)
                {                
                CheckArr(arr, i, j, z);
                }
            }
        }
   } 
}

int CheckArr(int[,,] arr, int i, int j, int z)
{
 Random rnd = new Random();   
   for (int ii = 0; ii <= i; ii++)
   {
        for (int jj = 0; jj <= j; jj++)
        {
            for (int zz = 0; zz <= z; zz++)
            {
                if (arr[i, j, z] == arr[ii, jj, zz])
                    {
                        arr[i, j, z] = rnd.Next(1, 51);
                    }
            }            
        }
   }  
 return arr[i, j, z];
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                Console.Write($"{arr[i,j,z]}  ({i}, {j}, {z}) |  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Task060()
{
    int i = EnterNumbers("Please enter number of string I");
    int j = EnterNumbers("number of columns J");
    int z = EnterNumbers("number of columns Z");
    int[,,] arr = new int[i, j, z];
    FillArray(arr);
    Console.WriteLine();
    PrintArray(arr);
}

Task060();


