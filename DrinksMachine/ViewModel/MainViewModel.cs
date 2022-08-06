using DrinksMachine.HelperClasses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DrinksMachine.ViewModel
{
    class MainViewModel : NotifyPropertyChangedBase
    {
        private object _currentViewModel;
        public object CurrentViewModel
        {
            get => _currentViewModel;
            set => _UpdateField(ref _currentViewModel, value);
        }

        private readonly HomeViewModel _homeViewModel;
        private readonly Sub1ViewModel _sub1ViewModel;
        private readonly Sub2ViewModel _sub2ViewModel;
        private readonly Sub3ViewModel _sub3ViewModel;

        public MainViewModel()
        {
            _sub1ViewModel = new Sub1ViewModel
            {
                BackCommand = new DelegateCommand(() => CurrentViewModel = _homeViewModel)
            };

            _sub2ViewModel = new Sub2ViewModel
            {
                BackCommand = new DelegateCommand(() => CurrentViewModel = _homeViewModel)
            };

            _sub3ViewModel = new Sub3ViewModel
            {
                BackCommand = new DelegateCommand(() => CurrentViewModel = _homeViewModel)
            };

            _homeViewModel = new HomeViewModel
            {
                ShowSub1Command = new DelegateCommand(() => CurrentViewModel = _sub1ViewModel),
                ShowSub2Command = new DelegateCommand(() => CurrentViewModel = _sub2ViewModel),
                ShowSub3Command = new DelegateCommand(() => CurrentViewModel = _sub3ViewModel),
            };

            CurrentViewModel = _homeViewModel;
        }
    }
}
