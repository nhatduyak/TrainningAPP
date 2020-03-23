using System;
using System.Collections.Generic;
using System.Text;

namespace TrainningCode.ViewModels
{
    public class ViewModelsBase:Mvvm.BindableBase
    {
        string title;
        bool isbusy;
        public string Title { get => title; set => SetProperty(ref title,value); }
        public bool Isbusy { get => isbusy;
            set {
                if (SetProperty(ref isbusy, value))
                { RaisePropertyChanged(nameof(Isnotbusy)); } 
            }
        }
        public bool Isnotbusy=>!Isbusy;
    }
}
