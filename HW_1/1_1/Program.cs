Console.Write("Введите 1 значение: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 значение: ");
int B = int.Parse(Console.ReadLine()!);
if (A < B)
{
    Console.Write("Min = ");
    Console.WriteLine(A);
    Console.Write("Max = ");
    Console.Write(B);
}
else if (A > B)
{
    Console.Write("Min = ");
    Console.WriteLine(B);
    Console.Write("Max = ");
    Console.Write(A);
}
else if (A == B)
{
    Console.Write("ERROR");
}
