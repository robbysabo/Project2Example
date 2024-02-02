using Project2.ViewModel;

namespace Project2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new Project2Viewmodel();
        }
    }

}
