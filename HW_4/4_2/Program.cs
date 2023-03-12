//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNum(int num)
{
    int length = 1;
    int res = 0;
    for (int i = 0; i < length; i++)
    {
        int num1 = num / 1000;
        int num2 = num / 100 % 10;
        int num3 = num / 10 % 10;
        int num4 = num % 10;
        res = num1 + num2 + num3 + num4;
        return res;
    }
    return res;
}

int A = int.Parse(Console.ReadLine()!);
int result =  SumNum(A);
Console.WriteLine(result);