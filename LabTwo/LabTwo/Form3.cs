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
    public partial class Form3 : Form
    {
        public string Data
        {
            get
            {
                return textBox1.Text;
            }
        }
        public string Type
        {
            get
            {
                return comboBox1.Text;
            }
        }
        public Form3()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        //Update 
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
