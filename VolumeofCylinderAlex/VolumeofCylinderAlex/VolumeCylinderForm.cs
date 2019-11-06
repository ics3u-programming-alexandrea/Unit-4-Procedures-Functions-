/*
 * Created by: Alex Ude
 * Created on: 06-November-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Volume of a Cylinder
 * This program calculates the volume of a cylinder by the users value for the radius and height
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

namespace VolumeofCylinderAlex
{
    public partial class frmVolumeCylinder : Form
    {
            
        public frmVolumeCylinder()
        {
            InitializeComponent();
        }

        private void FrmVolumeCylinder_Load(object sender, EventArgs e)
        {
            this.lblAnswer.Hide();
        }


        //Fuction:CalculateVolume
        //Input: int radius, int height
        //Output: int
        //Description: this function returns the radius and height of a cylinder and calculates the volume
        private double CalculateVolume(double radius, double height)
        {
            double volume;
            //calculate the volume
            volume = (double)Math.PI * radius * radius * height;
            return volume;


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            String userRadius, userHeight;

            double userVolume;

            userRadius = this.txtRadius.Text;
            userHeight = this.txtHeight.Text;

            if (userRadius=="")
            {
                MessageBox.Show("Please enter the radius", "Volume of Cylinder");
            }
            else if (userHeight == "")
            {
                MessageBox.Show("Please enter the Height" , "Volume of Cylinder");
            }
            else
            {
                userVolume = CalculateVolume(double.Parse(userHeight), double.Parse(userRadius));

                //display the volume
                lblAnswer.Text = "Volume = " + Convert.ToString(userVolume) + "cubic litres";
                this.lblAnswer.Show();
            }

            

           

        }
    }
}
