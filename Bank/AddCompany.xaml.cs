using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bank
{
    /// <summary>
    /// Interaction logic for AddCompany.xaml
    /// </summary>
    public partial class AddCompany : Page
    {

        int idcompany = 0;
        int idcolor = 0;
        int idclasses = 0;

        string myconnstrng = "server=localhost;user=root;database=saledb;port=3306;password=123456";
        public AddCompany()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {

                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("AddUpdateCompany", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idcompany", idcompany);
                mySqlCmd.Parameters.AddWithValue("_companyName", tbCompanyName.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_companyAddress", tbCompanyAddress.Text.Trim());
               

                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");
                


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {

                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("addUpdateColor", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idcolor", idcolor);
                mySqlCmd.Parameters.AddWithValue("_color", tbColor.Text.Trim());
                


                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");



            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {

                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("AddClasses", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idclasses", idclasses);
                mySqlCmd.Parameters.AddWithValue("_classType", tbCarClass.Text.Trim());



                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");



            }
        }
    }
}
