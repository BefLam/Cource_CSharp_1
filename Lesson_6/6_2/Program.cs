// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.

void Triangle(int A, int B, int C)
{
    if (A < B + C & B < A + C & C < A + B)
        Console.WriteLine("Yes");
    else 
        Console.WriteLine("No");
}
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int num3 = int.Parse(Console.ReadLine()!);
Triangle(num1, num2, num3);