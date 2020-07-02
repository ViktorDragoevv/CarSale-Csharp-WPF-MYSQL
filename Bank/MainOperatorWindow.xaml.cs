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
    /// Interaction logic for MainOperatorWindow.xaml
    /// </summary>
    public partial class MainOperatorWindow : Window
    {
        public MainOperatorWindow()
        {
            InitializeComponent();
        }



        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OperatorMainFrame.Navigate(new CreateCar());
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
            OperatorMainFrame.Navigate(new AddCustomer());
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            OperatorMainFrame.Navigate(new SaleCar());
        }

        private void MenuItem_Click5(object sender, RoutedEventArgs e)
        {
            OperatorMainFrame.Navigate(new Spravka1());
        }

        private void MenuItem_Click6(object sender, RoutedEventArgs e)
        {
            OperatorMainFrame.Navigate(new spravka2());
        }
    }
}
