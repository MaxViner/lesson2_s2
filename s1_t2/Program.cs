void secondNum ()
{
try
{
    Console.Write("введите-Ка трехзначное число ");
    int number = int.Parse(Console.ReadLine());
    if (number-100 > 0&&number-1000 < 0)
    {
        Console.WriteLine("вторая цифра- "+((number / 10) % 10));
    }
    else 
    {
        Console.Write("кажется мы друг друга недопоняли");
    }
}
catch
{
    Console.Write("кажется мы друг друга недопоняли");
}
}

secondNum();