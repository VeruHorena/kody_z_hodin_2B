using Microsoft.Maui.Controls;

namespace RezervacniSystem2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AppointmentList.ItemsSource = RezervacniSystem.AvailableAppointments;
        }

        private void ReserveAppointment(object sender, System.EventArgs e)
        {
            if (sender is Button button && button.BindingContext is string appointment)
            {
                RezervacniSystem.ReservedAppointments.Add(appointment);
                RezervacniSystem.AvailableAppointments.Remove(appointment);
                AppointmentList.ItemsSource = null;
                AppointmentList.ItemsSource = RezervacniSystem.AvailableAppointments;
                DisplayAlert("Rezervace", $"Termín {appointment} byl rezervován.", "OK");
            }
        }

        private void ShowReservedAppointments(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Rezervace());
        }
    }
}