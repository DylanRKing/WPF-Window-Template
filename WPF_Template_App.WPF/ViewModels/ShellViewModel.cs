using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Template_App.WPF.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        private string appTitle = "Template Window";

        public string AppTitle
        {
            get { return appTitle; }
            set 
            { 
                if (value != null && value != String.Empty)
                {
                    appTitle = value;
                    OnPropertyChanged("AppTitle");
                }
            }
        }

    }
}
