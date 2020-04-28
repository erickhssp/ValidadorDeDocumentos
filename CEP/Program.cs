using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CEP
{
    class Program
    {
        static void Main(string[] args)
        {
            string cep = "010010007";
            string url = "http://viacep.com.br/ws/" + cep + "/json/";

            var result = new HttpClient().GetStringAsync(url).Result;

            Debug.WriteLine(result);

        }
    }
}
