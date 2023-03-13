// 4. Напишите программу, которая будет создавать
//    копию заданного массива с помощью поэлементного копирования.

int[,] FillMass(int rows, int columns, int from, int to)
{
    int[,] Array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Array[i, j] = new Random().Next(from, to);
        }
    }
    return Array;
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }

}

int[,] CopyMass(int[,] arr)
{
    int row = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int[,] NewArr = new int[row, columns];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            NewArr[i, j] = arr[i, j];
        }
    }
    return NewArr;
}

int[,]mass = FillMass(3, 4, 1, 11);
Print(mass);
Console.WriteLine();
int[,]NewMass = CopyMass(mass);
Print(NewMass);

