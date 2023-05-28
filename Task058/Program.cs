// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//!Произведение двух матриц АВ имеет смысл только в том случае, 
//когда число столбцов матрицы А совпадает с числом строк матрицы В.

//В произведении матриц АВ число строк равно числу строк матрицы А , 
//а число столбцов равно числу столбцов матрицы В .

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

void FillMatrix(int[,] arr)
{
   Random rnd = new Random(); 
   for(int i = 0; i < arr.GetLength(0); i++)
   {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 11);
        }
   } 
}

void PrintArray(string text, int[,] arr)
{
    Console.WriteLine(text);
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

void MatrixFilling(int[,] amat, int[,] bmat, int[,] cmat)
{
    for (int ai=0; ai < amat.GetLength(0); ai++)
    {
        for (int bj=0; bj < bmat.GetLength(1); bj++)
        {
            for (int aj=0; aj < amat.GetLength(1); aj++)
            {
                cmat[ai,bj] += amat[ai,aj] * bmat[aj,bj]; //aj==bi
            }
        }
    }
    return;
}    

void Task058()
{
    int ai = EnterNumbers("Please enter number of string A");
    int bi = EnterNumbers("Please enter number string B");
    int aj = EnterNumbers("number of columns A");
    int bj = EnterNumbers("number of columns B");
    if (aj == bi)
    {
        int[,] amat = new int[ai, aj];
        int[,] bmat = new int[bi, bj];
        int[,] cmat = new int[ai, bj];
        FillMatrix(amat);
        FillMatrix(bmat);
        PrintArray("Matrix A ", amat);
        PrintArray("Matrix B", bmat);
        MatrixFilling(amat, bmat, cmat);
        PrintArray("Matrix C", cmat);
    }
    else Console.WriteLine("The product of two matrices don't makes sense.");    
}


Task058();

