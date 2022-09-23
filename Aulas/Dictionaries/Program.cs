using System.Net.Cache;
using System.Linq;
using System.ComponentModel.Design;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee[] employees =
            {
                new Employee("CEO", "Fabio", 35,200),
                new Employee("Manager", "Joe", 32,25),
                new Employee("HR", "Lora", 34,21),
                new Employee("Secretary", "Petra", 28,18),
                new Employee("DEV", "Artorias", 55,35),
                new Employee("Intern", "Ernest", 22,8)
            };

            /*Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1, "One" },
                {2, "Two" },
                {3, "Three" }
            };*/

            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();

            foreach (Employee emp in employees)
            {
                employeeDirectory.Add(emp.Role, emp);
            }
            

            //------------------------------------------------------------------------------------------
            // UPDATE Dictionary
            string keyToUpdate = "HR";
            if (employeeDirectory.ContainsKey(keyToUpdate))
            {
                employeeDirectory[keyToUpdate] = new Employee("HR", "Paula", 31, 13);
                Console.WriteLine($"Employee with Role/Key {keyToUpdate} was Updated!!\n");
            }
            else
            {
                Console.WriteLine($"Employee with {keyToUpdate} not Found!!");
            }

            // REMOVE Dictionary
            string keyToRemove = "Intern";
            if (employeeDirectory.Remove(keyToRemove))
            {
                Console.WriteLine($"Employee with Role / Key {keyToRemove} was Removed");
            }
            else
            {
                Console.WriteLine($"Employee with {keyToRemove} not Found!!");
            }


            //------------------------------------------------------------------------------------------



            // USANDO O ElementAt(i) para retornar uma chave armazenada no index A
            for (int i = 0; i < employeeDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeeDirectory.ElementAt(i);
                Console.WriteLine($"Key: {keyValuePair.Key}");
                Employee employeeValue = keyValuePair.Value;
                Console.WriteLine($"Employee Name: {employeeValue.Name}");
                Console.WriteLine($"Employee Role: {employeeValue.Role}");
                Console.WriteLine($"Employee Age: {employeeValue.Age}");
                Console.WriteLine($"Employee Salary: {employeeValue.Salary}");
            }
            


            // PRIMEIRA FORMA DE VERIFICAR SE O QUE FOI PASSADO EXISTE
            string key = "CTO";
            if (employeeDirectory.ContainsKey(key))
            {
                Employee emp1 = employeeDirectory[key];
                Console.WriteLine($"Employee Name: {emp1.Name} / Role: {emp1.Role} / Salary: {emp1.Salary}");
            }
            else
            {
                Console.WriteLine($"This Key do not found: {key}");
            }


            // OUTRA FORMA DE VERIFICAR SE O QUE FOI PASSADO EXISTE
            Employee result = null;
            if(employeeDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("");
                Console.WriteLine("Value Retrieved!");

                Console.WriteLine($"Employee Name: {result.Name}");
                Console.WriteLine($"Employee Role: {result.Role}");
                Console.WriteLine($"Employee Age: {result.Age}");
                Console.WriteLine($"Employee Salary: {result.Salary}");
            }
            else
            {
                Console.WriteLine("This Key do not found!!!");
            }

        }
    }

    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;       // 8 horas, 5 dias na semana, 4 semanas, e 12 meses
            }
        }

        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}