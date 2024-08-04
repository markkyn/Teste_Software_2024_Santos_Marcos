using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using atividade_1_stackoverflow.Projeto;


namespace atividade_1_stackoverflow
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solucao();
        }

        static void Solucao()
        {
            TypeA target = new TypeA();
            PrivateObject obj = new PrivateObject(target);
            var retVal = obj.Invoke("MyMethod");
            Assert.AreEqual(retVal, "Hello World!");

            System.Console.WriteLine("Teste Passado");
        }
    }
}
