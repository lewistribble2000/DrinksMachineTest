using DrinksMachine.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DrinksMachine.Views
{
    /// <summary>
    /// Interaction logic for Sub1View.xaml
    /// </summary>
    public partial class Sub1View : UserControl
    {
        private DispatcherTimer dispatcherTimer;
        public Sub1View()
        {
            InitializeComponent();
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 10);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Start();
            MainWindow._MainWindow.drinks.LemonTeaCount++;
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            imgTea.Visibility = Visibility.Visible;
            btnReturn.Visibility = Visibility.Visible;
            dispatcherTimer.IsEnabled = false;
        }
    }
}
