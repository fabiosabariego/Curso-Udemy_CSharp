namespace Inheritance_Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Lia", 7);

            Console.WriteLine($"{dog.Name} is {dog.Age} years Old");
            dog.Play();
            dog.Eat();
            dog.MakeSound();
        }
    }
}