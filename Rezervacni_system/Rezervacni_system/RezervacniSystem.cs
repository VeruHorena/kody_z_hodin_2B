using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace Rezervacni_system
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