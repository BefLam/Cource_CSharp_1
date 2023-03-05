int Num(int A)
{
    Console.WriteLine(A);
    int num1 = A / 10000;
    int num2 = A % 10 ;
    int num3 = A / 1000 % 10;
    int num4 = A / 10 % 10;
    int True = 1;
    int False = 2;
    if (num1 == num2 && num3 == num4) return True;
    return False;
}

int Res = Num(new Random().Next(10000, 100000));
if (Res < 2)
{
    Console.WriteLine("Yes");
}
else Console.WriteLine("No");


//Второй вариант решения данной задачи!

//void Palindrom (string numbers)
//{
   
//    if (numbers[0] == numbers[4] && numbers[1] == numbers[3])
//    {
//        Console.WriteLine("Да");
//    }
//    else Console.WriteLine("Нет");
//}
//Palindrom(Console.ReadLine());
