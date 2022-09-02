int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if (number2*number2 == number1) 
{   
    Console.Write(number1);
    Console.Write(number2);
    Console.Write("второе - квадрат первого");
}
else if (number1*number1 == number2) 
{
    Console.Write("первое - квадрат второго");
}
else 
{
    Console.Write("нет");
}