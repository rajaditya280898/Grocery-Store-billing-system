namespace WindowsFormsApp2
{
    partial class Form6
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_calcu = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_cal = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(52, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(641, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(641, 62);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(52, 237);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(641, 239);
            this.dataGridView2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_2);
            this.groupBox1.Controls.Add(this.button_5);
            this.groupBox1.Controls.Add(this.button_8);
            this.groupBox1.Controls.Add(this.button_1);
            this.groupBox1.Controls.Add(this.button_4);
            this.groupBox1.Controls.Add(this.button_9);
            this.groupBox1.Controls.Add(this.button_7);
            this.groupBox1.Controls.Add(this.button_calcu);
            this.groupBox1.Controls.Add(this.button_0);
            this.groupBox1.Controls.Add(this.button_cal);
            this.groupBox1.Controls.Add(this.button_div);
            this.groupBox1.Controls.Add(this.button_mul);
            this.groupBox1.Controls.Add(this.button_sub);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.button_3);
            this.groupBox1.Controls.Add(this.button_6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(1107, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 404);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "calculator";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 60);
            this.button4.TabIndex = 4;
            this.button4.Text = ".";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "Bck_Space";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(309, 119);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(75, 52);
            this.button_2.TabIndex = 1;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(309, 189);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(75, 52);
            this.button_5.TabIndex = 1;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(309, 258);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(75, 52);
            this.button_8.TabIndex = 1;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(211, 119);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(75, 52);
            this.button_1.TabIndex = 1;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(211, 189);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(75, 52);
            this.button_4.TabIndex = 1;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(405, 258);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(75, 52);
            this.button_9.TabIndex = 1;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(211, 258);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(75, 52);
            this.button_7.TabIndex = 1;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_calcu
            // 
            this.button_calcu.Location = new System.Drawing.Point(162, 331);
            this.button_calcu.Name = "button_calcu";
            this.button_calcu.Size = new System.Drawing.Size(124, 52);
            this.button_calcu.TabIndex = 1;
            this.button_calcu.Text = "=";
            this.button_calcu.UseVisualStyleBackColor = true;
            this.button_calcu.Click += new System.EventHandler(this.button_calcu_Click);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(309, 331);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(75, 52);
            this.button_0.TabIndex = 1;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_cal
            // 
            this.button_cal.Location = new System.Drawing.Point(405, 331);
            this.button_cal.Name = "button_cal";
            this.button_cal.Size = new System.Drawing.Size(75, 52);
            this.button_cal.TabIndex = 1;
            this.button_cal.Text = "Clear";
            this.button_cal.UseVisualStyleBackColor = true;
            this.button_cal.Click += new System.EventHandler(this.button_cal_Click);
            // 
            // button_div
            // 
            this.button_div.Location = new System.Drawing.Point(507, 331);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(75, 52);
            this.button_div.TabIndex = 1;
            this.button_div.Text = "%";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_mul
            // 
            this.button_mul.Location = new System.Drawing.Point(507, 258);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(75, 52);
            this.button_mul.TabIndex = 1;
            this.button_mul.Text = "X";
            this.button_mul.UseVisualStyleBackColor = true;
            this.button_mul.Click += new System.EventHandler(this.button_mul_Click);
            // 
            // button_sub
            // 
            this.button_sub.Location = new System.Drawing.Point(507, 189);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(75, 52);
            this.button_sub.TabIndex = 1;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.button_sub_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(507, 119);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 52);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(405, 119);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(75, 52);
            this.button_3.TabIndex = 1;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(405, 189);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(75, 52);
            this.button_6.TabIndex = 1;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(420, 68);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(861, 345);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 55);
            this.textBox1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(919, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Get values";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(774, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Checkout";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(715, 431);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 45);
            this.button5.TabIndex = 9;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1788, 513);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_calcu;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_cal;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
    }
}