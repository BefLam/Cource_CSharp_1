// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.
int lengthNum(int num)
{
    int a = 0;
    for (int i = 1; num > 0; i++)
       {
        num = num / 10;
        a++;
       }
    return a;   
}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = lengthNum(num);
Console.WriteLine(result);