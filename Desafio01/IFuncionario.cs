﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    interface IFuncionario
    {
        double Bonificacao(double salario);

        int CalculaIdade(DateTime nascimento);
    }
}
