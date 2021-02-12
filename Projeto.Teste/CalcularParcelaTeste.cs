using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Data.Contracts;
using Projeto.Data.Entities;
using Projeto.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Projeto.Teste
{
    [TestClass]
    public class CalcularParcelaTeste
    {
        [TestMethod]
        public void TestCalcularParcela()
        {
            try
            {
                CalculadorRepository rep = new CalculadorRepository();
                CalculaParcela parcela = new CalculaParcela
                {
                    Prazo = 5,
                    Valor = 100
                };

                var resultado = rep.Calcular(Juros.Taxa, parcela);

                Assert.IsTrue(resultado > 100);
            }
            catch(Exception e)
            {
                Assert.Fail("Falha: " + e.Message);
            }
        }
    }
}
