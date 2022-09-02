
int number2 = int.Parse(Console.ReadLine());
int ost = 0;
if (number2%number1 == 0)
{   
    
    Console.Write(number2+",");
    Console.Write(number1+"->");
    Console.Write("кратно");
}
else int number1 = int.Parse(Console.ReadLine());
{
    Console.Write(number2+",");
    Console.Write(number1+"->не кратно. остаток ");
    ost = number2%number1;
    Console.WriteLine(ost);
}

