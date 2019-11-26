/*
 * Created by: Alex Ude
 * Created on: 25-11-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program uses function to check if two stings are equal ignoring cases
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringEqualityAlex
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();
        }
        //Function: StringsAreEqual
        //Input: string string1, string string2
        //Output: bool
        //Description: this function checks if to see if two given strings are equal without considering the cases
        private bool StringsAreEqual(string string1, string string2)
        {
            // set boolen variable to false 
            bool isEqual = false;
            // declear local variables
            int stringLength1, stringLength2;
            //get the lengths of the strings 
            stringLength1 = string1.Length;
            stringLength2 = string2.Length;
            //check if the strings are equal in length
            if (stringLength1 == stringLength2)
            {
                //declear local variables
                string stringCase1, stringCase2;
                //convert strings to uppercase
                stringCase1 = string1.ToUpper();
                stringCase2 = string2.ToUpper();
                //check if the strings are equal
                if (stringCase1== stringCase2)
                {
                    //set the boolean variable to true
                    isEqual = true;
                }
            }
            //return boolean variable equal to true 
            return isEqual;
        }
  
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //declare local variables 
            string uString1, uString2;
            bool equal;
            //get the strings from textboxes 
            uString1 = this.txtString1.Text;
            uString2 = this.txtString2.Text;
            //call the function to check if the strings are equal
            equal = StringsAreEqual(uString1, uString2);
            //check if the boolean variable is true 
            if(equal== true)
            {
                //display that the strings are equal
                this.lblAnswer.Text = "The strings are equal ";
            }
            else
            {
                //display that the strings are not equal
                this.lblAnswer.Text = "The strings are NOT equal ";
            }
        }
    }
}
