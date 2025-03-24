using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace eshopList
{
 

  

    public class MainViewModel()
    {
        public List<Produkt> seznam { get; set; }
        public Kosik kosik { get; set; }

        public MainViewModel() { 
        seznam = new List<Produkt>
        {
            new Produkt { Nazev = "Jablko", Cena = 20 },
            new Produkt { Nazev = "Banán", Cena = 25 },
            new Produkt { Nazev = "Hruška", Cena = 30 }
        };

        Kosik k = new Kosik();

        
    }

    private void PridatDoKosiku(Produkt produkt)
    {
        kosik.PridatDoKosiku(produkt);
    }

    private async void ZobrazitKosik()
    {
        var obsahKosiku = kosik.ZobrazKosik();
        await Application.Current.MainPage.DisplayAlert("Obsah košíku", obsahKosiku, "OK");
    }
}
}
