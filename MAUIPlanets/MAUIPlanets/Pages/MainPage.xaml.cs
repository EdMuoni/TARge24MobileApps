using MAUIPlanets.Models;
using MAUIPlanets.PageModels;

namespace MAUIPlanets.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}