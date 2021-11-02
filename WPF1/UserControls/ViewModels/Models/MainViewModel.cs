using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF1.Annotations;

namespace WPF1.UserControls.ViewModels.Models
{
    class MainViewModel : ObservableObject
    {
        public HomeViewModel HomeVM;
        public SettingsViewModel SettingsVM;
        public ViewViewModel ViewVM;

        private RelayCommand _homeViewCommand;
        private RelayCommand _settingsViewCommand;
        private RelayCommand _viewViewCommand;

        public RelayCommand HomeViewCommand
        {
            get
            {
                return _homeViewCommand ??
                       (new RelayCommand(o => { CurrentView = HomeVM; }));
            }
        }

        public RelayCommand SettingsViewCommand
        {
            get
            {
                return _settingsViewCommand ??
                       (new RelayCommand(o => { CurrentView = SettingsVM; }));
            }
        }

        public RelayCommand ViewViewCommand
        {

            get
            {
                return _viewViewCommand ??
                       (new RelayCommand(o => { CurrentView = ViewVM; }));
            }
        }

        private object _currentView;

        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            SettingsVM = new SettingsViewModel();
            ViewVM = new ViewViewModel();
            CurrentView = HomeVM;

        }

    }

    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;

        }
        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }

    }
}
