using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex99_ExtraInterface
{
    internal class Carro : Veiculo
    {
        private int AirBags { get; set; }
        private bool TetoSolar { get; set; }
        private int TurboBlower { get; set; }

        public Carro(string motor, int rodas, string combustivel, string marca, string modelo, int airbags, bool tetosolar, int turboBlower) : base(motor, rodas, combustivel, marca, modelo)
        {
            this.AirBags = airbags;
            this.TetoSolar = tetosolar;
            this.TurboBlower = turboBlower;
        }

        public void GetConfig()
        {
            Console.WriteLine("As Especificacoes do Veiculo sao:");
            Console.WriteLine($"Motor: {Motor}");
            Console.WriteLine($"Rodas: {Rodas}");
            Console.WriteLine($"Combustivel: {Combustivel}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"AirBags: {AirBags}");

            if (TurboBlower == 0)
            {
                Console.WriteLine($"Esse Carro esta Original!!!");
            }
            else if (TurboBlower == 1)
            {
                Console.WriteLine($"Pressao do Turbo: {PressaoCarro}");
            }
            else if (TurboBlower == 2)
            {
                Console.WriteLine($"Pressao do Blower: {PressaoCarro}");
            }


            if (TetoSolar == true)
            {
                Console.WriteLine("Seu carro e muito legal, tem teto Solar!!!");
            }
            else
            {
                Console.WriteLine("Seu carro e mais simples, nao tem teto solar!!!");
            }
        }
    }
}
