using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            amountDueTextBox.BackColor = Color.Blue;
            basePriceTextBox.BackColor = Color.Blue;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculates  the amount  due on  a New or  Used    Vehicle");
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            var checkedRadioButton = additionalOptionsGroupBox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(rb => rb.Checked);
            var checkedCheckBox = additionalOptionsGroupBox.Controls.OfType<CheckBox>()
                                      .FirstOrDefault(rb => rb.Checked);
            var finalValue = checkedRadioButton.Text + checkedCheckBox.Text + basePriceTextBox.Text;

            subTotalTextBox.Text = finalValue;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
