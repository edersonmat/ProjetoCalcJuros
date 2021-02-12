using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Data.Entities;
using Projeto.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Projeto.Teste
{
    [TestClass]
    public class ShowCodeTeste
    {
        [TestMethod]
        public void ShowCodeTest()
        {
            try
            {
                var code = new ShowCodeRepository();
                var result = code.ShowTheCode(CodeGit.Url);

                Assert.IsTrue(result != "");
            }
            catch(Exception e)
            {
                Assert.Fail("Falha: " + e.Message);
            }
        }
    }
}
