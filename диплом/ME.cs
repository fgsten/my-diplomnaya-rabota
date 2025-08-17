using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace диплом
{
    public partial class ME : Form
    {
        DataBase database = new DataBase();

        private readonly checkUser _user;
        public ME(checkUser user)
        {
            InitializeComponent();
            _user = user;
        }

        private void IsAdmin()
        {
            
        }

        private void SpisokTovarov_Click(object sender, EventArgs e)
        {
          
            SpisokTovarov SpisokTovarov = new SpisokTovarov(_user);
            SpisokTovarov.Show();
            this.Hide();

        }

        private void close_Click(object sender, EventArgs e)
        {

            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите выйти?";
            String caption = "Закрыть приложение";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       
        private void SpisokPostavshchikov_Click(object sender, EventArgs e)
        {
         
            SpisokPostavshchikov EditorProvider = new SpisokPostavshchikov(_user);
            EditorProvider.Show();
            this.Hide();
        }

        private void goout_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите выйти из аккаунта?";
            String caption = "Выйти из аккаунта";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
            {
                Author Author = new Author();
                Author.Show();
                this.Hide();
            }
        }

        private void ME_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ME_Load(object sender, EventArgs e)
        {
            tlsUserStatus.Text = $"{_user.Longi}: {_user.Status}";
            IsAdmin();

        }

        private void toolStripMenuItem_avtor_Click(object sender, EventArgs e)
        {
            OProgramme oProgramme = new OProgramme(_user);
            this.Hide();
            oProgramme.ShowDialog();
            this.Show();

        }
    }
}
