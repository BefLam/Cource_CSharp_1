void massive(int mas)
{
    int[] numbers = new int[mas];
    for (int i = 0; i < mas; i++)
    {
        numbers[i] = new Random().Next(2);
        Console.Write(numbers[i]);
    }

}
massive(8);