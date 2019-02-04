using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Police_Database_System
{
    public partial class Ashwin13_appbody : Form
    {
        public Ashwin13_appbody()
        {
            InitializeComponent();

            //Initialization of Sliding Panel
            isSliding_PanelExpanded = true;
            expandSliding_PanelGUI();
        }

        private void Ashwin13_appbody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            LOG_IN_Timer.Start();
        }

        private void LOG_IN_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                LOG_IN_Timer.Stop();
            }
        }

       public void expandSliding_PanelGUI()
        {
            //gui adjustments for expanding
            PetitionerTabButton.Text = "Petitioner";
            VictimTabButton.Text = "Victim";
            AccusedTabButton.Text = "Accused";
            FIRTabButton.Text = "FIR";
            CasesTabButton.Text = "Cases";
            OfficerTabButton.Text = "Officer";
           
            CreditsTabButton.Text = "Credits";
            SP_ToggleButton.Image = Properties.Resources.Left_Expand;
            PetitionerTabButton.Image = null;
            VictimTabButton.Image = null;
            AccusedTabButton.Image = null;
            FIRTabButton.Image = null;
            CasesTabButton.Image = null;
            OfficerTabButton.Image = null;
           
            CreditsTabButton.Image = null;

        }

        public void retractSliding_PanelGUI()
        {
            //gui adjustments for expanding
            PetitionerTabButton.Text = "";
            VictimTabButton.Text = "";
            AccusedTabButton.Text = "";
            FIRTabButton.Text = "";
            CasesTabButton.Text = "";
            OfficerTabButton.Text = "";
           
            CreditsTabButton.Text = "";
            SP_ToggleButton.Image = Properties.Resources.Right_Expand;
            PetitionerTabButton.Image = Properties.Resources.Petitioner_1;
            VictimTabButton.Image = Properties.Resources.Victim;
            AccusedTabButton.Image = Properties.Resources.Accused_ ;
            FIRTabButton.Image = Properties.Resources.FIR;
            CasesTabButton.Image = Properties.Resources.Case;
            OfficerTabButton.Image = Properties.Resources.Officer;
           
            CreditsTabButton.Image = Properties.Resources.Credits_;

        }


        // Sliding Panel 
        bool isSliding_PanelExpanded;
        const int MaxSliderWidth = 240;
        const int MinSliderWidth = 60;


        private void SP_ToggleButton_Click(object sender, EventArgs e)
        {
            if(isSliding_PanelExpanded)
            {
                
            }
            SP_Timer.Start();

        }

        private void Sliding_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SP_Timer_Tick(object sender, EventArgs e)
        {

            if (isSliding_PanelExpanded)
            {
                // retract pannel
                Sliding_Panel.Width -= 22;
                if (Sliding_Panel.Width <= MinSliderWidth)
                {
                    //stop retract
                    isSliding_PanelExpanded = false;
                    SP_Timer.Stop();
                    retractSliding_PanelGUI();
                    this.Refresh();
                }
            }
            else
            {
                //expand the pannel
                Sliding_Panel.Width += 22;
                if (Sliding_Panel.Width >= MaxSliderWidth)
                {
                    //stop expanding
                    isSliding_PanelExpanded = true;
                    SP_Timer.Stop();
                    expandSliding_PanelGUI();
                    this.Refresh();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Cases_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Cases_UserControl.Instance);
                Cases_UserControl.Instance.Dock = DockStyle.Fill;
                Cases_UserControl.Instance.BringToFront();
            }
            else
            {
                Cases_UserControl.Instance.BringToFront();
            }

        }

        private void PetitionerTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Petitioner_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Petitioner_UserControl.Instance);
                Petitioner_UserControl.Instance.Dock = DockStyle.Fill;
                Petitioner_UserControl.Instance.BringToFront();
            }
            else
            {
                Petitioner_UserControl.Instance.BringToFront();
            }

        }

        private void VictimTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Victim_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Victim_UserControl.Instance);
                Victim_UserControl.Instance.Dock = DockStyle.Fill;
                Victim_UserControl.Instance.BringToFront();
            }
            else
            {
                Victim_UserControl.Instance.BringToFront();
            }
        }

        private void AccusedTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Accused_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Accused_UserControl.Instance);
                Accused_UserControl.Instance.Dock = DockStyle.Fill;
                Accused_UserControl.Instance.BringToFront();
            }
            else
            {
                Accused_UserControl.Instance.BringToFront();
            }
        }

        private void FIRTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(FIR_UserControl.Instance))
            {
                ContentPanel.Controls.Add(FIR_UserControl.Instance);
                FIR_UserControl.Instance.Dock = DockStyle.Fill;
                FIR_UserControl.Instance.BringToFront();
            }
            else
            {
                FIR_UserControl.Instance.BringToFront();
            }
        }

        private void OfficerTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Officer_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Officer_UserControl.Instance);
                Officer_UserControl.Instance.Dock = DockStyle.Fill;
                Officer_UserControl.Instance.BringToFront();
            }
            else
            {
                Officer_UserControl.Instance.BringToFront();
            }
        }

      

        private void CreditsTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Credits_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Credits_UserControl.Instance);
                Credits_UserControl.Instance.Dock = DockStyle.Fill;
                Credits_UserControl.Instance.BringToFront();
            }
            else
            {
                Credits_UserControl.Instance.BringToFront();
            }
        }
    }
}

