int Yes (int Number)
{
    while (Number > 999)
    {
        Number = Number /= 10;
    }
    return Number = Number % 10; 
}
   
bool No (int Number)
{
    if (Number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }  
    return true;
}
 int Number = Yes(int.Parse(Console.ReadLine()!));
if (No(Number))
{
    Console.WriteLine(Yes (Number));
}