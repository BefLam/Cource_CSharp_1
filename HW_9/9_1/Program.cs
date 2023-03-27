void Rec( int M, int N)
{
    if (M > N) return;
    else if (N % 2 == 0)
    {
        Rec(M, N - 2);
        Console.Write($"{N}, ");
    }
    else if (N % 2 != 0)
    {
        N -= 1;
        Rec(M, N - 2);
        Console.Write($"{N}, ");
    }
    
}
int M = int.Parse(Console.ReadLine()!);
int N = int.Parse(Console.ReadLine()!);
Rec(M, N);