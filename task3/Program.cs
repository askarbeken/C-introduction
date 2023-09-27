// Задача 8. Напишите программу, которая принимаеn на вход число (N), а на выходе показывает все четные числа от 1 до N
Console.WriteLine ("Введите число N: ");
int N = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ($"Чётные числа от 1 до {N}: ");
int число = 2;
while (число <= N)
{
    Console.WriteLine (число);
    число += 2;
}
