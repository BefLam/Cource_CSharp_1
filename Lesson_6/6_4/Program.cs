// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
//    Первые два числа Фибоначчи: 0 и 1.

void Fib(int A)
{
    int FirstNumber = 0;
    int SecondNumber = 1;
    for (int i = 0; i < A; i++)
    {
        Console.Write(FirstNumber + " ");
        (FirstNumber, SecondNumber) = (SecondNumber, FirstNumber + SecondNumber);
    }
}
int a = int.Parse(Console.ReadLine()!);
Fib(a);

