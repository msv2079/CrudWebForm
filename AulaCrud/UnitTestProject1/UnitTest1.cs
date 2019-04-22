using System;
using AulaCrudNegocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PessoaNegocio p = new PessoaNegocio();

            var teste = p.TestarPessoa(18);

            

        }
    }
}
