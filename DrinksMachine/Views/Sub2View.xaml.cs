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
    /// Interaction logic for Sub2View.xaml
    /// </summary>
    public partial class Sub2View : UserControl
    {
        private const string READY_TEXT = "Adding some sugar and milk...";
        private DispatcherTimer dispatcherTimer;
        public Sub2View()
        {
            InitializeComponent();
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 6);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Start();
            MainWindow._MainWindow.drinks.CoffeeCount++;
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            btnPour.Visibility = Visibility.Visible;
            ellipse.Visibility = Visibility.Visible;

            if (txtProgress.Text == READY_TEXT)
            {
                txtProgress.Text = "Your drink is ready";
                btnReturn.Visibility = Visibility.Visible;
            }
        }

        private void btnPour_Click(object sender, RoutedEventArgs e)
        {
            if (y.Value == -0.6)
            {
                btnPour.Visibility = Visibility.Collapsed;
                ellipse.Visibility = Visibility.Collapsed;
                imgTea.Visibility = Visibility.Visible;
                txtProgress.Text = READY_TEXT;
            }
            else
            {
                y.Value -= 0.01;
            }
        }
    }
}
