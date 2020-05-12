using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        int gewinn = -1000;
        Random rand = new Random();
        for (int i = 1; i <= 1000; i++)
        {
            int wurf = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            //Console.WriteLine(wurf);
            if (wurf == 16) gewinn += 5;
            else if (wurf == 17) gewinn += 10;
            else if (wurf == 18) gewinn += 100;

        }
        Console.WriteLine(gewinn);
    }
}