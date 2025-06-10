using Kursovaya.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kursovaya.ViewModel
{
    public class NavigationViewModel : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }
        public ICommand HomeCommand { get; set; }
        public ICommand EmployeeCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeViewModel();
        public NavigationViewModel()
        {
            HomeCommand = new RelayCommand(Home);
       
            // Startup Page
            CurrentView = new HomeViewModel();
        }
    }
}
