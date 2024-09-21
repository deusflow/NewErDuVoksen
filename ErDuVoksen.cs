using System;

class Program
{
    static void Main(string[] args)
    {
        int возраст = 30;
        double рост = 180.5;
        string имя = "Олежик";

        if (возраст > 18)
        {
            Console.WriteLine(имя + ", ты взрослый!");
        }
        else
        {
            Console.WriteLine(имя + ", ты ребенок.");
        }
    }
}