namespace BindingStaticResourcesExample
{
    public partial class App : Application
    {
        public static Person PersonStatic {  get; set; }
        public App(Person person)
        {
            InitializeComponent();

            PersonStatic=person;
            MainPage = new AppShell();
        }
    }
}
