using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ElectricalDevice
    {
        // State of Equipment (On or Off)
        public bool IsOn { get; set; }

        // Brand of Equipment
        public string Brand { get; set; }

        //--------------------------------------------------
        public ElectricalDevice(bool isON, string brand)
        {
            this.IsOn = isON;
            this.Brand = brand;
        }

        //--------------------------------------------------
        // Switch On the Equipment
        public void SwitchOn()
        {
            IsOn = true;
        }

        //--------------------------------------------------
        // Switch Off the Equipment
        public void SwitchOff()
        {
            IsOn = false;
        }

    }
}
