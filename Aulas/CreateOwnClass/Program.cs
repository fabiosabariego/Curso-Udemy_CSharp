namespace CreateOwnClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRIANDO NOSSA PRIMEIRA CLASSE
            // Criando um Objeto da minha Classe

            //Human Aluno = new Human();
            //Aluno.firstName = "Fabio";
            //Aluno.lastName = "Sabariego Rodrigues";

            Human Fabio = new Human("Fabio", "Sabariego Rodrigues", "Castanhos", 35);
            Fabio.IntroduceMyself();

            Human Priscila = new Human("Priscila", "Hipolito", "Castanhos Claros", 1);
            Priscila.IntroduceMyself();

            // Utilizando o Construtor Padrao (sem parametros)

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();
        }
    }
}