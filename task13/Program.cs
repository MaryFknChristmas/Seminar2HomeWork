Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 100 == number)
{
    Console.WriteLine("Нет третьего числа");
}
else
{
    Console.WriteLine(number % 10);
}