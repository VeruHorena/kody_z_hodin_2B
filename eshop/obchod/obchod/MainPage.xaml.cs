
namespace obchod
{
    public partial class MainPage : ContentPage
    {

       
            private List<Produkt> produkty = new List<Produkt>
        {
            new Produkt("Notebook", 25000, "Výkonný notebook pro práci"),
            new Produkt("Telefon", 15000, "Chytrý telefon s Androidem"),
            new Produkt("Sluchátka", 3000, "Bezdrátová sluchátka s dlouhou výdrží")
        };

            private Kosik kosik = new Kosik();

            public MainPage()
            {
                InitializeComponent();
                NactiProdukty();
            }
       
        private void NactiProdukty()
            {
                foreach (Produkt produkt in produkty)
                {
                    StackLayout stack = new StackLayout {};

                    stack.Children.Add(new Label { Text = produkt.Nazev });
                    stack.Children.Add(new Label { Text = $"Cena: {produkt.Cena} Kč" });
                    stack.Children.Add(new Label { Text = produkt.Popis });

                    Button btnPridat = new Button { 
                        Text = "Přidat do košíku" };
                /*btnPridat.Clicked += (s, e) => { 
                    kosik.PridatProdukt(produkt);
                  DisplayAlert("Přidáno do košíku", $"{produkt.Nazev} byl přidán do košíku.", "OK");

                };*/
                btnPridat.Clicked += (s, e) => OnBtnPridatClicked(s, e, produkt); //když uživatel klikne na btnPridat, zavolej OnBtnPridatClicked a předej mu tři parametry:
                //=> je lamba vyraz pro delegovani metody


                stack.Children.Add(btnPridat);
                    ProduktyStack.Children.Add(stack);
                }
            }


            private async void ZobrazitKosik_Clicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new KosikPage(kosik));
            }

        private void OnBtnPridatClicked(object sender, EventArgs e, Produkt p)
        {
            kosik.PridatProdukt(p);
            DisplayAlert("Přidáno do košíku", $"{p.Nazev} byl přidán do košíku.", "OK");
        }
    }
    }

