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
    public partial class FormOrganization : Form
    {
        public FormOrganization()
        {
            InitializeComponent();
            ShowOrg();
        }

        void ShowOrg()
        {
            listViewOrg.Items.Clear();
            foreach (Organization orgSet in Program.recklama.Organization)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    orgSet.NameOrganization,
                    orgSet.Address,
                    orgSet.Phone
                });
                item.Tag = orgSet;
                listViewOrg.Items.Add(item);
            }
            listViewOrg.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrg.SelectedItems.Count == 1)
            {
                Organization orgSet = listViewOrg.SelectedItems[0].Tag as Organization;
                textBoxOrg.Text = orgSet.NameOrganization;
                textBoxAddress.Text = orgSet.Address;
                textBoxNumber.Text = orgSet.Phone;
            }
            else
            {
                textBoxOrg.Text = "";
                textBoxAddress.Text = "";
                textBoxNumber.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Organization orgSet = new Organization();
            orgSet.NameOrganization = textBoxOrg.Text;
            orgSet.Address = textBoxAddress.Text;
            orgSet.Phone = textBoxNumber.Text;
            Program.recklama.Organization.Add(orgSet);
            Program.recklama.SaveChanges();
            ShowOrg();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrg.SelectedItems.Count == 1)
            {
                Organization orgSet = listViewOrg.SelectedItems[0].Tag as Organization;
                orgSet.NameOrganization = textBoxOrg.Text;
                orgSet.Address = textBoxAddress.Text;
                orgSet.Phone = textBoxNumber.Text;
                Program.recklama.SaveChanges();
                ShowOrg();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrg.SelectedItems.Count == 1)
                {
                    Organization orgSet = listViewOrg.SelectedItems[0].Tag as Organization;
                    Program.recklama.Organization.Remove(orgSet);
                    Program.recklama.SaveChanges();
                    ShowOrg();
                }
                textBoxOrg.Text = "";
                textBoxAddress.Text = "";
                textBoxNumber.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
