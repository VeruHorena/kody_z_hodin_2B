using Microsoft.Maui.Controls;
using System.Reflection.Emit;

namespace FirstMauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Tato metoda se spustí při kliknutí na tlačítko
        private void OnButtonClicked(object sender, EventArgs e)
        {
            // Změní text v labelu
            label.Text = "Button clicked!";
        }
    }
}
