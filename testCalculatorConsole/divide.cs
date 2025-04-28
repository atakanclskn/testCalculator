using System;


public class Divide
{
    public void DivideNumbers(double x, double y)
    {
        if (y == 0)
        {
            Console.WriteLine("Hata: Bir sayı sıfıra bölünemez.");
        }
        else
        {
            Console.WriteLine($"Bölme Sonucu: {x / y}");
        }
    }
}
																																																																																			