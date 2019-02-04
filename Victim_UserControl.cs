using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_Database_System
{
    public partial class Victim_UserControl : UserControl
    {
        private static Victim_UserControl _instance;

        public static Victim_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Victim_UserControl();
                }
                return _instance;
            }
        }

        public Victim_UserControl()
        {
            InitializeComponent();
        }

        private void Victim_UserControl_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
