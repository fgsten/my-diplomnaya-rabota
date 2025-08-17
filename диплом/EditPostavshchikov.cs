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

namespace диплом
{
    public partial class EditPostavshchikov : Form
    {
        DataBase database = new DataBase();
        public EditPostavshchikov()
        {
            InitializeComponent();
        }


        private void SpisokPostavshchikov_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (textBox_Name2.Text != "" && textBox_City2.Text != "" && textBox_Number2.Text != "")
            {
                database.openConnection();

                var Name = textBox_Name2.Text;
                var City = textBox_City2.Text;
                var Number = textBox_Number2.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string querystring = $"select * from Provider Where Name = '{Name}' and number = '{Number}'";

                SqlCommand command1 = new SqlCommand(querystring, database.GetConnection());


                adapter.SelectCommand = command1;
                adapter.Fill(table);

                if (table.Rows.Count == 0)
                {
                    var addQuery = $"insert into Provider (Name, Сity, number) values ('{Name}', '{City}','{Number}')";

                    var command2 = new SqlCommand(addQuery, database.GetConnection());
                    command2.ExecuteNonQuery();

                    MessageBox.Show("Успешно сохранино", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox_City2.Text = "";
                    textBox_Name2.Text = "";
                    textBox_Number2.Text = "";
                }
                else
                {
                    MessageBox.Show("У вас уже есть поставщик с таким название организации или с номером телефона", "Дублирование записей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_City2.Text = "";
                    textBox_Name2.Text = "";
                    textBox_Number2.Text = "";
                }
                database.closedConnection();
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox_City2.Text = "";
            textBox_Name2.Text = "";
            textBox_Number2.Text = "";           
        }
    }
}
