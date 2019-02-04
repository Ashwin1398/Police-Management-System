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
    public partial class Cases_UserControl : UserControl
    {
        private static Cases_UserControl _instance;

        public static Cases_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Cases_UserControl();
                }
                return _instance;
            }
        }

        public Cases_UserControl()
        {
            InitializeComponent();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");


        private void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllCasedata_SP", Connect);
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

                Case_dataGridView.DataSource = DS.Tables[0];
                this.Case_dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Case_dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Case_dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Case_dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Case_dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Case_dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }



        }

        private void AddNewbutton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Cases_SP", Connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Case_ID", caseid_textBox.Text);
            cmd.Parameters.AddWithValue("@Case_Status", CaseStatus_textBox.Text);
            cmd.Parameters.AddWithValue("@Case_Detail", CaseDetail_textBox.Text);
            cmd.Parameters.AddWithValue("@Section_of_law", Sec_textBox.Text);
            cmd.Parameters.AddWithValue("@Officer_ID", Officer_textBox.Text);
          
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

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchCase_SP", Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Case_ID", Case_textBox.Text);

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

                Case_dataGridView.DataSource = DS.Tables[0];
                this.Case_dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Case_dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Case_dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Case_dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Case_dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.Case_dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("CaseDelete_SP", Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Case_ID", Case_textBox.Text);


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

        private void button8_Click(object sender, EventArgs e)
        {
            caseid_textBox.Text =" ";
            CaseStatus_textBox.Text =" ";
            CaseDetail_textBox.Text =" ";
            Sec_textBox.Text =" ";
            Officer_textBox.Text =" ";
        }

        private void Cases_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
    }
}
