using Caelum.Stella.CSharp.Vault;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            //soma
            //subtração

            Money euro = new Money(Currency.EUR, 1000);
            Debug.WriteLine(euro);

            Money dolar = new Money(Currency.USD, 1000);
            Debug.WriteLine(dolar);

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Debug.WriteLine(dolar);
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

            //não é possivel realizar operações com moedas diferentes,somente após converte-lás.

            //Money somaMoedasDiferentes = euro + dolar;  
            //Debug.WriteLine(somaMoedasDiferentes);
        }
    }
}
