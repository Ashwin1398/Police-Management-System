namespace Police_Database_System
{
    partial class Ashwin13_appbody
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ashwin13_appbody));
            this.LOG_IN_Timer = new System.Windows.Forms.Timer(this.components);
            this.SP_Timer = new System.Windows.Forms.Timer(this.components);
            this.Sliding_Panel = new System.Windows.Forms.Panel();
            this.CreditsTabButton = new System.Windows.Forms.Button();
            this.CasesTabButton = new System.Windows.Forms.Button();
            this.FIRTabButton = new System.Windows.Forms.Button();
            this.AccusedTabButton = new System.Windows.Forms.Button();
            this.VictimTabButton = new System.Windows.Forms.Button();
            this.PetitionerTabButton = new System.Windows.Forms.Button();
            this.OfficerTabButton = new System.Windows.Forms.Button();
            this.SP_ToggleButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.Sliding_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LOG_IN_Timer
            // 
            this.LOG_IN_Timer.Interval = 50;
            this.LOG_IN_Timer.Tick += new System.EventHandler(this.LOG_IN_Timer_Tick);
            // 
            // SP_Timer
            // 
            this.SP_Timer.Interval = 10;
            this.SP_Timer.Tick += new System.EventHandler(this.SP_Timer_Tick);
            // 
            // Sliding_Panel
            // 
            this.Sliding_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Sliding_Panel.BackgroundImage = global::Police_Database_System.Properties.Resources.Slider_BG;
            this.Sliding_Panel.Controls.Add(this.CreditsTabButton);
            this.Sliding_Panel.Controls.Add(this.CasesTabButton);
            this.Sliding_Panel.Controls.Add(this.FIRTabButton);
            this.Sliding_Panel.Controls.Add(this.AccusedTabButton);
            this.Sliding_Panel.Controls.Add(this.VictimTabButton);
            this.Sliding_Panel.Controls.Add(this.PetitionerTabButton);
            this.Sliding_Panel.Controls.Add(this.OfficerTabButton);
            this.Sliding_Panel.Controls.Add(this.SP_ToggleButton);
            this.Sliding_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Sliding_Panel.ForeColor = System.Drawing.Color.Black;
            this.Sliding_Panel.Location = new System.Drawing.Point(771, 0);
            this.Sliding_Panel.Name = "Sliding_Panel";
            this.Sliding_Panel.Size = new System.Drawing.Size(234, 560);
            this.Sliding_Panel.TabIndex = 0;
            this.Sliding_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Sliding_Panel_Paint);
            // 
            // CreditsTabButton
            // 
            this.CreditsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditsTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsTabButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreditsTabButton.Image = global::Police_Database_System.Properties.Resources.Credits_;
            this.CreditsTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreditsTabButton.Location = new System.Drawing.Point(0, 338);
            this.CreditsTabButton.Name = "CreditsTabButton";
            this.CreditsTabButton.Size = new System.Drawing.Size(240, 50);
            this.CreditsTabButton.TabIndex = 9;
            this.CreditsTabButton.Text = "Credits";
            this.CreditsTabButton.UseVisualStyleBackColor = true;
            this.CreditsTabButton.Click += new System.EventHandler(this.CreditsTabButton_Click);
            // 
            // CasesTabButton
            // 
            this.CasesTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CasesTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CasesTabButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CasesTabButton.Image = global::Police_Database_System.Properties.Resources.Case;
            this.CasesTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CasesTabButton.Location = new System.Drawing.Point(0, 240);
            this.CasesTabButton.Name = "CasesTabButton";
            this.CasesTabButton.Size = new System.Drawing.Size(240, 50);
            this.CasesTabButton.TabIndex = 6;
            this.CasesTabButton.Text = "Cases";
            this.CasesTabButton.UseVisualStyleBackColor = true;
            this.CasesTabButton.Click += new System.EventHandler(this.button9_Click);
            // 
            // FIRTabButton
            // 
            this.FIRTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FIRTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIRTabButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FIRTabButton.Image = global::Police_Database_System.Properties.Resources.FIR;
            this.FIRTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FIRTabButton.Location = new System.Drawing.Point(0, 191);
            this.FIRTabButton.Name = "FIRTabButton";
            this.FIRTabButton.Size = new System.Drawing.Size(240, 50);
            this.FIRTabButton.TabIndex = 5;
            this.FIRTabButton.Text = "FIR";
            this.FIRTabButton.UseVisualStyleBackColor = true;
            this.FIRTabButton.Click += new System.EventHandler(this.FIRTabButton_Click);
            // 
            // AccusedTabButton
            // 
            this.AccusedTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccusedTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccusedTabButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AccusedTabButton.Image = global::Police_Database_System.Properties.Resources.Accused_;
            this.AccusedTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccusedTabButton.Location = new System.Drawing.Point(0, 143);
            this.AccusedTabButton.Name = "AccusedTabButton";
            this.AccusedTabButton.Size = new System.Drawing.Size(240, 50);
            this.AccusedTabButton.TabIndex = 4;
            this.AccusedTabButton.Text = "Accused";
            this.AccusedTabButton.UseVisualStyleBackColor = true;
            this.AccusedTabButton.Click += new System.EventHandler(this.AccusedTabButton_Click);
            // 
            // VictimTabButton
            // 
            this.VictimTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VictimTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VictimTabButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VictimTabButton.Image = global::Police_Database_System.Properties.Resources.Victim;
            this.VictimTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VictimTabButton.Location = new System.Drawing.Point(0, 96);
            this.VictimTabButton.Name = "VictimTabButton";
            this.VictimTabButton.Size = new System.Drawing.Size(240, 50);
            this.VictimTabButton.TabIndex = 3;
            this.VictimTabButton.Text = "Victim";
            this.VictimTabButton.UseVisualStyleBackColor = true;
            this.VictimTabButton.Click += new System.EventHandler(this.VictimTabButton_Click);
            // 
            // PetitionerTabButton
            // 
            this.PetitionerTabButton.BackColor = System.Drawing.Color.Transparent;
            this.PetitionerTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PetitionerTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetitionerTabButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PetitionerTabButton.Image = global::Police_Database_System.Properties.Resources.Petitioner_1;
            this.PetitionerTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PetitionerTabButton.Location = new System.Drawing.Point(0, 46);
            this.PetitionerTabButton.Name = "PetitionerTabButton";
            this.PetitionerTabButton.Size = new System.Drawing.Size(240, 50);
            this.PetitionerTabButton.TabIndex = 2;
            this.PetitionerTabButton.Text = "Petitioner";
            this.PetitionerTabButton.UseVisualStyleBackColor = false;
            this.PetitionerTabButton.Click += new System.EventHandler(this.PetitionerTabButton_Click);
            // 
            // OfficerTabButton
            // 
            this.OfficerTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OfficerTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfficerTabButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OfficerTabButton.Image = global::Police_Database_System.Properties.Resources.Officer;
            this.OfficerTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OfficerTabButton.Location = new System.Drawing.Point(0, 289);
            this.OfficerTabButton.Name = "OfficerTabButton";
            this.OfficerTabButton.Size = new System.Drawing.Size(240, 50);
            this.OfficerTabButton.TabIndex = 7;
            this.OfficerTabButton.Text = "Officer";
            this.OfficerTabButton.UseVisualStyleBackColor = true;
            this.OfficerTabButton.Click += new System.EventHandler(this.OfficerTabButton_Click);
            // 
            // SP_ToggleButton
            // 
            this.SP_ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SP_ToggleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SP_ToggleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SP_ToggleButton.Image = global::Police_Database_System.Properties.Resources.Left_Expand;
            this.SP_ToggleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SP_ToggleButton.Location = new System.Drawing.Point(0, 0);
            this.SP_ToggleButton.Name = "SP_ToggleButton";
            this.SP_ToggleButton.Size = new System.Drawing.Size(240, 50);
            this.SP_ToggleButton.TabIndex = 1;
            this.SP_ToggleButton.UseVisualStyleBackColor = true;
            this.SP_ToggleButton.Click += new System.EventHandler(this.SP_ToggleButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.ContentPanel.BackgroundImage = global::Police_Database_System.Properties.Resources.App_body_BG;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(753, 560);
            this.ContentPanel.TabIndex = 1;
            // 
            // Ashwin13_appbody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Police_Database_System.Properties.Resources.App_body_BG;
            this.ClientSize = new System.Drawing.Size(1005, 560);
            this.Controls.Add(this.Sliding_Panel);
            this.Controls.Add(this.ContentPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ashwin13_appbody";
            this.Text = "Ashwin13_appbody";
            this.Load += new System.EventHandler(this.Ashwin13_appbody_Load);
            this.Sliding_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer LOG_IN_Timer;
        private System.Windows.Forms.Panel Sliding_Panel;
        private System.Windows.Forms.Button SP_ToggleButton;
        private System.Windows.Forms.Timer SP_Timer;
        private System.Windows.Forms.Button FIRTabButton;
        private System.Windows.Forms.Button AccusedTabButton;
        private System.Windows.Forms.Button VictimTabButton;
        private System.Windows.Forms.Button PetitionerTabButton;
        private System.Windows.Forms.Button CreditsTabButton;
        private System.Windows.Forms.Button OfficerTabButton;
        private System.Windows.Forms.Button CasesTabButton;
        private System.Windows.Forms.Panel ContentPanel;
    }
}