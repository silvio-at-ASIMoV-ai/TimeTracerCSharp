namespace TimeTracerCSharp
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            UserNameTxt = new TextBox();
            LoginBtn = new Button();
            CancelBtn = new Button();
            PasswordTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 32F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(162, 186, 249);
            label1.Location = new Point(169, 51);
            label1.Name = "label1";
            label1.Size = new Size(249, 49);
            label1.TabIndex = 0;
            label1.Text = "Time Tracer";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 140);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 167);
            label2.Name = "label2";
            label2.Size = new Size(76, 16);
            label2.TabIndex = 2;
            label2.Text = "User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 207);
            label3.Name = "label3";
            label3.Size = new Size(68, 16);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // UserNameTxt
            // 
            UserNameTxt.Location = new Point(104, 165);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(154, 23);
            UserNameTxt.TabIndex = 0;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.Highlight;
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(299, 159);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(86, 33);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(299, 200);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(86, 31);
            CancelBtn.TabIndex = 3;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Location = new Point(104, 205);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.Size = new Size(154, 23);
            PasswordTxt.TabIndex = 1;
            // 
            // Login
            // 
            AcceptButton = LoginBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelBtn;
            ClientSize = new Size(458, 264);
            Controls.Add(PasswordTxt);
            Controls.Add(CancelBtn);
            Controls.Add(LoginBtn);
            Controls.Add(UserNameTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Text = "Time Tracer - Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox UserNameTxt;
        private Button LoginBtn;
        private Button CancelBtn;
        private TextBox PasswordTxt;
    }
}
