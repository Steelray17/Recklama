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
    public partial class FormGazeta : Form
    {
        public FormGazeta()
        {
            InitializeComponent();
            ShowGaz();
        }

        void ShowGaz()
        {
            listViewGazeta.Items.Clear();
            foreach (Newspaper gazSet in Program.recklama.Newspaper)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    gazSet.NameNewspaper,
                    gazSet.Phone.ToString(),
                    gazSet.Price.ToString()
                });
                item.Tag = gazSet;
                listViewGazeta.Items.Add(item);
            }
            listViewGazeta.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewGazeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewGazeta.SelectedItems.Count == 1)
            {
                Newspaper gazSet = listViewGazeta.SelectedItems[0].Tag as Newspaper;
                textBoxName.Text = gazSet.NameNewspaper;
                textBoxPhone.Text = gazSet.Phone.ToString();
                textBoxPrice.Text = gazSet.Price.ToString();
            }
            else
            {
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Newspaper gazSet = new Newspaper();
                gazSet.NameNewspaper = textBoxName.Text;
                gazSet.Phone = Convert.ToInt32(textBoxPhone.Text);
                gazSet.Price = Convert.ToInt32(textBoxPrice.Text);
                Program.recklama.Newspaper.Add(gazSet);
                Program.recklama.SaveChanges();
                ShowGaz();
            }
            catch
            {
                MessageBox.Show("Введено не правельное значение", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewGazeta.SelectedItems.Count == 1)
            {
                Newspaper gazSet = listViewGazeta.SelectedItems[0].Tag as Newspaper;
                gazSet.NameNewspaper = textBoxName.Text;
                gazSet.Phone = Convert.ToInt32(textBoxPhone.Text);
                gazSet.Price = Convert.ToInt32(textBoxPrice.Text);
                Program.recklama.SaveChanges();
                ShowGaz();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewGazeta.SelectedItems.Count == 1)
                {
                    Newspaper gazSet = listViewGazeta.SelectedItems[0].Tag as Newspaper;
                    Program.recklama.Newspaper.Remove(gazSet);
                    Program.recklama.SaveChanges();
                    ShowGaz();
                }
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
