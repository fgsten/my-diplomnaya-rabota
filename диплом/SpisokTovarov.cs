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

namespace диплом
{
    enum RowState_t
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted

    }
    public partial class SpisokTovarov : Form
    {
        private WordExporter wordExporter;
        private ExcelEX ExcelEX;

        private readonly checkUser _user;
        public SpisokTovarov(checkUser user)
        {
            wordExporter = new WordExporter();
            ExcelEX = new ExcelEX();
            InitializeComponent();
            _user = user;
        }

        DataBase database = new DataBase();

        int selectedRow;

        public SpisokTovarov()
        {
            InitializeComponent();
        }
        private void IsAdmin()
        {
            GroupBoxControlPanel.Enabled = _user.IsAdmin;
        }

        private void SpisokTovarov_Load(object sender, EventArgs e)
        {
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klevyy_Filtration.Product". При необходимости она может быть перемещена или удалена.
            //this.productTableAdapter2.Fill(this.klevyy_Filtration.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klevyy_NamePos.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter1.Fill(this.klevyy_NamePos.Provider);

            tlsUserStatus.Text = $"{_user.Longi}: {_user.Status}";
            F();
            IsAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridView_Tovar);

        }

        private void SpisokTovarov_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
           
            ME ME = new ME(_user);
            ME.Show();
            this.Hide();

        }
        private void CreateColumns()
        {

            dataGridView_Tovar.Columns.Add("id_tovar", "id");//0
            dataGridView_Tovar.Columns.Add("Name of product", "Название товара");//1
            dataGridView_Tovar.Columns.Add("Tip tovara", "Тип товара");//2
            dataGridView_Tovar.Columns.Add("Kolichestvo na sklade", "Количество на складе");//3
            dataGridView_Tovar.Columns.Add("Prikhodnaya summa", "Приходная сумма");//4
            dataGridView_Tovar.Columns.Add("Protsent natsenki", "Процент наценки");//5
            dataGridView_Tovar.Columns.Add("Roznichnaya summa", "Розничная сумма");//6
            dataGridView_Tovar.Columns.Add("id_postavshchik", "Поставщик");//7
            dataGridView_Tovar.Columns.Add("IsNew", String.Empty);//8
            dataGridView_Tovar.Columns[8].Visible = false;
            dataGridView_Tovar.Columns[0].Visible = false;
        }
        private void ReadStingleRow(DataGridView dgw, IDataRecord record)
        {
           dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetInt32(4), record.GetInt32(5), record.GetInt32(6), record.GetString(7), RowState.ModifiedNew);

        }

        private void F()
        {
            try
            {
                this.productTableAdapter2.FillBy_DISTINCT(this.klevyy_Filtration.Product);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"Select Product.id_tovar, Product.[Name of product] ,Product.[Tip tovara],Product.[Kolichestvo na sklade], Product.[Prikhodnaya summa] , Product.[Protsent natsenki] , Product.[Roznichnaya summa]  , Provider.Name  from Provider , Product Where Provider.id_postavshchik = Product.id_postavshchik";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadStingleRow(dgw, reader);

            }
            reader.Close();
        }

        private void UpdatepictureBox_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView_Tovar);
            F();
        }

        private void AddButton_T_Click(object sender, EventArgs e)
        { 
            EditTovar EditTovar = new EditTovar();
            this.Hide();
            EditTovar.ShowDialog();
            this.Show();
        }
        private void Poisk(DataGridView dgw)
        {
            dgw.Rows.Clear();
 
            string PoiskString = $"Select Product.id_tovar, Product.[Name of product] ,Product.[Tip tovara],Product.[Kolichestvo na sklade], Product.[Prikhodnaya summa] , Product.[Protsent natsenki] , Product.[Roznichnaya summa] , Provider.Name  from Provider , Product Where Provider.id_postavshchik = Product.id_postavshchik";
            if (textBox_Poisk.Text.Trim() != "")
                PoiskString += $" and Product.[Name of product] like '%" + textBox_Poisk.Text + "%'";
            if (checkBox_File.Checked)
                PoiskString += $" and Product.[Tip tovara] = '{comboBox_Filtration.Text}'";

            SqlCommand com = new SqlCommand(PoiskString, database.GetConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadStingleRow(dgw, read);
            }
            read.Close();
        }
        private void textBox_Poisk_TextChanged(object sender, EventArgs e)
        {
           Poisk(dataGridView_Tovar);
        }
        private void deleteRom()
        {
            int index = dataGridView_Tovar.CurrentCell.RowIndex;

            dataGridView_Tovar.Rows[index].Visible = false;

            if (dataGridView_Tovar.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView_Tovar.Rows[index].Cells[8].Value = RowState.Deleted;
                return;
            }
            dataGridView_Tovar.Rows[index].Cells[8].Value = RowState.Deleted;
        }

        private void DelButton_T_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите Удалить?";
            String caption = "Удалить";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
            {    
                deleteRom();
                
                ClearFields();   
            }
        }
        private void Update1()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView_Tovar.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView_Tovar.Rows[index].Cells[8].Value;

                if (rowState == RowState.Existed)

                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView_Tovar.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Product where id_tovar = {id}";

                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();

                }

                if (rowState == RowState.Modified)
                {
                    
                    var id = dataGridView_Tovar.Rows[index].Cells[0].Value.ToString();
                    var Name = dataGridView_Tovar.Rows[index].Cells[1].Value.ToString();
                    var Tip = dataGridView_Tovar.Rows[index].Cells[2].Value.ToString();
                    var KuC = dataGridView_Tovar.Rows[index].Cells[3].Value.ToString();
                    var Sum = dataGridView_Tovar.Rows[index].Cells[4].Value.ToString();
                    var Mar = dataGridView_Tovar.Rows[index].Cells[5].Value.ToString();
                    var Roz = dataGridView_Tovar.Rows[index].Cells[6].Value.ToString();
                    var Pos = dataGridView_Tovar.Rows[index].Cells[7].Value.ToString();

                    SqlDataAdapter com = new SqlDataAdapter();
                    DataTable querPos = new DataTable();

                    string quercomBo = $"Select id_postavshchik from Provider where Name = '{Pos.Trim()}'";
                    SqlCommand comBo = new SqlCommand(quercomBo, database.GetConnection());

                    com.SelectCommand = comBo;
                    com.Fill(querPos);

                    var changeQuery = $"update Product set Product.[Name of product] = '{Name}', Product.[Tip tovara] = '{Tip}', Product.[Kolichestvo na sklade] = '{KuC}', Product.[Prikhodnaya summa] = '{Sum}',Product.[Protsent natsenki] = '{Mar}', Product.[Roznichnaya summa] = '{Roz}', Product.id_postavshchik = '{querPos.Rows[0][0]}' where id_tovar = '{id}'";

                    var command = new SqlCommand(changeQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }
               
            }

            database.closedConnection();
            F();
            Poisk(dataGridView_Tovar);
        }

        private void SaveButton_T_Click(object sender, EventArgs e)
        {
            Update1();
            ClearFields();
            
        }
        private void Change()
        {
            var selectedRowIndex = dataGridView_Tovar.CurrentCell.RowIndex;

            var id = textBox_id.Text;
            var Name = textBox_Name.Text;
            var Tip = textBox_Tip.Text;
            int KuC;
            int Sum;
            int Mar;
            int Roz;
            var Pos = comboBox_Pos.Text;

            if (int.TryParse(textBox_KuC.Text, out KuC) && int.TryParse(textBox_Sum.Text, out Sum) && int.TryParse(textBox_mar.Text, out Mar) && int.TryParse(textBox_Roz.Text, out Roz))
            {
                if (dataGridView_Tovar.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    dataGridView_Tovar.Rows[selectedRowIndex].SetValues(id, Name, Tip, KuC, Sum, Mar, Roz, Pos);
                    dataGridView_Tovar.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;

                }
            }
            else
            {
                MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ClearFields()
        {
            textBox_id.Text = "";
            textBox_Name.Text = "";
            textBox_Tip.Text = "";
            textBox_KuC.Text = "";
            textBox_Sum.Text = "";
            textBox_mar.Text = "";
            textBox_Roz.Text = "";
            comboBox_Pos.Text = "";
        }

        private void EditButton_T_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Sort()
        {
            //Sort сортирует данные в dataGridView_Tovar по возрастанию или по убыванию 
            if (comboBox_Sorting.SelectedIndex == 1)
                dataGridView_Tovar.Sort(dataGridView_Tovar.Columns[3], (comboBox_AandD.SelectedIndex == 0) ? ListSortDirection.Ascending : ListSortDirection.Descending);
            else if (comboBox_Sorting.SelectedIndex == 2)
                dataGridView_Tovar.Sort(dataGridView_Tovar.Columns[4], (comboBox_AandD.SelectedIndex == 0) ? ListSortDirection.Ascending : ListSortDirection.Descending);
            else if (comboBox_Sorting.SelectedIndex == 3)
                dataGridView_Tovar.Sort(dataGridView_Tovar.Columns[5], (comboBox_AandD.SelectedIndex == 0) ? ListSortDirection.Ascending : ListSortDirection.Descending);
            else if (comboBox_Sorting.SelectedIndex == 4)
                dataGridView_Tovar.Sort(dataGridView_Tovar.Columns[6], (comboBox_AandD.SelectedIndex == 0) ? ListSortDirection.Ascending : ListSortDirection.Descending);
            else
                dataGridView_Tovar.Sort(dataGridView_Tovar.Columns[0], ListSortDirection.Ascending);

        }

        private void comboBox_Sorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void comboBox_AandD_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void comboBox_Filtration_SelectedIndexChanged(object sender, EventArgs e)
        {
            Poisk(dataGridView_Tovar);
        }

        private void dataGridView_Tovar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Tovar.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Tip.Text = row.Cells[2].Value.ToString();
                textBox_KuC.Text = row.Cells[3].Value.ToString();
                textBox_Sum.Text = row.Cells[4].Value.ToString();
                textBox_Roz.Text = row.Cells[5].Value.ToString();
                textBox_mar.Text = row.Cells[6].Value.ToString();
                comboBox_Pos.Text = row.Cells[7].Value.ToString();

            }
        }

        private void checkBox_File_CheckedChanged(object sender, EventArgs e)
        {
            Poisk(dataGridView_Tovar);
        }

        private void оПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OProgramme oProgramme = new OProgramme(_user);
            this.Hide();
            oProgramme.ShowDialog();
            this.Show();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordExporter.WordExport(dataGridView_Tovar);
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelEX.ExportExcel(dataGridView_Tovar);
        }
    }
    
} 
