void Yes (int Number)
{
    if (Number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return;
    }  
    while (Number > 999)
    {
        Number = Number /= 10;
    }
   Console.WriteLine(Number % 10); 
}

Yes(int.Parse(Console.ReadLine()!));

