namespace UserLogin
{
    internal class Program
    {
        static string userNameReg;
        static string passwordReg;

        static void Main(string[] args)
        {

            // Cadastrando um novo Usuario
            Console.WriteLine("------------- CRIANDO UM USUARIO -------------");

            Register();
           
            // Verificando e realizando o loggin com usuario e senhas criados
            Console.WriteLine("------------- LOGIN -------------");

            Login();

        }

        public static void Register()
        {
            // Coletando o nome de usuario para cadastro
            Console.Write("Cadastre seu nome de usuario: ");
            userNameReg = Console.ReadLine();

            // Coletando a senha de Usuario para cadastro
            Console.Write("Cadastre sua senha de usuario: ");
            passwordReg = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Usuario cadastrado com sucesso!!!!\n\n");
        }

        public static void Login()
        {
            // Entrado com nome de usuario
            Console.Write("Digite seu nome de usuario: ");
            string userNameLog = Console.ReadLine();

            // Entrado com a senha de usuario
            Console.Write("Digite sua senha de usuario: ");
            string passwordLog = Console.ReadLine();
            Console.WriteLine("");


            // Verificando se o Usuario e Senha estao corretos para entrar no sistema
            if (userNameReg.Equals(userNameLog) && passwordReg.Equals(passwordLog))
            {
                Console.WriteLine($"Seja bem vindo ao sistema {userNameLog}!!");
            }
            else
            {
                Console.WriteLine("Usuario ou senha incorretos, tente novamente outra hora!!!");
            }
        }
    }
}