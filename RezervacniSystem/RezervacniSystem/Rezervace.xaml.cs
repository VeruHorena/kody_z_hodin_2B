using Microsoft.Maui.Controls;

namespace RezervacniSystem2
{
    public partial class Rezervace : ContentPage
    {
        public Rezervace()
        {
            InitializeComponent();
            ReservedList.ItemsSource = RezervacniSystem.ReservedAppointments;
        }

        private void OnCloseClicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}