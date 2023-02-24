Console.Write("Введите 1 значение: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 значение: ");
int B = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3 значение: ");
int C = int.Parse(Console.ReadLine()!);
 int Max = A;
if (Max < B)
{
    Max = B;
}
if (Max < C)
{
    Max = C;
}
Console.Write("Максимальное чисто= ");
Console.WriteLine(Max);

