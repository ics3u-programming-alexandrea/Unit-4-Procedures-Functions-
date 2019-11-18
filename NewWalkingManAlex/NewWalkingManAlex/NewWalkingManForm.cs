using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWalkingManAlex
{
     
    public partial class frmNewWalkingMan : Form
    {
     
        public frmNewWalkingMan()
        {
            InitializeComponent();
            this.lblInstructions.Hide();
        }
        private void GeneratePictureBoxes()
        {

            //generate picture boxes on the form 
            GeneratePictureBox(61, 78);
            GeneratePictureBox(464, 78);
            GeneratePictureBox(61, 358);
            GeneratePictureBox(464, 358);

        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //reveal the instructions 
            this.lblInstructions.Show();
            //generate the picture boxes with their event listeners
            GeneratePictureBoxes();

        }
        private void GeneratePictureBox(int x, int y)
        {
            //dynamically generate a new point atthe given location x, y
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            //set thr location of the picture box
            tmpPicMan.Location = pntPic; 

            //assign the image to a picturebox 

        }
    }
}
