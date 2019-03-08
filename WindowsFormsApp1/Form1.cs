using bank_example;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        CheckingAccount checkingAccount = new CheckingAccount(0, 0.1m, 1000);
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            checkingAccount.Deposit(Convert.ToDecimal(txtBoxBalance.Text));
            txtBoxDisplay.Text = checkingAccount.Balance.ToString();
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            checkingAccount.WithDraw(Convert.ToDecimal(txtBoxBalance.Text));
            txtBoxDisplay.Text = checkingAccount.Balance.ToString();
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            checkingAccount.AddMonthlyInterest();
            txtBoxDisplay.Text = checkingAccount.Balance.ToString();
        }
    }
}
