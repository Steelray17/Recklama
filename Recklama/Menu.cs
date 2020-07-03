using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recklama
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonOpenOrg_Click(object sender, EventArgs e)
        {
            Form formorganization = new FormOrganization();
            formorganization.Show();
        }

        private void buttonOpenGazeta_Click(object sender, EventArgs e)
        {
            Form formgazeta = new FormGazeta();
            formgazeta.Show();
        }

        private void buttonOpenRek_Click(object sender, EventArgs e)
        {
            Form formrecklama = new FormRecklama();
            formrecklama.Show();
        }
    }
}
