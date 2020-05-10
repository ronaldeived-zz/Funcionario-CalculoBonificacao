using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public abstract double Bonificacao();
    }
}
