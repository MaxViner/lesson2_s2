void Compare ()
{
int number = int.Parse(Console.ReadLine());
if (number % 7 == 0 | number % 14 == 0) 
{
Console.WriteLine("да");
}
else Console.WriteLine("нет");
}
Compare();


