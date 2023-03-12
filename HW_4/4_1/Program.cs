//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int SumNum(int num1, int num2)
{
    int all_sum = num1;
    for (int i = 1; i <= num2-1; i++)
        all_sum *= num1;
    return all_sum;
}

int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
int result =  SumNum(A, B);
Console.WriteLine(result);