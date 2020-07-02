using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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
    /// Interaction logic for SaleCar.xaml
    /// </summary>
    public partial class SaleCar : Page
    {
        public int idSale = 0;
        

     
        public string myconnstrng = "server=localhost;user=root;database=saledb;port=3306;password=123456";

        public SaleCar()
        {
            InitializeComponent();
            gridfillClients();
            gridfillCars();
            gridfillOperator();
            gridfillSale();
        }


       public  void gridfillCars()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                mysqlCon.Open();
                MySqlDataAdapter mySqlDa = new MySqlDataAdapter("carView", mysqlCon);
                mySqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtcarss = new DataTable();
                mySqlDa.Fill(dtcarss);

                gvCars.DataContext = dtcarss;

                mysqlCon.Close();





            }
        }

       public  void gridfillClients()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                mysqlCon.Open();
                MySqlDataAdapter mySqlDa = new MySqlDataAdapter("clientView2", mysqlCon);
                mySqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtClientss = new DataTable();
                mySqlDa.Fill(dtClientss);

                gvClients.DataContext = dtClientss;
                mysqlCon.Close();





            }
        }

        public void gridfillOperator()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                mysqlCon.Open();
                MySqlDataAdapter mySqlDa = new MySqlDataAdapter("ViewOperator2", mysqlCon);
                mySqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtoperatorss = new DataTable();
                mySqlDa.Fill(dtoperatorss);
                gvOperators.DataContext = dtoperatorss;
                // grView.DataContext = dtoperators.DefaultView;
                mysqlCon.Close();




            }
        }
        public void gridfillSale()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                mysqlCon.Open();
                MySqlDataAdapter mySqlDa = new MySqlDataAdapter("saleView", mysqlCon);
                mySqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtsale = new DataTable();
                mySqlDa.Fill(dtsale);
                gvSale.DataContext = dtsale;
                // grView.DataContext = dtoperators.DefaultView;
                mysqlCon.Close();




            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            (gvCars.DataContext as DataTable).DefaultView.RowFilter = string.Format("carModel LIKE '%{0}%'", tbSearch.Text);
            
        }

        private void tbSearchClient_KeyDown(object sender, KeyEventArgs e)
        {
            (gvClients.DataContext as DataTable).DefaultView.RowFilter = string.Format("customerIDNum LIKE '%{0}%'", tbSearchClient.Text);
        }

        private void tbSearchOperator_KeyDown(object sender, KeyEventArgs e)
        {
            (gvOperators.DataContext as DataTable).DefaultView.RowFilter = string.Format("saleOperatorName LIKE '%{0}%'", tbSearchOperator.Text);
        }




       



        private void Button_Click(object sender, RoutedEventArgs e)

        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {

                
                DataRowView row1 = (DataRowView)gvCars.SelectedItem;
                int selectedIDFromCar = (int)row1["idCar"];
                

                DataRowView row2 = (DataRowView)gvOperators.SelectedItem;
                int selectedIDFromDataGrid = (int)row2["idsaleOperator"];

                

                DataRowView row3 = (DataRowView)gvClients.SelectedItem;
                int selectedIDFromCustomers = (int)row3["idcustomer"];

                //MessageBox.Show(""+selectedIDFromCar+selectedIDFromDataGrid+ selectedIDFromCustomers+"");

                var date = Convert.ToDateTime(dpDate.Text).ToString("yyyy/MM/dd");
                mysqlCon.Open();

                MySqlCommand mySqlCmd = new MySqlCommand("AddUpdateSale", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idSale", idSale);
                mySqlCmd.Parameters.AddWithValue("_SaleDate", date);
                mySqlCmd.Parameters.AddWithValue("_car_idCar", selectedIDFromCar);
                mySqlCmd.Parameters.AddWithValue("_saleOperator_idsaleOperator", selectedIDFromDataGrid);
                mySqlCmd.Parameters.AddWithValue("_customer_idcustomer", selectedIDFromCustomers);



                this.Dispatcher.Invoke(() =>
                {
                    mySqlCmd.ExecuteNonQuery();
                });

                MessageBox.Show("Submitted Successfully!");
                gridfillSale();

                mysqlCon.Close();

               
            }
        }

        
    }
}
