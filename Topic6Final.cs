﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic6
{
    public partial class Topic6Final : Form
    {
        String enteredTxt = "";
        Boolean inputPermit, withdrawing, reciept;
        Accounts a1, a2, a3, a4, current = null;
        public Topic6Final()
        {
            InitializeComponent();
            a1 = new Accounts("1234", 500000);
            a2 = new Accounts("5678", 100000);
            a3 = new Accounts("9999", 150000);
            a4 = new Accounts("6969", 200000);
            inputPermit = true;
        }

        public void updateDisplay()
        {
            txtOutput.Text = enteredTxt;
        }

        public Accounts FindAccount(String enteredText)
        {
            if (a1.checkPin(enteredText))
                return a1;
            if (a2.checkPin(enteredText)) 
                return a2;
            if (a3.checkPin(enteredText))
                return a3;
            if (a4.checkPin(enteredText))
                return a4;
            return null;
        }

        private void buttonBAL_Click(object sender, EventArgs e)
        {
            label2.Text = "The balance is = "+current.getBalance();
        }

        private void buttonWIT_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "Enter amount here";
            enteredTxt = "";
            withdrawing = true;
            reciept = false;
            //MessageBox.Show("Press CONFIRM to go ahead with the transaction\nPress DENY to cancel the transaction.");
        }

        private void buttonWITR_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "Enter amount here";
            enteredTxt = "";
            withdrawing = true;
            reciept = true;
            //MessageBox.Show("Press CONFIRM to go ahead with the transaction\nPress DENY to cancel the transaction.");
        }

        private void buttonCON_Click(object sender, EventArgs e)
        {
            if (current == null)
            {
                current = FindAccount(enteredTxt);
            }
            if (current != null)
            {
                if (withdrawing)
                {
                    if (reciept)
                    {
                        current.withdraw(int.Parse(enteredTxt));
                        enteredTxt = "The transaction was successfull.";
                        updateDisplay();
                        label2.Text = "The balance is = " + current.getBalance();
                        MessageBox.Show(current.getLastTransaction());
                    }
                    else
                    {
                        current.withdraw(int.Parse(enteredTxt));
                        enteredTxt = "The transaction was successfull.";
                        updateDisplay();
                        label2.Text = "The balance is = " + current.getBalance();
                    }
                }
                else
                {
                    enteredTxt = "Logged in - Choose a transaction.";
                    updateDisplay();
                }
            }
            else
            {
                txtOutput.Text = "Invalid PIN";
                inputPermit = true;
                enteredTxt = "";
            }
        }

        private void buttonDEN_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (inputPermit == false)
                return;
            enteredTxt += "7";
            updateDisplay();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (inputPermit == false)
                return;
            enteredTxt += "8";
            updateDisplay();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (inputPermit == false)
                return;
            enteredTxt += "9";
            updateDisplay();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inputPermit == false)
                return;
            enteredTxt += "4";
            updateDisplay();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inputPermit == false)
                return;
            enteredTxt += "5";
            updateDisplay();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inputPermit == false)
                return;
            enteredTxt += "6";
            updateDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputPermit == false)
                return;
            enteredTxt += "1";
            updateDisplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inputPermit == false)
                return;
            enteredTxt += "2";
            updateDisplay();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inputPermit == false)
                return;
            enteredTxt += "3";
            updateDisplay();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (inputPermit == false)
                return;
            enteredTxt += "0";
            updateDisplay();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            enteredTxt = "";
            updateDisplay();
        }
    }
}