void SoVonderful ()
{
try
{
    Console.Write("число разрядов (от 2 до 9) ");
    Double m = Double.Parse(Console.ReadLine());
    int i = 0;
    int k = 10;
    int x = new Random().Next(1, (int)Math.Pow((Double)10,m));
    Console.WriteLine(x);
    Console.Write(x/(((int)Math.Pow((Double)10,(m-1)))));
    x=x-x/(((int)Math.Pow((Double)10,(m-1))))*(int)Math.Pow((Double)10,(m-1));
    x= x-x/(((int)Math.Pow((Double)10,(m-2))))*(int)Math.Pow((Double)10,(m-2));
    i=2;
    while (i < m)
    {   
        Console.Write(x/(((int)Math.Pow((Double)10,(m-i-1)))));
        x= x-x/(((int)Math.Pow((Double)10,(m-i-1))))*(int)Math.Pow((Double)10,(m-i-1));
        i++;
        k=k/10;
    }
}
catch
{
    Console.Write("введите _число_(от 2 до 9)");
}
}
SoVonderful ();