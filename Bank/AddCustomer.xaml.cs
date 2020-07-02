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
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Page
    {
        int idcustomer = 0;

        string myconnstrng = "server=localhost;user=root;database=saledb;port=3306;password=123456";

        public AddCustomer()
        {
            InitializeComponent();
            gridfill();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {

                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("addUpdateCustomer", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idcustomer", idcustomer);
                mySqlCmd.Parameters.AddWithValue("_customerName", tbClientName.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_customerAddress", tbCustomerAddress.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_customerIDNum", tbCustomerID.Text.Trim());
                


                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");
                gridfill();


            }

        }

        void gridfill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                mysqlCon.Open();
                MySqlDataAdapter mySqlDa = new MySqlDataAdapter("customerView", mysqlCon);
                mySqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtClients = new DataTable();
                mySqlDa.Fill(dtClients);

                gvClients.DataContext = dtClients;




            }
        }

    }
}
