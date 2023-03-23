//Задайте занчение N. Напишите программу, которая
// выведет все натуральные числав промежутке
// от 1 до N при помощи рекурсии.

void SeriesNums(int N)
{

    if (N == 0) return;
    SeriesNums(N - 1);
    Console.Write($"{N}, ");

}

SeriesNums(int.Parse(Console.ReadLine()!));