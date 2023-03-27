//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine())!;
}

int[,] Create(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill(int[,] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(minValue, maxValue + 1);
}

string Print(int[,] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res += array[i, j];
            if (j != array.GetLength(1) - 1)
                res += "\t";
            else
                res += "\n";
        }
    return res;
}

double[] ColumnAverage(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
            average[i] += array[j, i];
        average[i] /= array.GetLength(0);
    }
    return average;
}

string PrintDoubleArray(double[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += Math.Round(array[i], 2);
        if(i != array.Length - 1) res += "; ";
        else res += ".";
    }
    return res;
}

int numRows = InputNum("Введите количество строк: ");
int numCols = InputNum("Введите количество столбцов: ");
int[,] myArray = Create(numRows, numCols);
int min = InputNum("Введите минимальное значение: ");
int max = InputNum("Введите максимальное значение: ");
Fill(myArray, min, max);
string result = Print(myArray);
Console.WriteLine(result);

double[] avg = ColumnAverage(myArray);
string avgs = PrintDoubleArray(avg);
Console.WriteLine(avgs);