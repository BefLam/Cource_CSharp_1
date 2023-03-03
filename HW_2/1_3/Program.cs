void Weekend (int num)

{
    string text = "no";
    if (num == 7 || num == 6) text = "Weekend"  ;
    else if (num < 6 && num > 0) text = "Workday";
    else text = " not a week day";
    Console.WriteLine($"{num} -> {text}");
}
Weekend(int.Parse(Console.ReadLine()!));