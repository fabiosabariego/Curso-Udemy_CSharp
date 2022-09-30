using System.Data.SqlTypes;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Panasonic");
            TV myTV = new TV(false, "Samsung");

            myRadio.SwitchOn();
            myRadio.ListenRadio();

            myTV.SwitchOff();
            myTV.WatchTV();
        }
    }
}