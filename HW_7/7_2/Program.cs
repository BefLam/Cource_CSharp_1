//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

bool SearchNumByIndexes(int rows, int cols, int indI, int indJ)
{
    return indI > 0 && indJ > 0 && indI <= rows && indJ <= cols;
}

string IsElement(bool check, int[,] array, int indI, int indJ)
{
    string ans = "Это не число c такими индексами.";
    if(check == true) ans = $"Значение числа равно {array[indI - 1, indJ - 1]}.";
    return ans;
}

int numRows = InputNum("Введите количество строк: ");
int numCols = InputNum("Введите количество столбцов: ");
int[,] myArray = Create(numRows, numCols);
int min = InputNum("Введите минимальное значение: ");
int max = InputNum("Введите максимальное значение: ");
Fill(myArray, min, max);
string result = Print(myArray);
Console.WriteLine(result);

int numRow = InputNum("Введите индекс строки: ");
int numCol = InputNum("Введите индекс столбца: ");

bool check = SearchNumByIndexes(numRows, numCols, numRow, numCol);
string element = IsElement(check, myArray, numRow, numCol);
Console.WriteLine(element);