using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Server=DESKTOP-13DNN0N\SQLEXPRESS;Database=sale;Integrated Security=True");
        SqlCommand cmd;
        String sql;
        SqlDataReader dr;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            String lname = textBox2.Text;
            String address = textBox3.Text;
            String gender = textBox4.Text;
            String email = textBox5.Text;
            String phone = textBox6.Text;
            String username = textBox7.Text;
            String password = textBox8.Text;

            sql = "insert into registration (fname,lname,address,gender,email,phone,username,password) values(@fname,@lname,@address,@gender,@email,@phone,@username,@password)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@fname",fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@gender",gender);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
            MessageBox.Show("You are register");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            con.Close();
        }
    }
}
