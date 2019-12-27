using SwipeButton.ViewModels;
using Xamarin.Forms.Xaml;

namespace SwipeButton.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FruitPage
    {
        public FruitPage()
        {
            InitializeComponent();
            BindingContext = new FruitPageViewModel();
        }
    }
}