using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Police_Database_System
{
    public partial class Officer_UserControl : UserControl
    {
        private static Officer_UserControl _instance;

        public static Officer_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Officer_UserControl();
                }
                return _instance;
            }
        }


        public Officer_UserControl()
        {
            InitializeComponent();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        private void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllOfficerdata_SP", Connect);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


                Connect.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("                                    <<<<<INVALID SQL OPERATION>>>>>: \n" + ex);
                }
                Connect.Close();

                Officer_dataGridView.DataSource = DS.Tables[0];
                this.Officer_dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Officer_dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Officer_dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Officer_dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }



        }
        private void button8_Click(object sender, EventArgs e)
        {
            Officer_textBox.Text =" ";
            Name_textBox.Text =" ";
            Rank_textBox.Text =" ";

        }

        private void AddNewbutton_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Officer_SP", Connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Officer_ID", Officer_textBox.Text);
            cmd.Parameters.AddWithValue("@Name",Name_textBox.Text);
            cmd.Parameters.AddWithValue("@Rank", Rank_textBox.Text);
          

            Connect.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("                                             <<<<<INVALID SQL OPERATION>>>>>: \n" + ex);
            }
            Connect.Close();

            refresh_DataGridView();
        }

        private void Officer_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("OfficerDelete_SP", Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Officer_ID", OfficerID_textBox.Text);


                Connect.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("                                             <<<<<INVALID SQL OPERATION>>>>>: \n" + ex);
                }
                Connect.Close();

                refresh_DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SearchOfficer_SP", Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Officer_ID", OfficerID_textBox.Text);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                Connect.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("                                    <<<<<INVALID SQL OPERATION>>>>>: \n" + ex);
                }
                Connect.Close();

                Officer_dataGridView.DataSource = DS.Tables[0];
                this.Officer_dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Officer_dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Officer_dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Officer_dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
    
}
