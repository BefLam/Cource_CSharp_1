// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.

string ConvertBin(int num)
{
    string result = "";
    while (num < 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    
    return result;
}
int A = int.Parse(Console.ReadLine()!);
string res2 = ConvertBin(A);
Console.WriteLine(res2);
