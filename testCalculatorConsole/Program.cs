using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCalculatorConsole
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            

            do
            {
                Console.WriteLine("1.Sayıyı girin");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Yapmak istediğiniz işlemin simgesini yazınız.(+,-,*,/)");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "+":
                        Add a = new Add();
                        a.add(x);
                        break;
                    case "-":
                        Subtract b = new Subtract();
                        b.subtract(x);
                        break;
                    case "*":
                        Multiply c = new Multiply();
                        c.multiply(x);
                        break;
                    case "/":
                        Divide d = new Divide();
                        d.divide(x);
                        break;
                    default:
                        Console.WriteLine($"Geçersiz seçim yaptınız. Sonuc:{x}");
                        break;
                }

                
            } while (true);


        }
        
    }
    
}
