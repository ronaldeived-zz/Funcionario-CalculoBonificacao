using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    class Service
    {
        public void Sair()
        {
            Console.WriteLine("Aplicação Finalizada");
            Console.WriteLine("Tecle ENTER para fechar");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public int EscolhaFazerCalculo()
        {
            Console.WriteLine("==================== Calculo de Bonificação ====================");
            Console.WriteLine("Deseja fazer o calculo?");
            Console.WriteLine("Digite 1 para sim");
            Console.WriteLine("Digite 2 para sair");

            int resposta;
            try
            {
                resposta = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Aceita apenas número");
                resposta = 10;

            }
            Console.WriteLine("");
            return resposta;
        }

        public int EscolhaFuncionario()
        {
            Console.WriteLine("==================== Escolha um tipo de funcionário ====================");
            Console.WriteLine("1 para Gerente");
            Console.WriteLine("2 para Vendedor");
            Console.WriteLine("3 para Operador");
            Console.WriteLine("4 para Sair");
            int resposta;
            try
            {
                resposta = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Aceita apenas número");
                resposta = 10;
            }
            Console.WriteLine("");
            return resposta;
        }
    }
}
