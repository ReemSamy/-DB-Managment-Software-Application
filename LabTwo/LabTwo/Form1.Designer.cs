namespace LabTwo
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LabTwo.Properties.Resources.dpyC0ETZ5dO5GBjC;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(67, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 204);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(82, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumBlue;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumBlue;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(106, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(147, 127);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(147, 84);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 31);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 27);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(492, 134);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(492, 83);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(492, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::LabTwo.Properties.Resources.dpyC0ETZ5dO5GBjC;
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(67, 281);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 221);
            this.panel2.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Location = new System.Drawing.Point(275, 43);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 137);
            this.listBox2.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(81, 43);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 137);
            this.listBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(37, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkBlue;
            this.button4.ForeColor = System.Drawing.Color.GhostWhite;
            this.button4.Location = new System.Drawing.Point(492, 43);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkBlue;
            this.button5.Location = new System.Drawing.Point(492, 96);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkBlue;
            this.button6.Location = new System.Drawing.Point(492, 145);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 27);
            this.button6.TabIndex = 5;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=EF-DB;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LimeGreen;
            this.button7.Location = new System.Drawing.Point(690, 87);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 27);
            this.button7.TabIndex = 7;
            this.button7.Text = "Connect";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(690, 52);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 27);
            this.button8.TabIndex = 8;
            this.button8.Text = "Disconnect";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LabTwo.Properties.Resources.dpyC0ETZ5dO5GBjC;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

