using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX17_ClassesPhone
{
    internal class Phone
    {
        public string company;
        public string model;
        public string releasyDay;


        public Phone()
        {
            company = "unknow";
            model = "unknow";
            releasyDay = "unknow";

        }

        public Phone (string company, string model)
        {
            this.company = company;
            this.model = model;
            releasyDay = "unknow";
        }

        public Phone(string company, string model, string releasyDay)
        {
            this.company = company;
            this.model = model;
            this.releasyDay = releasyDay;
        }

        public void Introduce()
        {
            Console.WriteLine($"Fabricante: {company} \nModelo: {model} \nData Fabricado: {releasyDay}\n");
        }
    }
}
