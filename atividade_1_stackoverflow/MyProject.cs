using System;
using System.Collections.Generic;
using System.Text;

namespace atividade_1_stackoverflow.Projeto
{
    public class TypeA
    {
        private List<TypeB> myList = new List<TypeB>();

        private class TypeB
        {
            public TypeB()
            {
                // Contrutor da classe Interna
            }

        }

        public TypeA()
        {
            // Contrutor da classe Externa
        }

        private string MyMethod()
        {
            //  Metodo da classe externa TypeA (processa MyList)
            return "Hello World!";
        
        }
    }
    public class TypeA_Accessor : TypeA
    {
    }
}
