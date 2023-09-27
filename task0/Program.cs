// Задача 2. Напишите программу, которая даёт на вход два числа, какое число большее, а какое меньшее
Console.WriteLine ("Введите первое число: ");
double число1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double число2 = Convert.ToDouble (Console.ReadLine());
if (число1 > число2)
{
Console.WriteLine ($"{число1} больше, чем {число2}");
Console.WriteLine ($"{число2} меньше, чем {число1}");
}
else if (число1 < число2)
{
Console.WriteLine ($"{число2} больше, чем {число1}");
Console.WriteLine ($"{число1} меньше, чем {число2}");
}
else
{
  Console.WriteLine ($"{число1} и {число2} равны.");  
}