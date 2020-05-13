using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            IniciaCalculo inicia = new IniciaCalculo();

            inicia.Inicia(true);  
        }
    }
}
