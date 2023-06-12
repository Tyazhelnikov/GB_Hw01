Console.Clear();

try {
    int[] numbers = new int[3];
    
    for (int i = 0;i < numbers.Length;i++ ) {
        
        Console.WriteLine("Введите число ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());   
           
    }

    Console.WriteLine("Largest Element: " + numbers.Max());      
}
catch (FormatException e)
        {
            Console.WriteLine(e.Message);            
        }


