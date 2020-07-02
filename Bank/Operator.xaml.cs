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
    /// Interaction logic for Operator.xaml
    /// </summary>
    public partial class Operator : Page
    {
        int idsaleOperator = 0;
      
        string myconnstrng = "server=localhost;user=root;database=saledb;port=3306;password=123456";
        public Operator()
        {
            InitializeComponent();
            comboxox();
            gridfill(); 
        }

       

        private void comboxox()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                mysqlCon.Open();
                MySqlDataAdapter category_data = new MySqlDataAdapter("SELECT * FROM company", mysqlCon);
                DataSet ds = new DataSet();
                category_data.Fill(ds, "company");
                CbCompany.DataContext = ds.Tables["company"].DefaultView;
                CbCompany.DisplayMemberPath = "companyName";
                
                CbCompany.SelectedIndex = 0;


            }

         }

       


        void gridfill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                mysqlCon.Open();
                MySqlDataAdapter mySqlDa = new MySqlDataAdapter("OperatorView", mysqlCon);
                mySqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtoperators = new DataTable();
                mySqlDa.Fill(dtoperators);
                grView.DataContext = dtoperators;
                // grView.DataContext = dtoperators.DefaultView;
                
                
                
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("OperatorAddOrupdate", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idsaleOperator", idsaleOperator);
                mySqlCmd.Parameters.AddWithValue("_saleOperatorName", name.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_saleOperatorUserName", userName.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_saleOperatorPassword", pass.Password.Trim());
                mySqlCmd.Parameters.AddWithValue("_idcompany", CbCompany.Text.Trim());


                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");
                gridfill();


            }
        }

        private void grView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
           // name.Text = grView.SelectedCells[1].ToString();
           // pass.Password = grView.SelectedCells[2].ToString();
            
            DataRowView rowView = grView.SelectedItem as DataRowView;
            name.Text = rowView.Row[0].ToString();
            userName.Text = rowView.Row[1].ToString();
            pass.Password = rowView.Row[2].ToString();

            
            



        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                DataRowView row = (DataRowView)grView.SelectedItem;
                int selectedIDFromDataGrid = (int)row["idsaleOperator"];
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("deleteOperator", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idsaleOperator", selectedIDFromDataGrid);
                

                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");
                gridfill();


            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
            {
                DataRowView row = (DataRowView)grView.SelectedItem;
                int selectedIDFromDataGrid = (int)row["idsaleOperator"];
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("OperatorAddOrupdate", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idsaleOperator", selectedIDFromDataGrid);
                mySqlCmd.Parameters.AddWithValue("_saleOperatorName", name.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_saleOperatorUserName", userName.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_saleOperatorPassword", pass.Password.Trim());
                mySqlCmd.Parameters.AddWithValue("_idcompany", CbCompany.Text.Trim());


                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");
                gridfill();


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

                using (MySqlConnection mysqlCon = new MySqlConnection(myconnstrng))
                {
                    
                    mysqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("OperatorAddOrupdate", mysqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_idsaleOperator", idsaleOperator);
                    mySqlCmd.Parameters.AddWithValue("_saleOperatorName", name.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_saleOperatorUserName", userName.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_saleOperatorPassword", pass.Password.Trim());
                    mySqlCmd.Parameters.AddWithValue("_idcompany", CbCompany.Text.Trim());

                    mySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Submitted Successfully!");
                    gridfill();




                }
            
        }

        private void CbCompany_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    }

