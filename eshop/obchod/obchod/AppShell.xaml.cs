namespace obchod
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(KosikPage), typeof(KosikPage));
        }
    }
}
