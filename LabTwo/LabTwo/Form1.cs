using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTwo
{
    public partial class Form1 : Form
    {
        #region InTialzing Main Component

        SqlDataReader reader;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            cmd = new SqlCommand();
            sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=EF-DB;Integrated Security=True";
            cmd.Connection = sqlConnection1;


        }
        #endregion

        #region Department Names 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text=comboBox1.SelectedItem.ToString();
            cmd.CommandText = $"select DeptID from Department where DeptName='{comboBox1.Text}' ";
           //MessageBox.Show(cmd.CommandText);
           reader= cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = ((int)reader["DeptId"]).ToString();
            }
            reader.Close();
            //to fill List box of employees
            cmd.CommandText = $"select ID ,Name from Employee where DeptId ={textBox1.Text}";
            // MessageBox.Show(cmd.CommandText);
            reader= cmd.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(((int)reader["ID"]).ToString());
                listBox2.Items.Add((reader["Name"]).ToString());
            }
            reader.Close();
        }
        #endregion

        #region Department Insertion 
        private void button1_Click(object sender, EventArgs e)
        {
            //string str = "Insert Into Department Values(" + textBox1.Text + ", '" + textBox2.Text + "')";       
            string str = $"Insert Into Department(DeptID, DeptName) Values ({textBox1.Text}, '{textBox2.Text}')";
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            //sqlConnection1.Close();
            textBox1.Text = textBox2.Text = string.Empty;
            MessageBox.Show("Inserted To Department");
        }
        #endregion

        #region Department Update
        private void button2_Click(object sender, EventArgs e)
        {
            string str = $"Update  Department set DeptName='{textBox2.Text}' where DeptID={textBox1.Text}";
            // MessageBox.Show(str);
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            textBox1.Text = textBox2.Text = string.Empty;
            MessageBox.Show("Record Updated Successfully");
        }
        #endregion

        #region Department Deletion
        private void button3_Click(object sender, EventArgs e)
        {
            //string str1 = $"Delete from  Department where DeptName='{textBox2.Text}' and DeptID={textBox1.Text}";
            string str = $"Delete from Department where DeptName = '{textBox2.Text}' AND DeptID ={textBox1.Text} AND NOT EXISTS (SELECT * FROM Employee WHERE DeptID = {textBox1.Text})";
            //MessageBox.Show(str);
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            textBox1.Text= textBox2.Text = string.Empty;
            MessageBox.Show("Record Deleted From Table");

        }
        #endregion

        #region Functions
        private void ExecuteStatement(string str, string State)
            {
                sqlCommand1.CommandText = str;
                int affectedRows = sqlCommand1.ExecuteNonQuery();
                MessageBox.Show(affectedRows.ToString() + " Record " + State);
                textBox1.Text = textBox2.Text = "";
            }
        #endregion

        #region  Connect
        private void button7_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            string str = $"select  DeptName from Department"; //where DeptID={textBox1.Text}";
           // MessageBox.Show(str);
            cmd.CommandText = str;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string strr = reader[0].ToString();
                comboBox1.Items.Add(strr);
            }
            reader.Close();  
        }
        #endregion

        #region Desconnect
        private void button8_Click(object sender, EventArgs e)
        {
            sqlConnection1.Close();
        }
        #endregion

        #region Employee Insertion 
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 addemp = new Form2();
            DialogResult result = addemp.ShowDialog();
            if (result == DialogResult.OK)
            {
                string str = $"Insert Into Employee Values({int.Parse(addemp.EmpId)}, '{addemp.EmpName}', {int.Parse(textBox1.Text)})";
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Inserted Sucssesfully");
        }
        #endregion

        #region Update Employee
        private void button5_Click(object sender, EventArgs e)
        {
            Form3 updateemp = new Form3();
            DialogResult result = updateemp.ShowDialog();
            string str = "";
            if (result == DialogResult.OK)
            {
                if (updateemp.Type == "Name")
                {
                    str = $"Update Employee Set Name = '{updateemp.Data}' Where ID = {int.Parse(listBox1.SelectedItem.ToString())}";
                }
                else
                {
                    str = $"Update Employee Set DeptID = {int.Parse(updateemp.Data)} Where ID = {int.Parse(listBox1.SelectedItem.ToString())}";
                }
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Record Updated Successfully");
        }
        #endregion

        #region Employee Deletion 
        private void button6_Click(object sender, EventArgs e)
        {
            string str = $"Delete from Employee where Name = '{listBox2.SelectedItem.ToString()}'";
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            textBox1.Text = textBox2.Text = string.Empty;
            MessageBox.Show("Record Deleted From Table");

        }
        #endregion
    }
}
