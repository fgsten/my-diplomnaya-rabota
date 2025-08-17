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

namespace диплом
{
    public partial class Author : Form
    {
        DataBase database = new DataBase();
        public Author()
        {
            InitializeComponent();
        }
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
           var login = LoginBox.Text;
           var password = PasswordBox.Text;

           SqlDataAdapter adapter = new SqlDataAdapter();
           DataTable table = new DataTable();

            string querystring = $"select * from Еmployees Where login = '{login}' and password = '{password}'";
            
            SqlCommand command = new SqlCommand(querystring,database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                var user = new checkUser(table.Rows[0].ItemArray[3].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[5]));

                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ME ME = new ME(user); 
                ME.Show(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!","Аккаунта не существует!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Author_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            LoginBox.MaxLength = 25;
            PasswordBox.MaxLength = 25;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = true;
            pictureBox4.Visible = false;    
            pictureBox3.Visible = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = false;      
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PasswordBox.Text = "";
            LoginBox.Text = "";
        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && (l < 'A' || l > 'z') && (l < '0' || l > '9'))
            {
                e.Handled = true;
            }
        }

        private void LoginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && (l < 'A' || l > 'z') && (l < '0' || l > '9'))
            {
                e.Handled = true;
            }
        }

        private void Author_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
