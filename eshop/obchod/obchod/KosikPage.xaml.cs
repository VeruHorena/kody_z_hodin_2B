using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obchod
{
    public partial class KosikPage : ContentPage
    {
        private Kosik kosik;

    public KosikPage(Kosik kosik)
    {
        InitializeComponent();
        this.kosik = kosik;
        NactiKosik();
    }

        
    private void NactiKosik()
    {
        KosikStack.Children.Clear();

        foreach (Produkt produkt in kosik.Produkty)
        {
            StackLayout stack = new StackLayout { Padding = 5, Margin = 5, BackgroundColor = Colors.LightGray };

            stack.Children.Add(new Label { Text = produkt.Nazev, FontAttributes = FontAttributes.Bold });
            stack.Children.Add(new Label { Text = $"Cena: {produkt.Cena} Kč" });

            KosikStack.Children.Add(stack);
        }

        CelkovaCenaLabel.Text = $"Celkova cena: {kosik.CelkovaCena()} Kč";
    }
        private void BtnZpet_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync(); // Vrátí uživatele na předchozí stránku (seznam produktů)
        }
    }
}
