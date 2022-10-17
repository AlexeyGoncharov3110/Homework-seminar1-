Console.WriteLine(" Введите число");

int number = Convert.ToInt32(Console.ReadLine());

int count = 0;

int even;

while (count <= number)
{
    if (count % 2 == 0)
    {
        even=count;
        Console.Write(even + ",");
    }
    count++;
}
