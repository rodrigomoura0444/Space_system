namespace ModelsPOO.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panelMenu = new Panel();
            button4 = new Button();
            button3 = new Button();
            Menu = new Button();
            button1 = new Button();
            panelLogo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(46, 51, 73);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(Menu);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(2, 2, 2, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(172, 369);
            panelMenu.TabIndex = 0;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Image = Properties.Resources.dashboard1;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 238);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(172, 55);
            button4.TabIndex = 4;
            button4.Text = "   Dashboard";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 181);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(172, 57);
            button3.TabIndex = 3;
            button3.Text = "   Dashboard";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            Menu.Dock = DockStyle.Top;
            Menu.FlatStyle = FlatStyle.Flat;
            Menu.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            Menu.ForeColor = SystemColors.ButtonFace;
            Menu.Image = (Image)resources.GetObject("Menu.Image");
            Menu.ImageAlign = ContentAlignment.MiddleLeft;
            Menu.Location = new Point(0, 125);
            Menu.Margin = new Padding(2, 2, 2, 2);
            Menu.Name = "Menu";
            Menu.Size = new Size(172, 56);
            Menu.TabIndex = 2;
            Menu.Text = "   Dashboard";
            Menu.TextImageRelation = TextImageRelation.ImageBeforeText;
            Menu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.dashboard1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 65);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(172, 60);
            button1.TabIndex = 1;
            button1.Text = "   Dashboard";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(2, 2, 2, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(172, 65);
            panelLogo.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(839, 369);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Dashboard";
            Load += Dashboard_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button button1;
        private Panel panelLogo;
        private Button button4;
        private Button button3;
        private Button Menu;
    }
}