using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            // Declare a String variable
            string output;
            // concatenate the input and build the output string.
            output = this.dayofWeekTextBox.Text + "," + this.dayOfMonthTextBox.Text + "" + this.monthTextBox.Text + "," + this.yearTextBox.Text;
            //display the output string in the Label control.
            dateOutputLabel.Text = output;
        

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear the textBoxes
            dayofWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";
            //Clear the dateOutputLabel control.
            dateOutputLabel.Text = "";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
       
            //close the form.
            this.Close();
        }
    }
}
