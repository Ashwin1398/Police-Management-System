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
    public partial class Accused_UserControl : UserControl
    {
        private static Accused_UserControl _instance;

        public static Accused_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Accused_UserControl();
                }
                return _instance;
            }
        }

        public Accused_UserControl()
        {

            InitializeComponent();
        }
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");

        private void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllFIRdata_SP", Connect);
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

                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }



        }


        private void AddNewbutton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Accused_SP", Connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Accused_ID", AccusedID_Textbox.Text);
            cmd.Parameters.AddWithValue("@Name", Name_textbox.Text);
            cmd.Parameters.AddWithValue("@FatherName", Fathername_textbox.Text);
            cmd.Parameters.AddWithValue("@Age", Age_textbox.Text);
            cmd.Parameters.AddWithValue("@Gender", Gender_textbox.Text);
            cmd.Parameters.AddWithValue("@FIRID", FIRID_textbox.Text);
            cmd.Parameters.AddWithValue("@NIC", NIC_textbox.Text);
            cmd.Parameters.AddWithValue("@EMAIL", Email_textbox.Text);

            Connect.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("                                             <<<<<INVALID SQL OPERATION>>>>>: \n" + ex);
            }
            Connect.Close();

            refresh_DataGridView();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Accused_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Accuseddelete_SP", Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accused_ID", Accused_textbox.Text);


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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchAccused_SP", Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Accused_ID", Accused_textbox.Text);

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

                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            Accused_textbox.Text = " ";
            AccusedID_Textbox.Text = "";
            Name_textbox.Text = "";
            Fathername_textbox.Text = "";
            Age_textbox.Text = "";
            Gender_textbox.Text = "";
            FIRID_textbox.Text ="";
            NIC_textbox.Text ="";
            Email_textbox.Text ="";

        }
    }
    
}