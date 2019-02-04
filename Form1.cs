using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WMPLib;

namespace Police_Database_System
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            player.URL = "Moby OST.mp3";

        }

        SqlConnection Connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\DatabasePC.mdf\";Integrated Security=True");
        SqlCommand Cmd;
        SqlDataReader Reader;

        private String getUsername()
        {
            //fetches data from DatabasePC as of my case 'XD' 
            Connect.Open();
            String syntax = "SELECT Value FROM SystemTable where Property = 'Username'";
            Cmd = new SqlCommand(syntax, Connect);
            Reader = Cmd.ExecuteReader();
            Reader.Read();
            String temp = Reader[0].ToString();
            Connect.Close();
            return temp;
        }

        private String getPassword()
        {
            //fetches data from DatabasePC as of my case 'XD'
            Connect.Open();
            String syntax = "SELECT Value FROM SystemTable where Property = 'Password'";
            Cmd = new SqlCommand(syntax, Connect);
            Reader = Cmd.ExecuteReader();
            Reader.Read();
            String temp = Reader[0].ToString();
            Connect.Close();
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String Uname=getUsername(), Upass=getPassword(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if(name.Equals(Uname) && pass.Equals(Upass))
            {
                //login
                player.URL = "pubg.mp3";
                label3.Hide();
                MessageBox.Show("LOG IN SUCCESSFUL");
                Ashwin13_appbody ash = new Ashwin13_appbody();
                this.Hide();
                ash.Show();
            }
            else
            {
                //don't login
                label3.Show();
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }
    }
}
