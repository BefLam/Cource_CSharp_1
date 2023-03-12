//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void Diff(int[] arr)
{
    int Max = 0;
    int Min = 10000000;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > Max)
            Max = arr[i];
        if (arr[i] < Min)
            Min = arr[i];    
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом: {Max - Min}");

}


Console.WriteLine("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите стартовое значение: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конечное значение: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
Diff(mass);