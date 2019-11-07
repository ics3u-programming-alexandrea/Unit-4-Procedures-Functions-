/*
 * Created by: Alex Ude
 * Created on: 07-November-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Calculate the Hypotenuse
 * This program calculates the hypotenuse of a triangle by the the inputed values of the opposite and adjacent
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

namespace CalculatetheHypotenuse
{
    public partial class FrmCalculatetheHypotenuse : Form
    {
        public FrmCalculatetheHypotenuse()
        {
            InitializeComponent();
            //Hide the answer
            this.lblAnswer.Hide();
        }

        private void FrmCalculatetheHypotenuse_Load(object sender, EventArgs e)
        {

        }
        //Function: CalculateHypoteuse
        //Input:double opposit, double adjacent
        //Output: double
        //Description:the function returns the opposit and adjacent of a right angled triangle and calculates the Hypotenuse

        private double CalculateHypotenuse(double opposite, double adjacent)
        {
            double hypotenuse;
            //calculate the hypotenuse
            hypotenuse = Math.Sqrt(Math.Pow(opposite, 2) + Math.Pow(adjacent, 2));
            return hypotenuse;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            String userOpposite, userAdjacent;
            double userHypotenuse;
            userOpposite = this.txtOpposite.Text;
            userAdjacent = this.txtAdjacent.Text;
            if (userAdjacent== "")
            {
                MessageBox.Show("Please enter the adjacent of the triangle", "Calculate the Hypotenuse");
            }
            else if (userOpposite == "")
            {
                MessageBox.Show("Please enter the opposite of the triangle", "Calculate the Hypotenuse");
            }
            else
            {
                userHypotenuse = CalculateHypotenuse(double.Parse(userOpposite), double.Parse(userAdjacent));
                //display the hypotenuse
                this.lblAnswer.Text = "The hypotenuse is = " + Convert.ToString(userHypotenuse);
                //show the anwser
                this.lblAnswer.Show();
            }

        }
    }
}
  
        
