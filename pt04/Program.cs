// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Введите  число ");

try {
    int input = Convert.ToInt32(Console.ReadLine());
     for (int i = 0;i <= input;i++ ){
        if (i%2 == 0 ){
           Console.WriteLine($"  {i}  "); 
        }  

     }      
}
catch (FormatException e){
            Console.WriteLine(e.Message);            
        }