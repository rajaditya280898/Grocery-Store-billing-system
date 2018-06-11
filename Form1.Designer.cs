namespace WindowsFormsApp2
{
    partial class Login_Prompt
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.EMPLOYEE_ID = new System.Windows.Forms.Label();
            this.PASSWORD = new System.Windows.Forms.Label();
            this.LOGIN = new System.Windows.Forms.Label();
            this.textbox_empid = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(513, 172);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(101, 42);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "E&XIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(636, 172);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(109, 42);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // EMPLOYEE_ID
            // 
            this.EMPLOYEE_ID.AutoSize = true;
            this.EMPLOYEE_ID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMPLOYEE_ID.Location = new System.Drawing.Point(281, 78);
            this.EMPLOYEE_ID.Name = "EMPLOYEE_ID";
            this.EMPLOYEE_ID.Size = new System.Drawing.Size(128, 20);
            this.EMPLOYEE_ID.TabIndex = 2;
            this.EMPLOYEE_ID.Text = "EMPLOYEE_ID";
            this.EMPLOYEE_ID.Click += new System.EventHandler(this.EMPLOYEE_ID_Click);
            // 
            // PASSWORD
            // 
            this.PASSWORD.AutoSize = true;
            this.PASSWORD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.Location = new System.Drawing.Point(281, 123);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(108, 20);
            this.PASSWORD.TabIndex = 3;
            this.PASSWORD.Text = "PASSWORD";
            this.PASSWORD.Click += new System.EventHandler(this.PASSWORD_Click);
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSize = true;
            this.LOGIN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(224, 15);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(595, 20);
            this.LOGIN.TabIndex = 4;
            this.LOGIN.Text = "Welcome !!! Please enter your Employee_ID and Password to continue...";
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // textbox_empid
            // 
            this.textbox_empid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_empid.Location = new System.Drawing.Point(474, 78);
            this.textbox_empid.Name = "textbox_empid";
            this.textbox_empid.Size = new System.Drawing.Size(271, 22);
            this.textbox_empid.TabIndex = 0;
            this.textbox_empid.TextChanged += new System.EventHandler(this.textbox_empid_TextChanged);
            this.textbox_empid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_empid_KeyPress);
            // 
            // textbox_password
            // 
            this.textbox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_password.Location = new System.Drawing.Point(474, 121);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(271, 22);
            this.textbox_password.TabIndex = 1;
            this.textbox_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textbox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_password_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.icon__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 253);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.textbox_empid);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.EMPLOYEE_ID);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_exit);
            this.Name = "Login_Prompt";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label EMPLOYEE_ID;
        private System.Windows.Forms.Label PASSWORD;
        private System.Windows.Forms.Label LOGIN;
        private System.Windows.Forms.TextBox textbox_empid;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

