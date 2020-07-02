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
    /// Interaction logic for ADDSALE.xaml
    /// </summary>
    public partial class ADDSALE : Page
    {
        public string myconnstrng = "server=localhost;user=root;database=saledb;port=3306;password=123456";
        public int idSale=0;
        public ADDSALE()
        {
            InitializeComponent();
            gridfillClients();
            gridfillCars();
            comboxoxOperator();
        }

        public void gridfillCars()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                mysqlCon.Open();
                MySqlDataAdapter mySqlDa = new MySqlDataAdapter("carView2", mysqlCon);
                mySqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtcarss = new DataTable();
                mySqlDa.Fill(dtcarss);

                gvCars.DataContext = dtcarss;

                mysqlCon.Close();





            }
        }

        public void gridfillClients()
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

        private void comboxoxOperator()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                mysqlCon.Open();
                MySqlDataAdapter category_data = new MySqlDataAdapter("SELECT * FROM saleOperator", mysqlCon);
                DataSet ds = new DataSet();
                category_data.Fill(ds, "saleOperator");
                Cboperator.DataContext = ds.Tables["saleOperator"].DefaultView;
                Cboperator.DisplayMemberPath = "idsaleOperator";

                Cboperator.SelectedIndex = 0;


            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {


                DataRowView row1 = (DataRowView)gvCars.SelectedItem;
                int selectedIDFromCar = (int)row1["idCar"];


               



                DataRowView row3 = (DataRowView)gvClients.SelectedItem;
                int selectedIDFromCustomers = (int)row3["idcustomer"];

                var date = Convert.ToDateTime(dpDate.Text).ToString("yyyy/MM/dd");

                mysqlCon.Open();

                MySqlCommand mySqlCmd = new MySqlCommand("AddUpdateSale", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idSale", idSale);
                mySqlCmd.Parameters.AddWithValue("_SaleDate", date);
                mySqlCmd.Parameters.AddWithValue("_car_idCar", selectedIDFromCar);
                mySqlCmd.Parameters.AddWithValue("_saleOperator_idsaleOperator", Cboperator.Text);
                mySqlCmd.Parameters.AddWithValue("_customer_idcustomer", selectedIDFromCustomers);

                this.Dispatcher.Invoke(() =>
                {




                    mySqlCmd.ExecuteNonQuery();
                });

                MessageBox.Show("Submitted Successfully!");

                mysqlCon.Close();


            }
        }
    }
}
