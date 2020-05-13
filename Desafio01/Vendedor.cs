using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    class Vendedor : FuncionarioFactory
    {
        public Vendedor()
        {
        }

        public Vendedor(string nome, string sexo, string cpf, DateTime nascimento, double salario) : base(nome, sexo, cpf, nascimento, salario)
        {
        }

        public override double Bonificacao(double salario)
        {
            double variavel = 0.10;
            return (salario + (salario * variavel));
        }
    }
}
