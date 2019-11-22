/*
 * Created by: Alex Ude
 * Created on: 22-november-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #34 -Dynamic Picture boxes 
 //* * This program generates picture boxes and puts pictures it in to make an illusion 
 //* that the cartoon is walking
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
using System.Threading;
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
            this.btnStart.Hide();
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
            tmpPicMan.Image = Properties.Resources.walk1;

            //stretch the image to the size of the picture box
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            //make the picture box width and height to be the same as the image 
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            //add an event listener 
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            //add the picture box to form 
            this.Controls.Add(tmpPicMan);

        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            //cast the sender object into a picture box 
            PictureBox tmpPicMan = (PictureBox)sender;

            //writea message to the console to check which picture box was clicked
            Console.WriteLine("PictureBox(" + tmpPicMan.Location.X + ", " + tmpPicMan.Location.Y + ") was clicked.");

            //declare local variable and constants 
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            //continue this loop while frame counter has not reached the max number of frames we have 
            while(pictureFrameCounter < MAX_FRAMES + 1 )
            {
                if (pictureFrameCounter == 1)
                {
                    tmpPicMan.Image = Properties.Resources.walk1;
                    //addd one to the picture frame counter
                    //addd one to the picture frame counter
                    pictureFrameCounter++;
                }
                else if (pictureFrameCounter == 2)
                {
                    tmpPicMan.Image = Properties.Resources.walk2;
                    //addd one to the picture frame counter
                    pictureFrameCounter++;

                }
                else if (pictureFrameCounter == 3)
                {
                    tmpPicMan.Image = Properties.Resources.walk3;
                    //addd one to the picture frame counter
                    pictureFrameCounter++;
                }
                else if (pictureFrameCounter == 4)
                {
                    tmpPicMan.Image = Properties.Resources.walk4;
                    //addd one to the picture frame counter
                   pictureFrameCounter++;
                }
                else if (pictureFrameCounter == 5)
                {
                    tmpPicMan.Image = Properties.Resources.walk5;
                    //addd one to the picture frame counter
                     pictureFrameCounter++;
                }
                else if (pictureFrameCounter == 6)
                {
                    tmpPicMan.Image = Properties.Resources.walk6;
                    //addd one to the picture frame counter
                     pictureFrameCounter++;
                }
                else if (pictureFrameCounter == 7)
                {
                    tmpPicMan.Image = Properties.Resources.walk7;
                    //addd one to the picture frame counter
                    pictureFrameCounter++;
                }
                else if (pictureFrameCounter == 8)
                {
                    tmpPicMan.Image = Properties.Resources.walk8;
                    //addd one to the picture frame counter
                     pictureFrameCounter++;
                }
                else if (pictureFrameCounter == 9)
                {
                    tmpPicMan.Image = Properties.Resources.walk9;
                    //addd one to the picture frame counter
                     pictureFrameCounter++;
                }
                else if (pictureFrameCounter == 10)
                {
                    tmpPicMan.Image = Properties.Resources.walk10;
                    //addd one to the picture frame counter
                    pictureFrameCounter++;

                }
                //refresh the form
                this.Refresh();

                //pause the loop for 100 milleseconds
                Thread.Sleep(100);
            }

        }
    }
    
}
