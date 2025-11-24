namespace baithuchanhtrenlopwdf
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label4 = new Label();
            username = new TextBox();
            password = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13F);
            label1.Location = new Point(70, 74);
            label1.Name = "label1";
            label1.Size = new Size(160, 29);
            label1.TabIndex = 0;
            label1.Text = "tên đăng nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13F);
            label4.Location = new Point(84, 119);
            label4.Name = "label4";
            label4.Size = new Size(110, 29);
            label4.TabIndex = 3;
            label4.Text = "mật khẩu";
            // 
            // username
            // 
            username.BackColor = Color.Chocolate;
            username.Location = new Point(243, 75);
            username.Name = "username";
            username.Size = new Size(244, 31);
            username.TabIndex = 7;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(255, 255, 128);
            password.Location = new Point(245, 119);
            password.Name = "password";
            password.Size = new Size(242, 31);
            password.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(84, 186);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(99, 29);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "ghi nhớ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Times New Roman", 13F);
            button1.Location = new Point(70, 261);
            button1.Name = "button1";
            button1.Size = new Size(131, 39);
            button1.TabIndex = 4;
            button1.Text = "đăng nhập";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Times New Roman", 13F);
            button2.Location = new Point(207, 261);
            button2.Name = "button2";
            button2.Size = new Size(131, 39);
            button2.TabIndex = 9;
            button2.Text = "xóa";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Times New Roman", 13F);
            button3.Location = new Point(344, 261);
            button3.Name = "button3";
            button3.Size = new Size(131, 39);
            button3.TabIndex = 10;
            button3.Text = "dừng";
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 382);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label4);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form Đăng nhập";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox username;
        private TextBox password;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
