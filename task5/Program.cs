// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Write("Введите число: ");
string number = Console.ReadLine();
if (number.Length >= 3)
{
    string thirdDigit = new string(number[2], 1);
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}