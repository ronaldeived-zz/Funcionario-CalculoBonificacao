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
    class IniciaCalculo : Service
    {
        public void Inicia(bool service)
        {
            while (service == true)
            {
                Gerente gerente = new Gerente();
                Vendedor vendedor = new Vendedor();
                Operador operador = new Operador();
                int calculo = EscolhaFazerCalculo();

                if (calculo == 1)
                {
                    switch (EscolhaFuncionario())
                    {
                        case 1:
                            gerente.ApresentaInfo(gerente.Nome, gerente.Sexo, gerente.Cpf, gerente.Nascimento, gerente.Salario);
                            break;

                        case 2:
                            vendedor.ApresentaInfo(vendedor.Nome, vendedor.Sexo, vendedor.Cpf, vendedor.Nascimento, vendedor.Salario);
                            break;

                        case 3:
                            operador.ApresentaInfo(operador.Nome, operador.Sexo, operador.Cpf, operador.Nascimento, operador.Salario);
                            break;

                        case 4:
                            Sair();
                            break;

                        default:
                            Console.WriteLine("Escolha a opção correta");
                            break;
                    }
                }
                else if(calculo == 2)
                    Sair();
                else
                    Console.WriteLine("Digite uma opção válida");
            }
        }
    }
}
