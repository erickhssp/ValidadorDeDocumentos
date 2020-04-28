using Caelum.Stella.CSharp.Inwords;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 75;
            var extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);


            valor = 1532987;
            extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            Debug.WriteLine(extenso);

            string extensoBLR = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBLR);

            valor = 1532987.89; // com centavos

            extensoBLR = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBLR);

        }
    }
}
