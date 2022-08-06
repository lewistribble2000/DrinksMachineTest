using DrinksMachine.HelperClasses;
using DrinksMachine.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DrinksMachine.ViewModel
{
    class HomeViewModel : NotifyPropertyChangedBase
    {
        private ICommand _showSub1Command;
        public ICommand ShowSub1Command
        {
            get => _showSub1Command;
            set => _UpdateField(ref _showSub1Command, value);
        }

        private ICommand _showSub2Command;
        public ICommand ShowSub2Command
        {
            get => _showSub2Command;
            set => _UpdateField(ref _showSub2Command, value);
        }

        private ICommand _showSub3Command;
        public ICommand ShowSub3Command
        {
            get => _showSub3Command;
            set =>  _UpdateField(ref _showSub3Command, value); 
        }
    }
}
