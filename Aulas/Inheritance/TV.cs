using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class TV : ElectricalDevice
    {

        public TV(bool IsOn, string Brand) : base(IsOn, Brand)
        {
            
        }

        public void WatchTV()
        {
            if (IsOn == true)
            {
                Console.WriteLine("Watching the TV!!");
            }
            else
            {
                Console.WriteLine("TV is Swithced off, turn on the TV First!");
            }
        }
    }
}
