using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace RezervacniSystem2
{
    public static class RezervacniSystem
    {
        public static List<string> AvailableAppointments { get; } = new()
        {
            "1.4.2025 - 10:00",
            "2.4.2025 - 14:30",
            "3.4.2025 - 09:15"
        };
        public static List<string> ReservedAppointments { get; } = new();
    }
}
