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
    class Service
    {
        public void GetService(bool service)
        {
            while (service == true)
            {
                Gerente gerente = new Gerente();
                Vendedor vendedor = new Vendedor();
                Operador operador = new Operador();
                int resposta = 1;
                bool testeData = true;

                while (resposta == 1)
                {
                    Console.WriteLine("==================== Calculo de Bonificação ====================");
                    Console.WriteLine("Deseja fazer o calculo?");
                    Console.WriteLine("Digite 1 para sim");
                    Console.WriteLine("Digite 2 para sair");

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

                    while (resposta == 1)
                    {
                        Console.WriteLine("==================== Escolha um tipo de funcionário ====================");
                        Console.WriteLine("1 para Gerente");
                        Console.WriteLine("2 para Vendedor");
                        Console.WriteLine("3 para Operador");
                        Console.WriteLine("4 para Sair");
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

                        switch (resposta)
                        {
                            case 1:
                                Console.WriteLine("Digite o nome: ");
                                gerente.Nome = Console.ReadLine();

                                Console.WriteLine("Digite o Sexo: ");
                                gerente.Sexo = Console.ReadLine();

                                Console.WriteLine("Digite o CPF: ");
                                gerente.Cpf = Console.ReadLine();

                                while (testeData == true)
                                {
                                    try
                                    {
                                        Console.WriteLine("Digite o ano de nascimento:");
                                        gerente.Nascimento = DateTime.Parse(Console.ReadLine());
                                        testeData = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Digite uma data válida ");
                                        testeData = true;
                                    }
                                }

                                Console.WriteLine("Digite o salário:");
                                gerente.Salario = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("");

                                Console.WriteLine("O Funcionário {0} do sexo {1}, tem o CPF {2},", gerente.Nome, gerente.Sexo, gerente.Cpf);
                                Console.WriteLine("nasceu em {0}, tem o salário {1} junto com 10% de bonificação fica {2}.", gerente.Nascimento.ToString("dd/MM/yyyy"), gerente.Salario, gerente.Bonificacao());

                                Console.WriteLine("");
                                resposta = 1;
                                break;

                            case 2:
                                Console.WriteLine("Digite o nome: ");
                                vendedor.Nome = Console.ReadLine();

                                Console.WriteLine("Digite o Sexo: ");
                                vendedor.Sexo = Console.ReadLine();

                                Console.WriteLine("Digite o CPF: ");
                                vendedor.Cpf = Console.ReadLine();

                                while (testeData == true)
                                {
                                    try
                                    {
                                        Console.WriteLine("Digite o ano de nascimento:");
                                        vendedor.Nascimento = DateTime.Parse(Console.ReadLine());
                                        testeData = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Digite uma data válida ");
                                        testeData = true;
                                    }
                                }

                                Console.WriteLine("Digite o salário:");
                                vendedor.Salario = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("");

                                Console.WriteLine("O Funcionário {0} do sexo {1}, tem o CPF {2},", vendedor.Nome, vendedor.Sexo, vendedor.Cpf);
                                Console.WriteLine("nasceu em {0}, tem o salário {1} junto com 7% de bonificação fica {2}.", vendedor.Nascimento.ToString("dd/MM/yyyy"), vendedor.Salario, vendedor.Bonificacao());

                                Console.WriteLine("");
                                resposta = 1;
                                break;

                            case 3:
                                Console.WriteLine("Digite o nome: ");
                                operador.Nome = Console.ReadLine();

                                Console.WriteLine("Digite o Sexo: ");
                                operador.Sexo = Console.ReadLine();

                                Console.WriteLine("Digite o CPF: ");
                                operador.Cpf = Console.ReadLine();

                                while (testeData == true)
                                {
                                    try
                                    {
                                        Console.WriteLine("Digite o ano de nascimento:");
                                        operador.Nascimento = DateTime.Parse(Console.ReadLine());
                                        testeData = false;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Digite uma data válida ");
                                        testeData = true;
                                    }
                                }

                                Console.WriteLine("Digite o salário:");
                                operador.Salario = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("");

                                Console.WriteLine("O Funcionário {0} do sexo {1}, tem o CPF {2},", operador.Nome, operador.Sexo, operador.Cpf);
                                Console.WriteLine("nasceu em {0}, tem o salário {1} junto com 5% de bonificação fica {2}.", operador.Nascimento.ToString("dd/MM/yyyy"), operador.Salario, operador.Bonificacao());

                                Console.WriteLine("");
                                resposta = 1;
                                break;

                            case 4:
                                Console.WriteLine("Aplicação Finalizada");
                                Console.WriteLine("Tecle ENTER para fechar");
                                Console.ReadLine();
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Escolha a opção correta");
                                resposta = 1;
                                break;
                        }


                    }
                    if (resposta == 2)
                    {
                        Console.WriteLine("Você digitou 2");
                    }
                    else
                    {
                        Console.WriteLine("Digite uma opção válida");
                        resposta = 1;
                    }
                    Console.WriteLine("");
                }

                Console.WriteLine("Aplicação Finalizada");
                Console.WriteLine("Tecle ENTER para fechar");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
