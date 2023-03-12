//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

void Posit(int[] arr)
{
    int Col = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            Col += arr[i];
    }
    Console.WriteLine($"сумма нечётных чисел в массиве: {Col}");
}


Console.WriteLine("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите стартовое значение: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конечное значение: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
Posit(mass);