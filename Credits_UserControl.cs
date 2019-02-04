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
    public partial class Credits_UserControl : UserControl
    {
        private static Credits_UserControl _instance;

        public static Credits_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Credits_UserControl();
                }
                return _instance;
            }
        }
        public Credits_UserControl()
        {
            InitializeComponent();
        }
    }
}
