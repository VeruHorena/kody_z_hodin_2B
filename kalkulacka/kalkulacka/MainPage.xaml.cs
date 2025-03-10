namespace kalkulacka
{
    public partial class MainPage : ContentPage
    {
        private List<string> history = new List<string>();

        public MainPage()
        {
          
            InitializeComponent();
            HistoryListView.ItemsSource = history;

        }
        void OnAddClicked(object sender, EventArgs e)
        {
            Calculate("+");
        }

        void OnSubtractClicked(object sender, EventArgs e)
        {
            Calculate("-");
        }

        void OnMultiplyClicked(object sender, EventArgs e)
        {
            Calculate("*");
        }

        void OnDivideClicked(object sender, EventArgs e)
        {
            Calculate("/");
        }
        void vymaz(object sender, EventArgs e)
        {
            entryNum1.Text = "";
            entryNum2.Text = "";
            labelResult.Text = "";
        }

        void Calculate(string operation)
        {
            if (double.TryParse(entryNum1.Text, out double num1) && double.TryParse(entryNum2.Text, out double num2))
            {
                double result = 0;
                switch (operation)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/":
                        if (num2 == 0)
                        {
                            labelResult.Text = "Nelze dělit nulou!";
                            return;
                        }
                        result = num1 / num2;
                        break;
                }
                string historyEntry = $"{num1} {operation} {num2} = {result}";
                labelResult.Text = $"Výsledek: {result}";
                history.Insert(0, historyEntry); // Přidání nového výpočtu na začátek seznamu
                HistoryListView.ItemsSource = null; // Reset zdroje dat
                HistoryListView.ItemsSource = history;
            }
            else
            {
                labelResult.Text = "Neplatný vstup!";
            }
        }


    }

}
