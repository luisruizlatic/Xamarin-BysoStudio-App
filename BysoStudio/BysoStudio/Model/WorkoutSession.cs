using System;
using System.Collections.Generic;
using System.Text;

namespace BysoStudio.Model
{
    class WorkoutSession
    {
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int MaxCapacity { get; set; }
        public int MinCapacity { get; set; }
        public int PersonId { get; set; }
        public int WorkoutId { get; set; }

    }
}
