Console.WriteLine("Введите число");
string number = Console.ReadLine();
Task13(number);

void Task13(string currentNumber)
{
   if (currentNumber.Length < 3)
     {
       Console.WriteLine("Третьей цифры нет");
     }

   else 
     {
       Console.WriteLine(currentNumber[2]);
     }
}