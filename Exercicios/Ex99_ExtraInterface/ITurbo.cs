using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ex99_ExtraInterface
{
    internal interface ITurbo
    {
        float Turbo(float pressaoTurbo);

        float Blower(float pressaoBlower);
    }
}
