﻿int Power(int A, int B)
{
    if(B==0) return 1;
    return A * Power(A, B - 1);
}

int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(Power(A,B));