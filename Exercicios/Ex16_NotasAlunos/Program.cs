namespace Ex16_NotasAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaAluno();
        }

        public static void MediaAluno()
        {
            float nota;
            int countMedia = 0;
            float mediaFinal = 0f;

            while (true)
            {
                // Insere o Valor da entrada e verifica se e do tipo float ou nao
                Console.Write("Digite a nota do Aluno: ");
                string notaInput = Console.ReadLine();

                try
                {
                    nota = float.Parse(notaInput);
                }

                catch (FormatException)
                {
                    Console.WriteLine("O formato deve ser apenas numerico");
                    continue;
                }

                // Verifica se o numero digitado foi de 0 a 20
                if (nota >= 0 && nota <= 20)
                {
                    mediaFinal += nota;
                    countMedia++;
                }
                else if (nota == -1)
                {
                    Console.WriteLine($"A media final do aluno foi {mediaFinal / countMedia:F2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Valor digitado fora do especificado, digite entre 0 e 20!!");
                }

            }
        }
    }
}