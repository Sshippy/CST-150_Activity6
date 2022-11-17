using System;
using System.Windows.Forms;

namespace Asssignment02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblInput_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void lstTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDistance_Click(object sender, EventArgs e)
        {

        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Closes the application
            System.Environment.Exit(0);

            throw new NotImplementedException();
        }

        private void txtDistance_TextChanged(object sender, EventArgs e)
        {

        }
        public static double givenValue;
        public static double valueConverted;
        
        private void btnConvert_Click(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(txtInput.Text, out double n);
            //if condition to check the value entered is numeric starts
            if (isNumeric == true)
            {
                //Comes inside this when the value entered the the text box is onlu numeric
                givenValue = double.Parse(txtInput.Text); // asigning the text box value to vairable
                valueConverted = 0; // initailizing the result variable
                if ((lstFrom.SelectedIndex == 0) & (lstTo.SelectedIndex == 1))
                {
                    //when user wants to convert Inch to feet
                    valueConverted = givenValue / 12;
                    txtDistance.Text = valueConverted.ToString();

                }
                else if ((lstFrom.SelectedIndex == 0) & (lstTo.SelectedIndex == 2))
                {
                    //when user wants to convert Inch to yards
                    valueConverted = givenValue / 36;
                    txtDistance.Text = valueConverted.ToString();
                }
                else if ((lstFrom.SelectedIndex == 1) & (lstTo.SelectedIndex == 0))
                {
                    //when user wants to convert feet to Inch
                    valueConverted = givenValue * 12;
                    txtDistance.Text = valueConverted.ToString();
                }
                else if ((lstFrom.SelectedIndex == 1) & (lstTo.SelectedIndex == 2))
                {
                    //when user wants to convert feet to yards
                    valueConverted = givenValue / 3;
                    txtDistance.Text = valueConverted.ToString();
                }
                else if ((lstFrom.SelectedIndex == 2) & (lstTo.SelectedIndex == 0))
                {
                    //when user wants to convert yards to inch
                    valueConverted = givenValue * 36;
                    txtDistance.Text = valueConverted.ToString();
                }
                else if ((lstFrom.SelectedIndex == 2) & (lstTo.SelectedIndex == 1))
                {
                    //when user wants to convert yards to feet
                    valueConverted = givenValue * 3;
                    txtDistance.Text = valueConverted.ToString();
                }
                else if (lstFrom.SelectedItem == lstTo.SelectedItem)
                {
                    //when both the From and To are same
                    txtDistance.Text = givenValue.ToString();
                    String.Format("{0:00.0}", givenValue);
                }
            }

            else
            {
                // comes inside this when the value entered is not numeric aand sows msg box
                MessageBox.Show("Enter only Numerics");
                txtInput.Text = "";
            }
            //if condition to check the value entered is numeric ends
 }

       
    }

    }
