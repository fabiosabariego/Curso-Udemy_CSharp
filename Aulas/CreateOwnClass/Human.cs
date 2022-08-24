using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateOwnClass
{
    internal class Human
    {
        // Member Variable
        // string firstName; --> Criando dessa forma, nao podemos mudar o parametro de fora da Classe, entao vamos colocar como publico
        // string private string firstName;  --> Esta forma mantemos a variavel privada, similar ao escrito acima
        public string firstName;
        public string lastName;

        // Criando um Metodo
        public void IntroduceMyself()
        {
            Console.WriteLine($"Ola, meu nome e {firstName} {lastName}");
        }

    }
}
