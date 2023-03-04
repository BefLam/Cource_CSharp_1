int Num(int A)
{
    Console.WriteLine(A);
    int num1 = A / 10 % 10;
    return num1;
}

int result = Num(new Random().Next(100, 1000));
Console.WriteLine(result);