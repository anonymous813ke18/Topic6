using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Topic6
{
    public partial class Task1 : Form
    {
        int PIN = 0, accountIndex=0;
        List<int> PINList = new List<int>();
        List<float> balanceList = new List<float>();
        float withdrawAmount = 0;
        Boolean flag = false;
       
        public Task1()
        {
            InitializeComponent();
            PINList.Add(1234);
            balanceList.Add(20000);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 4)
            {
                MessageBox.Show("The PIN entered is invalid (Enter a 4 - digit pin)");
                textBox1.Text = "";
                return;
            }
            PIN = int.Parse(textBox1.Text);
            textBox1.Text = "";
            for (int i = 0; i < PINList.Count; i++)
            {
                if (PIN == PINList[i])
                {
                    accountIndex = i;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PIN == 0)
            {
                MessageBox.Show("Please enter the PIN first.");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter an amount to withdraw.");
                return;
            }
            else if (float.Parse(textBox1.Text) > balanceList[accountIndex])
            {
                MessageBox.Show("The withdraw amount is greater than the balance.");
                return;
            }
            withdrawAmount = float.Parse(textBox1.Text);
            flag = false;
            MessageBox.Show("Clcik CONFIRM to complete the transaction.\nIf you want to cancel it click on DENY");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PIN == 0)
            {
                MessageBox.Show("Please enter the PIN first.");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter an amount to withdraw.");
                return;
            }
            else if (float.Parse(textBox1.Text) > balanceList[accountIndex])
            {
                MessageBox.Show("The withdraw amount is greater than the balance.");
                return;
            }
            withdrawAmount = float.Parse(textBox1.Text);
            flag = true;
            MessageBox.Show("Clcik CONFIRM to complete the transaction.\nIf you want to cancel it click on DENY");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PIN == 0)
            {
                MessageBox.Show("Please enter the PIN first.");
                return;
            }
            if (withdrawAmount == 0)
            {
                MessageBox.Show("Please enter an amount first.");
                return;
            }
            balanceList[accountIndex] = balanceList[accountIndex] - withdrawAmount;
            if (flag == false)
            {
                MessageBox.Show("The transaction was successful");
            }
            else
            {
                MessageBox.Show("Withdrawn amount = "+withdrawAmount+"\nBalance left = " + balanceList[accountIndex] + "\nThe transaction was successful.");
            }
            label2.Text = "The balance in the account is = " + balanceList[accountIndex];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (PIN == 0)
            {
                MessageBox.Show("Please enter the PIN first.");
                return;
            }
            MessageBox.Show("The transaction was cancelled.");
            textBox1.Text = "";
            withdrawAmount = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
            PIN = 0; accountIndex = 0; withdrawAmount = 0; flag = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PIN == 0)
            {
                MessageBox.Show("Please enter the PIN first.");
                return;
            }
            label2.Text = "The balance in this account is = " + balanceList[accountIndex];
        }
    }
}
