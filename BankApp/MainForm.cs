using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class MainForm : Form
    {
        AccountForm accForm;
        StatForm statForm;
        CardForm cardForm;

        public MainForm()
        {
            InitializeComponent();
             accForm = new AccountForm();
             statForm = new StatForm();
             cardForm = new CardForm();

            this.IsMdiContainer = true;
            MainPanel.Controls.Add(accForm);
            MainPanel.Controls.Add(cardForm);
            MainPanel.Controls.Add(statForm);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                return;
            }

            MainPanel.Controls.Remove(accForm);
            MainPanel.Controls.Remove(cardForm);
            MainPanel.Controls.Remove(statForm);

            if (this.listView1.SelectedItems[0].Text == "Accounts") {
                MainPanel.Controls.Add(accForm);
            }

            if (this.listView1.SelectedItems[0].Text == "Cards")
            {
                MainPanel.Controls.Add(cardForm);
            }

            if (this.listView1.SelectedItems[0].Text == "Stats")
            {
                MainPanel.Controls.Add(statForm);
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
