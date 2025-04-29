using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace testCalculatorConsole
{
    
    public class Program
    {
        
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("1.Sayıyı girin");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayıyı girin");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlemin simgesini yazınız.(+,-,*,/)");
            string input = Console.ReadLine();

            do
            {
                Console.WriteLine("Sonucunuza yeni bir sayı eklemek istiyorsanız giriniz istemiyorsanız = yazınız.");
                string extra = Console.ReadLine();
                double Intextra = Convert.ToDouble(extra);


                if (input == "=")
                {
                    switch (input)
                    {
                        case "+":
                            Add a = new Add();
                            a.add(x, y);
                            break;
                        case "-":
                            Subtract b = new Subtract();
                            b.subtract(x, y);
                            break;
                        case "*":
                            Multiply c = new Multiply();
                            c.multiply(x, y);
                            break;
                        case "/":
                            Divide d = new Divide();
                            d.divide(x, y);
                            break;
                        default:
                            Console.WriteLine($"Geçersiz seçim yaptınız. Sonuc:{Global.sonuc}");
                            break;
                    }

                }
                else
                {

                    do
                    {

                        switch (input)
                        {
                            case "+":
                                Add a = new Add();
                                a.add(x, y);
                                break;
                            case "-":
                                Subtract b = new Subtract();
                                b.subtract(x, y);
                                break;
                            case "*":
                                Multiply c = new Multiply();
                                c.multiply(x, y);
                                break;
                            case "/":
                                Divide d = new Divide();
                                d.divide(x, y);
                                break;
                            default:
                                Console.WriteLine($"Geçersiz seçim yaptınız. Sonuc:{Global.sonuc}");
                                break;
                        }

                        Global.sonuc = x;
                        Intextra = y;

                    } while (input == "=");
                }
            }while (input == "=");

            Console.WriteLine("Sonuc: " + Global.sonuc);

        }
        
    }
    
}
