namespace trab_poo
{
    partial class Form_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(195, 157);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "User:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(309, 289);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(82, 26);
            button1.TabIndex = 1;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(195, 178);
            textBox1.Margin = new Padding(1);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your username";
            textBox1.Size = new Size(154, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 244);
            textBox2.Margin = new Padding(1);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Enter your password";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 218);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(414, 289);
            button2.Name = "button2";
            button2.Size = new Size(78, 26);
            button2.TabIndex = 7;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ModelsPOO.Properties.Resources.image_removebg_preview1;
            pictureBox1.Location = new Point(12, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(570, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(572, 343);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(1);
            Name = "Form_login";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
        private PictureBox pictureBox1;
    }
}
