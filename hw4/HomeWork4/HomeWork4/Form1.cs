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
using System.Data.Common;

namespace HomeWork4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(GetConnectionString());
            if(textBox1.Text==builder.UserID && textBox2.Text==builder.Password)
                MessageBox.Show("Correct");
            else
                MessageBox.Show("Nope");
        }
        private static string GetConnectionString()
        {
            return @"Data Source = (LocalDb)\MSSQLLocalDB;user id=vadim;password= password; Initial Catalog = Sales; Integrated Security = SSPI";
        }
    }
}
