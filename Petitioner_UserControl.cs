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
    public partial class Petitioner_UserControl : UserControl
    {
        private static Petitioner_UserControl _instance;

        public static Petitioner_UserControl Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Petitioner_UserControl();
                }
                return _instance;
            }
        }
        public Petitioner_UserControl()
        {
           
            InitializeComponent();

        }
         SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabasePC.mdf;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
