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
                        Summary a = new Summary();
                        a.sum(x);
                        break;
                    case "-":
                        Subtract b = new Subtract();
                        //b.Method();
                        break;
                    case "*":
                        Multiply c = new Multiply();
                        //c.Method();
                        break;
                    case "/":
                        Divide d = new Divide();
                        //d.Method();
                        break;
                    default:
                        Console.WriteLine($"Geçersiz seçim yaptınız. Sonuc:{x}");
                        break;
                }

                
            } while (true);


        }
        
    }
    
}
