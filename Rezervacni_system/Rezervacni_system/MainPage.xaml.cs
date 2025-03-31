using Microsoft.Maui.Controls;
using System;

namespace Rezervacni_system
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AppointmentList.ItemsSource = RezervacniSystem.AvailableAppointments;
        }

        private async void ReserveAppointment(object sender, EventArgs e)
        {
            if (sender is Button button && button.BindingContext is string appointment)
            {
                RezervacniSystem.ReservedAppointments.Add(appointment);
                RezervacniSystem.AvailableAppointments.Remove(appointment);
                AppointmentList.ItemsSource = null;
                AppointmentList.ItemsSource = RezervacniSystem.AvailableAppointments;
                await DisplayAlert("Rezervace", $"Termín {appointment} byl rezervován.", "OK");
            }
        }

        
    }
}