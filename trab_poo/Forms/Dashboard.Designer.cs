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
            menuStrip1 = new MenuStrip();
            tttToolStripMenuItem = new ToolStripMenuItem();
            dwdwdToolStripMenuItem = new ToolStripMenuItem();
            dwwdwToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tttToolStripMenuItem, dwwdwToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tttToolStripMenuItem
            // 
            tttToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dwdwdToolStripMenuItem });
            tttToolStripMenuItem.Name = "tttToolStripMenuItem";
            tttToolStripMenuItem.Size = new Size(46, 29);
            tttToolStripMenuItem.Text = "ttt";
            // 
            // dwdwdToolStripMenuItem
            // 
            dwdwdToolStripMenuItem.Name = "dwdwdToolStripMenuItem";
            dwdwdToolStripMenuItem.Size = new Size(270, 34);
            dwdwdToolStripMenuItem.Text = "dwdwd";
            // 
            // dwwdwToolStripMenuItem
            // 
            dwwdwToolStripMenuItem.Name = "dwwdwToolStripMenuItem";
            dwwdwToolStripMenuItem.Size = new Size(89, 29);
            dwwdwToolStripMenuItem.Text = "dwwdw";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "w";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tttToolStripMenuItem;
        private ToolStripMenuItem dwdwdToolStripMenuItem;
        private ToolStripMenuItem dwwdwToolStripMenuItem;
    }
}