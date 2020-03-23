using System;
using System.Collections.Generic;
using System.Text;

namespace TrainningCode.ViewModels
{
    public class TopImage:ViewModelsBase
    {
        private string url;
        private string name;
       
        public TopImage(string purl,string pname)
        {
            Url = purl;
            Name = pname;
        }

        public string Url { get => url; set => url = value; }
        public string Name { get => name; set => name = value; }
    }
}
