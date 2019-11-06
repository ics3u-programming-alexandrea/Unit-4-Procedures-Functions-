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
            //display the volume
            lblAnswer.Text = "Volume = " + Convert.ToString (CalculateVolume(double.Parse(txtHeight.Text), double.Parse(txtRadius.Text))) + "cubic litres";
            this.lblAnswer.Show();
        }
    }
}
