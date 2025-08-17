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
    public partial class EditTovar : Form
    {
        DataBase database = new DataBase();
        public EditTovar()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (textBox_Name2.Text != "" && textBox_Tip2.Text != "" && textBox_KuC2.Text != "" && textBox_Sum2.Text != "" && textBox_mar2.Text != "" && textBox_Roz2.Text != "" && comboBox_Pos2.Text != "")
            {
                database.openConnection();

                var Name = textBox_Name2.Text;
                var Tip = textBox_Tip2.Text;
                int KuC;
                int Sum;
                int Mar;
                int Roz;
                var Pos = comboBox_Pos2.Text;

                if (int.TryParse(textBox_KuC2.Text, out KuC) && int.TryParse(textBox_Sum2.Text, out Sum) && int.TryParse(textBox_mar2.Text, out Mar) && int.TryParse(textBox_Roz2.Text, out Roz))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();

                    string querystring = $"select * from Product Where Product.[Name of product] = '{Name}'";

                    SqlCommand command1 = new SqlCommand(querystring, database.GetConnection());


                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    SqlDataAdapter com = new SqlDataAdapter();
                    DataTable table2 = new DataTable();

                    string quercomBo = $"Select id_postavshchik from Provider where Name = '{Pos.Trim()}'";
                    SqlCommand comBo = new SqlCommand(quercomBo, database.GetConnection());
      
                    com.SelectCommand = comBo;
                    com.Fill(table2);

                    
                    if (table.Rows.Count == 0)
                    {
                        var addQuery = $"insert into Product([Name of product],[Tip tovara],[Kolichestvo na sklade],[Prikhodnaya summa],[Protsent natsenki],[Roznichnaya summa],[id_postavshchik]) values ('{Name}', '{Tip}','{KuC}','{Sum}','{Mar}','{Roz}','{table2.Rows[0][0]}')";

                        var command2 = new SqlCommand(addQuery, database.GetConnection());
                        command2.ExecuteNonQuery();


                        MessageBox.Show("Успешно сохранино", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("У вас уже есть поставщик с таким название организации или с номером телефона", "Дублирование записей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearFields();
                    }
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                database.closedConnection();
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ClearFields()
        {

            textBox_Name2.Text = "";
            textBox_Tip2.Text = "";
            textBox_KuC2.Text = "";
            textBox_Sum2.Text = "";
            textBox_mar2.Text = "";
            textBox_Roz2.Text = "";
            comboBox_Pos2.Text = "";
        }

        private void EditTovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klevyy_ZanaDataSet2.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.klevyy_ZanaDataSet2.Provider);
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
