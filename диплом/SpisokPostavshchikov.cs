using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace диплом
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted

    }
    public partial class SpisokPostavshchikov : Form
    {
        private readonly checkUser _user;
        public SpisokPostavshchikov(checkUser user)
        {
            InitializeComponent();
            _user = user;
        }

        private void IsAdmin()
        {
           GroupBoxControlPanel.Enabled = _user.IsAdmin;
        }

        DataBase database = new DataBase();

        int selectedRow;

        public SpisokPostavshchikov()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            
            dataGridView_Postavshc.Columns.Add("id_postavshchik","id");
            dataGridView_Postavshc.Columns.Add("Name", "Наименование организации");
            dataGridView_Postavshc.Columns.Add("Сity", "Город");
            dataGridView_Postavshc.Columns.Add("number", "Номер телефона");
            dataGridView_Postavshc.Columns.Add("IsNew",String.Empty) ;
            dataGridView_Postavshc.Columns[4].Visible = false;
            dataGridView_Postavshc.Columns[0].Visible = false;
        }
        private void ReadStingleRow(DataGridView dgw,IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), RowState.ModifiedNew);

        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"Select * from Provider";

            SqlCommand command = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader(); 

            while (reader.Read()) 
            {
                ReadStingleRow(dgw,reader);

            
            }
            reader.Close();
        }

        private void EditorProvider_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klevyy_Provider.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.klevyy_Provider.Provider);

            tlsUserStatus.Text = $"{_user.Longi}: {_user.Status}";
            IsAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridView_Postavshc);
            
        }
  
        private void Backbutton_Click(object sender, EventArgs e)
        {
       
            ME ME = new ME(_user);
            ME.Show();
            this.Hide();
        }

        private void EditorProvider_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_Postavshc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView_Postavshc.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_City.Text = row.Cells[2].Value.ToString();
                textBox_Number.Text = row.Cells[3].Value.ToString();
            }
        }

        private void UpdatepictureBox_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView_Postavshc);
            ClearFields();
        }

        private void AddButton_P_Click(object sender, EventArgs e)
        {
            EditPostavshchikov EditPostavshchikov = new EditPostavshchikov();
            this.Hide();
            EditPostavshchikov.ShowDialog();
            this.Show();
        }

        private void Poisk(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string PoiskString = $"Select * from Provider where  (Name) like '%" + textBox_poisk.Text +"%'";

            SqlCommand com = new SqlCommand(PoiskString,database.GetConnection());

            database.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
               ReadStingleRow(dgw,reader);
            }
             reader.Close();
        }

        private void textBox_poisk_TextChanged(object sender, EventArgs e)
        {
            Poisk(dataGridView_Postavshc);
        }

        private void deleteRom()
        {
            int index = dataGridView_Postavshc.CurrentCell.RowIndex;

            dataGridView_Postavshc.Rows[index].Visible = false;

            if (dataGridView_Postavshc.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView_Postavshc.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
            dataGridView_Postavshc.Rows[index].Cells[4].Value = RowState.Deleted;
        }

        private void Update1()
        {
            database.openConnection();

            for(int index = 0; index < dataGridView_Postavshc.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView_Postavshc.Rows[index].Cells[4].Value;

                if(rowState == RowState.Existed) 
                
                    continue;
                
                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView_Postavshc.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Provider where id_postavshchik = {id}";

                    var command = new SqlCommand(deleteQuery,database.GetConnection());
                    command.ExecuteNonQuery();

                }

                if(rowState == RowState.Modified)
                {
                    var id = dataGridView_Postavshc.Rows[index].Cells[0].Value.ToString();
                    var Name = dataGridView_Postavshc.Rows[index].Cells[1].Value.ToString();
                    var City = dataGridView_Postavshc.Rows[index].Cells[2].Value.ToString();
                    var Number = dataGridView_Postavshc.Rows[index].Cells[3].Value.ToString();

                    var changeQuery = $"update Provider set Name = '{Name}', Сity = '{City}', number = '{Number}' where id_postavshchik = '{id}'";

                    var command = new SqlCommand(changeQuery,database.GetConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.closedConnection();
        }

        private void DelButton_P_Click(object sender, EventArgs e)
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

        private void SaveButton_P_Click(object sender, EventArgs e)
        {
            Update1();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView_Postavshc.CurrentCell.RowIndex;

            var id = textBox_id.Text;
            var Name = textBox_Name.Text;
            var City = textBox_City.Text;
            var Number = textBox_Number.Text;

            if (dataGridView_Postavshc.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView_Postavshc.Rows[selectedRowIndex].SetValues(id, Name, City, Number);
                dataGridView_Postavshc.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;

            }

        }
        private void EditButton_P_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();

        }

        private void ClearFields()
        {
            textBox_City.Text = "";
            textBox_Name.Text = "";
            textBox_Number.Text = "";
            textBox_id.Text = "";
        }

        private void ClearpictureBox_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void оПрграммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OProgramme oProgramme = new OProgramme(_user);
            this.Hide();
            oProgramme.ShowDialog();
            this.Show();
        }
    }
}
