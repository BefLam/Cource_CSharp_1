//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine())!;
}

double[,] Create(int rows, int columns)
{
    return new double[rows, columns];
}

void Fill(double[,] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(rnd.NextDouble() + rnd.Next(minValue, maxValue), 2);
}

string Print(double[,] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res += array[i, j];
            if (j != array.GetLength(1) - 1)
                res += ";\t";
            else
                res += "\n";
        }
    return res;
}

int NumRows = InputNum("Введите количество строк: ");
int NumCols = InputNum("Введите количество столбцов: ");
double[,] myArray = Create(NumRows, NumCols);
int min = InputNum("Введите первое значение: ");
int max = InputNum("Введите второе значение: ");
Fill(myArray, min, max);
string result = Print(myArray);
Console.WriteLine(result);