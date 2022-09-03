void weekday ()
{
try
{
    Console.Write("введите цифру дня недели ");
    int number = int.Parse(Console.ReadLine());
    if (number == 6 || number==7)
    {
        Console.WriteLine("гуляем! ");
    }
    else 
    {
        Console.Write("эм... вроде не выходной. ну да ладно, гуляем!");
    }
}
catch
{
    Console.Write("кажется мы друг друга недопоняли");
}
}

weekday();