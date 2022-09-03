void thirdDigit ()
{
try
{
    Console.Write("введите-Ка трехзначное число ");
    int number = int.Parse(Console.ReadLine());
    if (number-100 > 0&&number-1000 < 0)
    {
        Console.WriteLine("третья цифра - "+(number  % 10));
    }
    else 
    {
        Console.Write("число-То не треХзначное 0_о");
    }
}
catch
{
    Console.Write("кажется мы друг друга недопоняли");
}
}

thirdDigit ();


