using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Radio : ElectricalDevice
    {
        

        public Radio(bool IsOn, string Brand) : base(IsOn, Brand)
        {
            
        }


        public void ListenRadio()
        {
            if (IsOn == true)
            {
                Console.WriteLine("Listening to the Radio!!");
            }
            else
            {
                Console.WriteLine("Radio is Swithced off, turn on the Radio First!");
            }
        }

    }
}
