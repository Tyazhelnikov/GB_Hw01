// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

Console.WriteLine("Введите первое число ");

try {
     int first = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите второе число ");
     int second = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine($"максимальное значение: {Math.Max(first, second)}, минимальное значение: {Math.Min(first, second)} ");     
}
catch (FormatException e)
        {
            Console.WriteLine(e.Message);            
        }





