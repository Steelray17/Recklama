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
    public partial class FormRecklama : Form
    {
        public FormRecklama()
        {
            InitializeComponent();
            ShowOrg();
            ShowGaz();
            ShowlistGazeta();
        }

        void ShowOrg()
        {
            comboBoxOrg.Items.Clear();
            foreach (Organization orgSet in Program.recklama.Organization)
            {
                string[] item = { orgSet.id.ToString() + ".", orgSet.NameOrganization };
                comboBoxOrg.Items.Add(string.Join(" ", item));
            }
        }

        void ShowGaz()
        {
            comboBoxGaz.Items.Clear();
            foreach (Newspaper gazSet in Program.recklama.Newspaper)
            {
                string[] item = { gazSet.id.ToString() + ".", gazSet.NameNewspaper};
                comboBoxGaz.Items.Add(string.Join(" ", item));
            }
        }

        void ShowlistGazeta()
        {
            listViewGazeta.Items.Clear();
            foreach (Recklama recklamaSet in Program.recklama.Recklama)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        recklamaSet.Organization.NameOrganization,
                        recklamaSet.Newspaper.NameNewspaper,
                        recklamaSet.Number.ToString(),
                        recklamaSet.Volume.ToString(),
                        recklamaSet.Newspaper.Price.ToString()
                    });
                item.Tag = recklamaSet;
                listViewGazeta.Items.Add(item);
            }
            listViewGazeta.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Recklama recklamaSet = new Recklama();

                recklamaSet.idOrganization = Convert.ToInt32(comboBoxOrg.SelectedItem.ToString().Split('.')[0]);
                recklamaSet.idNewspaper = Convert.ToInt32(comboBoxGaz.SelectedItem.ToString().Split('.')[0]);
                recklamaSet.Number = Convert.ToInt32(textBoxNumber.Text);
                recklamaSet.Volume = Convert.ToInt32(textBoxVolume.Text);
                Program.recklama.Recklama.Add(recklamaSet);
                Program.recklama.SaveChanges();
                ShowlistGazeta();
            }
            catch
            {
                MessageBox.Show("Введено не правельное значение", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewGazeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGazeta.SelectedItems.Count == 1)
            {
                Recklama recklamaSet = listViewGazeta.SelectedItems[0].Tag as Recklama;

                comboBoxOrg.SelectedIndex = comboBoxOrg.FindString(recklamaSet.idOrganization.ToString());
                comboBoxGaz.SelectedIndex = comboBoxGaz.FindString(recklamaSet.idNewspaper.ToString());
                textBoxNumber.Text = recklamaSet.Number.ToString();
                textBoxVolume.Text = recklamaSet.Volume.ToString();
            }
            else
            {
                comboBoxOrg.SelectedItem = null;
                comboBoxGaz.SelectedItem = null;
                textBoxNumber.Text = "";
                textBoxVolume.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewGazeta.SelectedItems.Count == 1)
            {
                Recklama recklamaSet = listViewGazeta.SelectedItems[0].Tag as Recklama;

                recklamaSet.idOrganization = Convert.ToInt32(comboBoxOrg.SelectedItem.ToString().Split('.')[0]);
                recklamaSet.idNewspaper = Convert.ToInt32(comboBoxGaz.SelectedItem.ToString().Split('.')[0]);
                recklamaSet.Number = Convert.ToInt32(textBoxNumber.Text);
                recklamaSet.Volume = Convert.ToInt32(textBoxVolume.Text);
                Program.recklama.SaveChanges();
                ShowlistGazeta();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewGazeta.SelectedItems.Count == 1)
                {
                    Recklama recklamaSet = listViewGazeta.SelectedItems[0].Tag as Recklama;
                    Program.recklama.Recklama.Remove(recklamaSet);
                    Program.recklama.SaveChanges();
                    ShowlistGazeta();
                }
                comboBoxOrg.SelectedItem = null;
                comboBoxGaz.SelectedItem = null;
                textBoxNumber.Text = "";
                textBoxVolume.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
