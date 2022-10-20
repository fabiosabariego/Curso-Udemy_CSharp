using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Ticket : IEquatable<Ticket>
    {
        public int DurationInHours { get; set; }

        public Ticket(int durationInHours)
        {
            this.DurationInHours = durationInHours;
        }


        // Isso foi feito pois ao atribuir a heranca Ticket:IEquals<Ticket> ele precisa que uma comparacao de igualdade seja feita para funcionar
        public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours;
        }
    }
}
