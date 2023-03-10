using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabTwo
{
    public partial class Form2 : Form
    {
        public string EmpId
        {
            get
            {
                return textBox1.Text;
            }
        }
        public string EmpName
        {
            get
            {
                return textBox2.Text;
            }
        }

        public Form2()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
           this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
