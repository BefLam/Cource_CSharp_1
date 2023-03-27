int CountNum()
{
    int count = 0;
    string word;

    while (true)
    {
        Console.Write("Output any number: ");
        word = Console.ReadLine()!;

        if (word == "") return count;
        else if (int.Parse(word) > 0) count += 1;
    }
}
int count = CountNum();
Console.WriteLine($"Numbers greater thet zero: {count}");