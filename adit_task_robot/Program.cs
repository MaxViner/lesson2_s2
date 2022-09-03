void robotcounter ()
{
try
{
    Console.Write("число кожаных мешков? ");
    int number = int.Parse(Console.ReadLine());
    if (number%10 == 5 || number%10 == 6 ||number%10 == 7 ||number%10 == 8 ||number%10 == 9 ||number%10 == 0 )
    {
        Console.WriteLine(number + " програмистов ");
    }
    else if (number%10 == 1)
    {
        Console.Write(number + " програмист ");
    }
    else
    {
        Console.Write(number + " програмистa ");
    }
}
catch
{
    Console.Write("я не моч ");
}
}

robotcounter ();