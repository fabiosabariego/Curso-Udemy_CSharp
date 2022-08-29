namespace Arrays02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
                Console.WriteLine(nums[i]);
            }

            for(int j = 0; j < 10; j++)
            {
                Console.WriteLine($"Index: {j} -> Valor: {nums[j]}"); 
            }

            int count = 0;
            foreach(int k in nums)
            {
                Console.WriteLine($"Index: {count} -> Valor: {nums[k]}");
                count++;
            }

            //Criar um array com nome de 5 pessoas, depois mostrar com o foreach loop
            string[] pessoas = { "Fabio", "Priscila", "Lia", "Danilo", "Catarrinha" };

            foreach(string p in pessoas)
            {
                Console.WriteLine($"Pessoa Escolhida: {p}");
            }
        }
    }
}