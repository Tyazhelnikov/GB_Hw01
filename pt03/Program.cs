// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();

Console.WriteLine("Введите  число ");

try {
     int first = Convert.ToInt32(Console.ReadLine());
     if (first%2 > 0 ){
           Console.WriteLine($"Число {first} - не четное"); 
     }  
     else Console.WriteLine($"Число {first} -  четное"); 
}
catch (FormatException e)
        {
            Console.WriteLine(e.Message);            
        }