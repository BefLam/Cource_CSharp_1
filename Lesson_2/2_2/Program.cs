int MaxNum(int A)
{
    Console.WriteLine(A);
    int num1 = A / 10;
    int num2 = A % 10;
    if (num1 > num2) return num1;
    return num2;
}

int result = MaxNum(new Random().Next(10, 100));
Console.WriteLine(result);
