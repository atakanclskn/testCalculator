using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCalculatorConsole
{
    
internal class Program
    {
        public static void Main()
        {
            do
            {
                Console.WriteLine("Birinci sayıyı girin:");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("İkinci sayıyı girin:");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Bir işlem seçin:");
                Console.WriteLine("1 - Bölme");
                Console.WriteLine("2 - Çarpma");
                Console.WriteLine("3 - Çıkarma");
                Console.WriteLine("4 - Toplama");

                int deger = Convert.ToInt32(Console.ReadLine());

                switch (deger)
                {
                    case 1: // Bölme
                        Divide(x, y);
                        break;

                    case 2: // Çarpma
                        Multiply(x, y);
                        break;

                    case 3: // Çıkarma
                        Subtract(x, y);
                        break;

                    case 4: // Toplama
                        Add(x, y);
                        break;

                    default:
                        Console.WriteLine("Geçersiz bir işlem seçtiniz.");
                        break;
                }

                Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
            } while (Console.ReadLine().ToUpper() == "E");


            public 
        }

    }
    
}
        
