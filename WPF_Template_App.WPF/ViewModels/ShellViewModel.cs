using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WPF_Template_App.WPF.Classes;

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

        private static string execPath = Assembly.GetEntryAssembly().Location;
        private string appLogo = $@"{execPath}/../Images/Icons/LogoExample.png";

        public string AppLogo
        {
            get { return appLogo; }
            set 
            {
                appLogo = value;
                OnPropertyChanged("LogoImage");
            }
        }


        private bool darkMode = true;

        public bool DarkMode
        {
            get { return darkMode; }
            set 
            { 
                darkMode = value;
                OnPropertyChanged("DarkMode");
                appTheme.DarkMode(DarkMode);
            }
        }

        private AppTheme appTheme;

        public ShellViewModel()
        {
            appTheme = new AppTheme();
        }
    }
}
