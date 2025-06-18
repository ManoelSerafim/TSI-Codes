using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.conversão
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            /*
            int intnota = 8;
            double dblnota = intnota;
            Console.WriteLine(dblnota);

            dblnota = 10.3456;
            intnota = (int)dblnota;
            Console.WriteLine(intnota);
            */

            string strNome = "123";
            int intIdade = 22;
            double dblMedia = 8.23;
            bool boolMatriculado = true;

            Console.WriteLine(Convert.ToString(intIdade));
            Console.WriteLine(Convert.ToDouble(intIdade));
            Console.WriteLine(Convert.ToInt32(dblMedia));
            Console.WriteLine(Convert.ToString(boolMatriculado));

            Console.WriteLine(Convert.ToInt32(strNome));
        }
    }
}
