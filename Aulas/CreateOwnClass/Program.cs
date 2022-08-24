namespace CreateOwnClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRIANDO NOSSA PRIMEIRA CLASSE
            // Criando um Objeto da minha Classe
            Human Aluno = new Human();
            Aluno.firstName = "Fabio";
            Aluno.lastName = "Sabariego Rodrigues";
            Aluno.IntroduceMyself();
        }
    }
}