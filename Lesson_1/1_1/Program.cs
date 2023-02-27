Console.WriteLine("Введите 1 число: ");
string A = Console.ReadLine()!;
Console.WriteLine("Введите 2 число: ");
string B = Console.ReadLine()!;
int num1 = int.Parse(A);
int num2 = int.Parse(B);
if  (num2 * num2 == num1)
{
    Console.WriteLine("Да");

}
else
{
    Console.WriteLine("Нет");

}
