using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 	App name = Sharp auto form
    Author's name = Dilpreet Singh
    Student	ID = 200306382
    App	Creation Date = 13/10/2016
    App description = This program calculates the amount due on a New or Used Vehicle
 */
namespace AutoCenter
{
    public partial class SharpAutoForm : Form
    {
        public SharpAutoForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

         /*
          * this method change the font of textbox
         */
          
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            amountDueTextBox.Font = new Font("Arial", amountDueTextBox.Font.Size);
            basePriceTextBox.Font = new Font("Arial", basePriceTextBox.Font.Size);
        }

         /*
         * message box to display text about the project 
         */

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculates  the amount  due on  a New or  Used    Vehicle");
        }

        /*
         *  check if checkbox and radiobuttons are selected and calculate the value based on it
         */ 

        private void additionalOptionsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (stereoSystemCheckBox.Checked)
            {
                additionalOptionsTextBox.Text = stereoSystemCheckBox.Text;
            }

            if (leatherInteriorCheckBox.Checked)
            {
                additionalOptionsTextBox.Text = leatherInteriorCheckBox.Text;
            }

            if (computerNavigationCheckBox.Checked)
            {
                additionalOptionsTextBox.Text = computerNavigationCheckBox.Text;
            }

            if (standardRadioButton.Checked)
            {
                additionalOptionsTextBox.Text = standardRadioButton.Text;
            }

            if (customizedDeatilingRadioButton.Checked)
            {
                additionalOptionsTextBox.Text = customizedDeatilingRadioButton.Text;
            }

            if (pearlizedRadioButton.Checked)
            {
                additionalOptionsTextBox.Text = pearlizedRadioButton.Text;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        /*
         *  calculate button to calculate the subtotal
         */ 

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var checkedRadioButton = additionalOptionsGroupBox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(rb => rb.Checked);
            var checkedCheckBox = additionalOptionsGroupBox.Controls.OfType<CheckBox>()
                                      .FirstOrDefault(rb => rb.Checked);
            var finalValue = checkedRadioButton.Text + checkedCheckBox.Text + basePriceTextBox.Text;

            subTotalTextBox.Text = finalValue;
        }

        /*
         * clear all the form text properties
         */
          
        private void clearButton_Click(object sender, EventArgs e)
        {
            basePriceTextBox.Text = String.Empty;
            additionalOptionsTextBox.Text = String.Empty;
            subTotalTextBox.Text = String.Empty;
            salesTaxTextBox.Text = String.Empty;
            totalTextBox.Text = String.Empty;
            amountDueTextBox.Text = String.Empty;

            computerNavigationCheckBox.Checked = false;
            leatherInteriorCheckBox.Checked = false;
            stereoSystemCheckBox.Checked = false;

            standardRadioButton.Checked = true;
            customizedDeatilingRadioButton.Checked = false;
            pearlizedRadioButton.Checked = false;
        }

        /*
         *  terminate the app
         */ 

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        /*
         *  change the color of text
         */ 

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            amountDueTextBox.BackColor = Color.Blue;
            basePriceTextBox.BackColor = Color.Blue;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /*
         *  call  the calculate event
        */
         
        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculateButton_Click(sender,e);
        }

        /*
         * call the clear event
         */ 
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearButton_Click(sender, e);
        }

        /*
         *  call the exit event
         */ 
          
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }
    }
}
