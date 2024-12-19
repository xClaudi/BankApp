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
    public partial class AccountForm : Form
    {
        Database db;
        public AccountForm()
        {
            this.TopLevel = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Show();
            InitializeComponent();

            db = new Database();
            Account PLNacc = db.getAccountDetails();
            tView.View = View.Details;

            this.moneylabel.Text = PLNacc.Currency.ToString()+ " Account lol";
            this.moneylabel.Text = PLNacc.Amount.ToString();

            foreach (Transaction tr in PLNacc.Transactions)
            {
                string sign = tr.Amount > 0 ? "+" : "";
                ListViewItem item1 = new ListViewItem(sign+tr.Amount.ToString());
                item1.SubItems.Add(tr.Merchant);
                tView.Items.Add(item1);
            }


            

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            this.TopLevel = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
