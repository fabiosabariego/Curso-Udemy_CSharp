using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Clase base para definir um Veiculo, podendo ser Carro, Moto ou Caminhao

namespace Ex99_ExtraInterface
{
    internal class Veiculo : ITurbo
    {
        public string Motor { get; set; }
        public int Rodas { get; set; }
        private bool Ligado { get; set; }
        public string Combustivel { get; set; } = "";
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public int TipoTurbo { get; set; }

        public float PressaoCarro { get; set; }

        public Veiculo(string motor, int rodas, string combustivel, string marca, string modelo)
        {
            this.Motor = motor;
            this.Rodas = rodas;
            this.Combustivel = combustivel;
            this.Marca = marca;
            this.Modelo = modelo;
        }

        public void StatusCarro()
        {
            if (Ligado == true)
            {
                Console.WriteLine($"O modelo {Modelo} da marca {Marca} foi ligado corretamente!!");
            }
            else
            {
                Console.WriteLine($"O modelo {Modelo} da marca {Marca} foi Desligado corretamente!");
            }
        }

        public void Ligar()
        {
            Ligado = true;
        }

        public void Desligar()
        {
            Ligado = false;
        }

        public float Turbo(float pressaoTurbo)
        {
            Console.WriteLine("Quantos Kg de Pressao voce deseja Colocar: ");
            float.TryParse(Console.ReadLine(), out pressaoTurbo);


            return this.PressaoCarro = pressaoTurbo;
        }

        public float Blower(float pressaoBlower)
        {
            Console.Write("Quandos Kg de Pressao voce deseja configuar seu Blower: ");
            float.TryParse(Console.ReadLine(), out pressaoBlower);

            return this.PressaoCarro = pressaoBlower;
        }

    }
}
