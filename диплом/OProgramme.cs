using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace диплом
{
    public partial class OProgramme : Form
    {
        private readonly checkUser _user;
        public OProgramme(checkUser user)
        {
            InitializeComponent();
            _user = user;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OProgramme_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
