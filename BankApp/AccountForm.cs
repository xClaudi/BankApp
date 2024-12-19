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
        public AccountForm()
        {
            this.TopLevel = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Show();
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            this.TopLevel = false;
        }
    }
}
