using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    { 
        public LoginScreen()
        {
            InitializeComponent();
        }
        Operator op;
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        


        private void Button_Click(object sender, RoutedEventArgs e)
        {


            
            String username1 = username.Text.ToString();
            String password1 = password.Password.ToString();


            //connection.Open();

             string myconnstrng = "server=localhost;user=root;database=saledb;port=3306;password=123456";
            MySqlConnection conn = new MySqlConnection(myconnstrng);

            try
            {
                //SQL Query to check login
                //string sql = "SELECT userName , password FROM operator WHERE userName=@username AND password=@password ";
                string sql = " SELECT saleOperatorUserName , saleOperatorPassword from saleoperator WHERE saleOperatorUserName='" + username1 + "'and saleOperatorPassword='" + password1 + "'";

                //Creating SQL Command to pass value
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //cmd.Parameters.AddWithValue("@username", username1);
                //cmd.Parameters.AddWithValue("@password", password1);


                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                //Checking The rows in DataTable 
                if (dt.Rows.Count > 0)
                {
                    //Login Sucessful
                   
                    MainOperatorWindow mainoperatorwindow = new MainOperatorWindow();
                    MessageBox.Show("Sucsess login!");
                    mainoperatorwindow.Show();
                    
                    this.Close();
                    

                }
                else if (username1.Equals("admin") && password1.Equals("admin"))
                {
                    
                    MainWin adminpage = new MainWin();
                    MessageBox.Show("Sucsess login! Welcome to administrator account");

                    adminpage.Show();

                    this.Close();
                    


                }
                else
                {
                    //Login Failed
                    MessageBox.Show("Invalid Login please check username and password");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }







           
        }
    }
}
