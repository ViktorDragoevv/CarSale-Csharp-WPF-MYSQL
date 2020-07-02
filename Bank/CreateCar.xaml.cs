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
    /// Interaction logic for CreateCar.xaml
    /// </summary>
    public partial class CreateCar : Page
    {
        public CreateCar()
        {
            InitializeComponent();
            comboxox();
            comboxox2();
            gridfill();
        }
        int idCar = 0;

        string myconnstrng = "server=localhost;user=root;database=saledb;port=3306;password=123456";


        void gridfill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                mysqlCon.Open();
                MySqlDataAdapter mySqlDa = new MySqlDataAdapter("carView", mysqlCon);
                mySqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtcars = new DataTable();
                mySqlDa.Fill(dtcars);
                
                gvCars.DataContext = dtcars;
                



            }
        }



        private void comboxox()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                mysqlCon.Open();
                MySqlDataAdapter category_data = new MySqlDataAdapter("SELECT * FROM color", mysqlCon);
                DataSet ds = new DataSet();
                category_data.Fill(ds, "color");
                cbColor.DataContext = ds.Tables["color"].DefaultView;
                cbColor.DisplayMemberPath = "color";

                cbColor.SelectedIndex = 0;


            }

        }

        private void comboxox2()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                mysqlCon.Open();
                MySqlDataAdapter category_data = new MySqlDataAdapter("SELECT * FROM classes", mysqlCon);
                DataSet ds = new DataSet();
                category_data.Fill(ds, "classes");
                cbCarClass.DataContext = ds.Tables["classes"].DefaultView;
                cbCarClass.DisplayMemberPath = "classType";

                cbCarClass.SelectedIndex = 0;


            }

        }

        private void btsave_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {

                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("addUpdateCar", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idCar", idCar);
                mySqlCmd.Parameters.AddWithValue("_carModel", tbModel.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_carCondition", tbCondition.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_carPrice", tbPrice.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_carStatus", tbAvailability.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_carFuelType", tbEngine.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_carKM", tbCurrKM.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_classes_idclasses", cbCarClass.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_color_idcolor", cbColor.Text.Trim());


                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");
                gridfill();


            }
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRowView rowView = gvCars.SelectedItem as DataRowView;
            tbModel.Text = rowView.Row[0].ToString();
            tbCondition.Text = rowView.Row[1].ToString();
            tbPrice.Text = rowView.Row[2].ToString();
            tbAvailability.Text = rowView.Row[3].ToString();
            tbEngine.Text = rowView.Row[4].ToString();
            tbCurrKM.Text = rowView.Row[5].ToString();
           

        }

        private void btChange_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                DataRowView row = (DataRowView)gvCars.SelectedItem;
                int selectedIDFromDataGrid = (int)row["idCar"];
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("addUpdateCar", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idCar", selectedIDFromDataGrid);
                mySqlCmd.Parameters.AddWithValue("_carModel", tbModel.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_carCondition", tbCondition.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_carPrice", tbPrice.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_carStatus", tbAvailability.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_carFuelType", tbEngine.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_carKM", tbCurrKM.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_classes_idclasses", cbCarClass.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_color_idcolor", cbColor.Text.Trim());


                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");
                gridfill();


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                DataRowView row = (DataRowView)gvCars.SelectedItem;
                int selectedIDFromDataGrid = (int)row["idCar"];
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("carDelete", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idCar", selectedIDFromDataGrid);
                


                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");
                gridfill();


            }
        }
    }
}
