int TakeNum(int A)
{
    Console.WriteLine(A);
    return A % 10;
}

int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(result);