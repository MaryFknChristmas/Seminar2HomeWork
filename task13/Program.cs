Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 100 == number)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    Console.WriteLine(number % 10);
}