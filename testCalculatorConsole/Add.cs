using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCalculatorConsole
{
    class Add
    {

       public void add(double x, double y)
        {

            Global.sonuc = x + y;
            Console.WriteLine("Sonuc: "+ Global.sonuc);
            Console.WriteLine("Yeni bir işlem için herhangi bir tuşa basınız.");
            Console.ReadLine();

       
        }
    }
}
