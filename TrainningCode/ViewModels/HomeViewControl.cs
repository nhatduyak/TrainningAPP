using System;
using System.Collections.Generic;
using System.Text;

namespace TrainningCode.ViewModels
{
    public class HomeViewControl:ViewModelsBase
    {
        private List<TopImage> topimage;

        public List<TopImage> TopImage
        {
            get => topimage;
            set { SetProperty(ref topimage, value); }
        }
        public HomeViewControl()
        {
            LoadImage();
        }
        private void LoadImage()
        {
            topimage = new List<TopImage>();
            topimage.Add(new TopImage("http://www.duy.somee.com/cimage.png","0"));
            topimage.Add(new TopImage("http://www.duy.somee.com/cimage1.png","1"));
            topimage.Add(new TopImage("http://www.duy.somee.com/cimage2.png","2"));
            topimage.Add(new TopImage("http://www.duy.somee.com/cimage3.png","3"));
        }
    }
}
