Console.WriteLine(" Введите первое число");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Введите второе число");

int number2 = Convert.ToInt32(Console.ReadLine());

int max;
if (number1 > number2)
{
    max = number1;
    Console.WriteLine("max = " + max);
}
else if (number1 < number2)
{
    max = number2;
    Console.WriteLine("max = " + max);
}
else

Console.WriteLine("Числа равны");


