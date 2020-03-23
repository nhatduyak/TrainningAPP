using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainningCode.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarcodeView : ContentPage
    {
        public BarcodeView()
        {
            InitializeComponent();
            loadBarcode();
        }
        public void loadBarcode()
        {
            BarcodeImageView.BarcodeValue= "2499015500977";
            BarcodeImageView.BarcodeFormat = ZXing.BarcodeFormat.EAN_13;            
            BarcodeImageView.IsVisible = true;
        }
    }
}