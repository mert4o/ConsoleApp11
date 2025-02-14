using System;

class Program
{
    
    static int Reverse(int n, int reversed = 0)
    {
       
        if (n == 0)
            return reversed;

        
        int lastDigit = n % 10;
        reversed = reversed * 10 + lastDigit;

        
        return Reverse(n / 10, reversed);
    }

    static void Main(string[] args)
    {
        Console.Write("Въведете число: ");
        int num = int.Parse(Console.ReadLine());

        int reversedNum = Reverse(num);
        Console.WriteLine($"Обръщането на числото {num} е {reversedNum}.");
    }
}

