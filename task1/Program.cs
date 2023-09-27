// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine ("Введите первое число: ");
double число1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
double число2 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine ("Введите третье число: ");
double число3 = Convert.ToDouble (Console.ReadLine());
double максимумИзПервыхДвух = Math.Max (число1, число2);
double максимальное = Math.Max (максимумИзПервыхДвух, число3);
Console.WriteLine ($"Максимальное число: {максимальное}");
