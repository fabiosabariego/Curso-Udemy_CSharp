using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties_Pt1
{
    class Box
    {
        // Member Variables
        private int lenght;
        private int height;
        //public int width;
        private int volume;

        // Criando uma Propriedade
        public int Width { get; set; }


        // Desafio - Criando a Area da caixa, somente leitura

        public int FrontSurface
        {
            get
            {
                return lenght * height;
            }
        }


        // Criando uma Propriedade
        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
                
            }
        }


        public Box (int lenght, int height, int width)
        {
            this.lenght = lenght;
            this.height = height;
            Width = width;
        }



        // Tambem e um tipo de Propriedade, porem feita tudo a mao
        public void SetLenght(int lenght)
        {
            /*if (lenght < 0)
            {
                throw new Exception("Lenght should be highert than 0");
            }*/
            this.lenght = lenght;
        }


        public int GetLenght()
        {
            return this.lenght;
        }



        // Desafio - Criar a propiedade para Volume da forma mais simples
       
        //public int Volume { get; set; }

        public int Volume
        {
            get
            {
                return this.height * this.lenght * this.Width;
            }
        }



        /*public int GetVolume()
        {
            return this.lenght * this.height * this.Width;
        }*/


        public void DisplayInfo()
        {
            volume = lenght * height * Width;
            Console.WriteLine($"Lenth is {lenght}, height is {height}, Width is {Width} and volume is {Volume}");
            Console.WriteLine($"Also, the Front Surface is {FrontSurface}");
        }
        
    }
}
