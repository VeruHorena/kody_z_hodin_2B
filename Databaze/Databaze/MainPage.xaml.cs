namespace MauiDbApp;


public partial class MainPage : ContentPage
{
    private readonly DatabaseService db = new();

    public MainPage()
    {
        InitializeComponent();
        LoadData();
    }

    private async void LoadData()
    {
        var osoby = await db.GetOsobyAsync();
        osobyList.ItemsSource = osoby;
    }
}
