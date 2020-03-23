using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningCode.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainningCode.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        public HomeViewControl _homecontrol;
        public HomeView()
        {
            InitializeComponent();
            _homecontrol = new HomeViewControl();
            this.BindingContext = _homecontrol;
        }
    }
}