Console.WriteLine("Введите цифру");
int number = Convert.ToInt32(Console.ReadLine());
Task15(number);

void Task15(int currentNumber)
{
    if (currentNumber == 1)
        {
            Console.WriteLine("Нет, это Понедельник!");
        }

    if (currentNumber == 2)
        {
            Console.WriteLine("Нет, это Вторник!");
        }

    if (currentNumber == 3)
        {
            Console.WriteLine("Нет, это Среда!");
        }

    if (currentNumber == 4)
        {
            Console.WriteLine("Нет, это Четверг!");
        }

    if (currentNumber == 5)
        {
            Console.WriteLine("Нет, это Пятница!");
        }

    if (currentNumber == 6)
        {
            Console.WriteLine("Да, это Суббота!");
        }

    if (currentNumber == 7)
        {
            Console.WriteLine("Да, это Воскресенье!");
        }
}