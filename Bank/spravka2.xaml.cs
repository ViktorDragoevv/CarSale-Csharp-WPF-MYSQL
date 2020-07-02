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
    /// Interaction logic for spravka2.xaml
    /// </summary>
    public partial class spravka2 : Page
    {
        public spravka2()
        {
            InitializeComponent();
            //gridfillCars();
            comboxox();
        }
        public string myconnstrng = "server=localhost;user=root;database=saledb;port=3306;password=123456";
        public int selectedUser = 0;
        public DataSet ds = new DataSet();
        public void gridfillCars()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                try
                {


                    mysqlCon.Open();
                    MySqlDataAdapter mySqlDa = new MySqlDataAdapter("spravka2", mysqlCon);
                    selectedUser = CbCompany.SelectedIndex + 1;
                    mySqlDa.SelectCommand.Parameters.AddWithValue("_idCompany", selectedUser);
                    mySqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtcarss = new DataTable();
                    mySqlDa.Fill(dtcarss);

                    gvCars.DataContext = dtcarss;

                    mysqlCon.Close();
                    // String id = (String)ds.Tables[1].Rows[CbCompany.SelectedIndex]["idsaleOperator"];

                    // Console.WriteLine(ds);
                }
                catch (Exception e)
                {

                }




            }
        }


        private void comboxox()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                mysqlCon.Open();
                MySqlDataAdapter category_data = new MySqlDataAdapter("SELECT * FROM company", mysqlCon);
                
                category_data.Fill(ds, "company");
                CbCompany.DataContext = ds.Tables["company"].DefaultView;
                CbCompany.DisplayMemberPath = "companyName";

                CbCompany.SelectedIndex = 0;



            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(gvCars, "My First Print Job");
            }
        }

        private void CbCompany_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridfillCars();
        }
    }
}
