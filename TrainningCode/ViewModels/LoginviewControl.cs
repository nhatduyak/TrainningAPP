using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrainningCode.ViewModels
{
    public class LoginviewControl : ViewModelsBase
    {
        private string email;
        private string passWord;

        public string Email
        {
            get => email;
            set
            {
                if (SetProperty(ref email, value))
                {
                    logincommand.RaiseCanExecuteChanged();
                }
            }
        }
        public string PassWord { get => passWord;
            set
            {
                if (SetProperty(ref passWord, value))
                {
                    logincommand.RaiseCanExecuteChanged();
                }
            }
        }

        public Mvvm.Commands.DelegateCommand logincommand { get; set; }
        public LoginviewControl()
        {
            logincommand = new Mvvm.Commands.DelegateCommand(login, checklogin);
        }

        private bool checklogin()
        {
            return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(PassWord);
        }

        private async void login()
        {
            //throw new NotImplementedException();
            Isbusy = true;
            await Task.Delay(5000);
            Isbusy = false;
        }
    }
}
