
/*
 * Created by: Alex Ude
 * Created on: 12-11-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Percentage Program
 * This program take a grade as a level and converts it to percentage using the switch statements
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

namespace SwitchStatementsAlex
{
    public partial class frmSwitchStatements : Form
    {
        public frmSwitchStatements()
        {
            InitializeComponent();
        }
        //Function: ConverttoPercentage
        //Input: String level
        //Output: int
        //Description: This function accepts a level in a type string and converts it to percentage

        private int ConverttoPercentage(String level)
        {
            int percentage;
            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 87;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;
                default:
                    percentage = -1;
                    break;

                    
            }
            return percentage;
        }
        

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String userLevel, userPercentage;
            
            userLevel = this.txtLevel.Text;

            userPercentage = Convert.ToString(ConverttoPercentage(userLevel));
            MessageBox.Show("Your percentage is " + userPercentage , "Percentage Program");

            
        }
    }
}
