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
    public partial class FIR_UserControl : UserControl
    {
        private static FIR_UserControl _instance;

        public static FIR_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FIR_UserControl();
                }
                return _instance;
            }
        }

        public FIR_UserControl()
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

                FIR_dataGridView.DataSource = DS.Tables[0];
                this.FIR_dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }



        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AddNewbutton_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("FIR_SP", Connect);
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.AddWithValue("@FIR_ID",  FIRID_textbox.Text);
            cmd.Parameters.AddWithValue("@Incident_date", Incd_textBox.Text);
            cmd.Parameters.AddWithValue("@Incident_time", Inct_textBox.Text);
            cmd.Parameters.AddWithValue("@Incident_place", Incp_textBox.Text);
            cmd.Parameters.AddWithValue("@Time_lodged",  Tl_textBox.Text);
            cmd.Parameters.AddWithValue("@Date_lodged",  Dl_textbox.Text);
            cmd.Parameters.AddWithValue("@Petitioner_ID",  Pid_textBox.Text);
            cmd.Parameters.AddWithValue("@Petitioner_Name", Pn_textbox.Text);
            cmd.Parameters.AddWithValue("@Victim_Name",  Vn_textbox.Text);
            cmd.Parameters.AddWithValue("@Victim_Address", Va_textbox.Text);
            cmd.Parameters.AddWithValue("@Case_id",  Case_textBox.Text);


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

        private void FIR_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("FIRdelete_SP", Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FIR_ID",  Fir_textBox.Text);


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
                SqlCommand cmd = new SqlCommand("SearchFIR", Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FIR_ID", Fir_textBox.Text);

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
                FIR_dataGridView.DataSource = DS.Tables[0];
                this.FIR_dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.FIR_dataGridView.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            FIRID_textbox.Text = " ";
           Incd_textBox.Text = " ";
            Inct_textBox.Text = " ";
          Incp_textBox.Text = " ";
            Tl_textBox.Text = " ";
            Dl_textbox.Text = " ";
            Pid_textBox.Text = " ";
             Pn_textbox.Text = " ";
            Vn_textbox.Text = " ";
            Va_textbox.Text = " ";
            Case_textBox.Text = " ";

        }
    }
}
