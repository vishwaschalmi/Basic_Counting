using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your number to start counting: \n");
        int Input = int.Parse(Console.ReadLine());
        int i = 0;
        while (i <= Input)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}