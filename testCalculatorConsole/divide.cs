using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCalculatorConsole
{
    class Divide
    {
        public void divide(double x)
        {
            Console.WriteLine("2.Sayıyı girin");
            double y = Convert.ToDouble(Console.ReadLine());

            double sonuc;

            sonuc = x / y;
            Console.WriteLine("Sonuc: " + sonuc);
            Console.WriteLine("Yeni bir işlem için herhangi bir tuşa basınız.");
            Console.ReadLine();


        }
    }
}
