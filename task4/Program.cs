// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Введите трёхзначное число: ");
string input = Console.ReadLine();
if (input.Length == 3 && input [0] >= '0' && input [1] <= '9' && input[1] >= '0' && input[1] <= '9' && input[2] >= '0' && input[2] <= '9')
{
    int secondDigit = (input[1] - '0');
    Console.WriteLine($"Вторая цифра числа: {secondDigit}");
}
else
{
    Console.WriteLine("Неправильно! Введите трёхзначное число, пожалуйста");
}
