using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bank
{
    /// <summary>
    /// Interaction logic for MainWin.xaml
    /// </summary>
    public partial class MainWin : Window
    {
        public MainWin()
        {
            InitializeComponent();
        }

       

        private void adminMainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            
        }

        private void Operator(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            adminMainFrame.Navigate(new Operator());
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            
            
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            adminMainFrame.Navigate(new AddCompany());
        }
    }
}
