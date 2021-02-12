using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Data.Contracts;
using Projeto.Data.Entities;

namespace Projeto.Data.Repositories
{
    public class CalculadorRepository : ICalculos
    {
        public double Calcular(Double juros, CalculaParcela parcela)
        {
            var valorFinal = parcela.Valor * Math.Pow(1 + juros, parcela.Prazo);

            return valorFinal;
        }
    }
}

