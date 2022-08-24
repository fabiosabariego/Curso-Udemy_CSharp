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
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;


        //----------------------------------------------------------------------------------------------------------
        // Construtor Padrao
        public Human()
        {
            Console.WriteLine("Construtor Chamado, Objeto Criado!");
        }


        //----------------------------------------------------------------------------------------------------------
        // Criando um Construtor Parametrizado
        public Human(string myFirstName, string lastName, string eyeColor, int age)
        {
            firstName = myFirstName; // Podemos fazer desta forma
            this.lastName = lastName; // Funciona da mesma forma, neste caso, o "this" e responsavel por pegar a variavel global
            this.eyeColor = eyeColor;
            this.age = age;
        }

        //----------------------------------------------------------------------------------------------------------
        // Criando um Metodo
        public void IntroduceMyself()
        {
            if (age == 1)
            {
                Console.WriteLine($"Ola, meu nome e {firstName} {lastName}. Eu tenho olhos {eyeColor} e atualmente tenho {age} ano!");
            }
            else
            {
                Console.WriteLine($"Ola, meu nome e {firstName} {lastName}. Eu tenho olhos {eyeColor} e atualmente tenho {age} anos!");
            } 
        }

    }
}
