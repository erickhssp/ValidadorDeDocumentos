using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2020, 04, 28);
            Debug.WriteLine(data);
            Debug.WriteLine(data.ToString("d"));
            Debug.WriteLine(data.ToString("d", new CultureInfo("pt-BR")));
            Debug.WriteLine(data.ToString("dd/MM"));
            Debug.WriteLine(data.ToString("dd/MM/yy"));

            data = new DateTime(2020, 04, 28, 13, 14, 31, 987);
            Debug.WriteLine(data);
            Debug.WriteLine(data.ToString("HH:mm"));
            Debug.WriteLine(data.ToString("HH:mm:ss.fff"));

            Debug.WriteLine(data.ToString("D"));
            Debug.WriteLine(data.ToString("m"));
            Debug.WriteLine(data.ToString("Y"));

            Debug.WriteLine(data.ToString("G"));
            Debug.WriteLine(data.ToString("g"));

            Debug.WriteLine(data.ToString("O")); // formato ideal para conversão de volta de string para DateTime
            Debug.WriteLine(DateTime.Parse(data.ToString("O")).ToString("dd/MM/HH:mm:ss.fff"));

            Debug.WriteLine(data.ToString("t"));
            Debug.WriteLine(data.ToString("T"));



        }
    }
}
