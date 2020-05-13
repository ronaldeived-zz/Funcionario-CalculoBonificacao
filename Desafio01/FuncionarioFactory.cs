using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    abstract class FuncionarioFactory : IFuncionario
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public double Salario { get; set; }

        protected FuncionarioFactory()
        {
        }

        protected FuncionarioFactory(string nome, string sexo, string cpf, DateTime nascimento, double salario)
        {
            Nome = nome;
            Sexo = sexo;
            Cpf = cpf;
            Nascimento = nascimento;
            Salario = salario;
        }

        public abstract double Bonificacao(double salario);

        public int CalculaIdade(DateTime nascimento)
        {
            int idade = DateTime.Now.Year - nascimento.Year;
            if (DateTime.Now.DayOfYear < nascimento.DayOfYear)
            {
                idade = idade - 1;
            }
            return idade;
        }

        public void ApresentaInfo(string nome, string sexo, string cpf, DateTime nascimento, double salario)
        {
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o Sexo: ");
            sexo = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            cpf = Console.ReadLine();

            bool testeData = true;

            while (testeData == true)
            {
                try
                {
                    Console.WriteLine("Digite o ano de nascimento:");
                    nascimento = DateTime.Parse(Console.ReadLine());
                    testeData = false;
                }
                catch
                {
                    Console.WriteLine("Digite uma data válida ");
                    testeData = true;
                }
            }

            Console.WriteLine("Digite o salário:");
            salario = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("O Funcionário {0} do sexo {1}, tem o CPF {2},", nome, sexo, cpf);
            Console.WriteLine("idade {0}, recebe o salário R${1} junto com 10% de bonificação fica R${2}.", CalculaIdade(nascimento), salario.ToString(), Bonificacao(salario));

            Console.WriteLine("");
        }
    }
}
