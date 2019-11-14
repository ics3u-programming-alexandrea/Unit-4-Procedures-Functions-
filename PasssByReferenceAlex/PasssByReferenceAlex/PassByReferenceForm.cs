/*
 * Created by: Alex Ude
 * Created on: 13-November-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Pass By Reference
 * This program randomly generates pictures in a picture box when it is clicked
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

namespace PasssByReferenceAlex
{
    public partial class frmPassByReference : Form
    {
        //declare global variables
        Random randNumbergenerator = new Random();
        public frmPassByReference()
        {
            InitializeComponent();
        }
        //Procedure: ChangeCard
        //Input: ref PictureBox aPicturebox , int cardNumber
        //Output:void
        //Description:This procedure takes a Picturebox passed by refrence and a card Number.
        //it assigns the image to a picturbox to the card with a given number
        private void ChangeCard(ref PictureBox aPictureBox, int cardNumber)
        {
            if(cardNumber==1)
            {
                aPictureBox.Image = Properties.Resources.Front;
            }
            else if (cardNumber == 2)
            {
                aPictureBox.Image = Properties.Resources.JC;
            }
            else if (cardNumber == 3)
            {
                aPictureBox.Image = Properties.Resources.JD;
            }
            else if (cardNumber == 4)
            {
                aPictureBox.Image = Properties.Resources.JH;
            }
            else if (cardNumber == 5)
            {
                aPictureBox.Image = Properties.Resources.JS;
            }
            else if (cardNumber == 6)
            {
                aPictureBox.Image = Properties.Resources.KC;
            }
            else if (cardNumber == 7)
            {
                aPictureBox.Image = Properties.Resources.KD;
            }
            else if (cardNumber == 8)
            {
                aPictureBox.Image = Properties.Resources.KH;
            }
            else if (cardNumber == 9)
            {
                aPictureBox.Image = Properties.Resources.KS;
            }
            else if (cardNumber == 10)
            {
                aPictureBox.Image = Properties.Resources.QC;
            }
            else if (cardNumber == 11)
            {
                aPictureBox.Image = Properties.Resources.QD;
            }
            else if (cardNumber == 12)
            {
                aPictureBox.Image = Properties.Resources.QH;
            }
            else if (cardNumber == 13)
            {
                aPictureBox.Image = Properties.Resources.QS;
            }
            else if (cardNumber == 14)
            {
                aPictureBox.Image = Properties.Resources.AC;
            }
            else if (cardNumber == 15)
            {
                aPictureBox.Image = Properties.Resources.AD;
            }
            else if (cardNumber == 16)
            {
                aPictureBox.Image = Properties.Resources.AH;
            }
            else if (cardNumber == 17)
            {
                aPictureBox.Image = Properties.Resources.AS;
            }
            else if (cardNumber == 18)
            {
                aPictureBox.Image = Properties.Resources._10C;
            }
            else if (cardNumber == 19)
            {
                aPictureBox.Image = Properties.Resources._10D;
            }
            else if (cardNumber == 20)
            {
                aPictureBox.Image = Properties.Resources._10H;
            }
            else if (cardNumber == 21)
            {
                aPictureBox.Image = Properties.Resources._10S;
            }
            else if (cardNumber == 22)
            {
                aPictureBox.Image = Properties.Resources._9C;
            }
            else if (cardNumber == 23)
            {
                aPictureBox.Image = Properties.Resources._9D;
            }
            else if (cardNumber == 24)
            {
                aPictureBox.Image = Properties.Resources._9H;
            }
            else if (cardNumber == 25)
            {
                aPictureBox.Image = Properties.Resources._9S;
            }
            else if (cardNumber == 26)
            {
                aPictureBox.Image = Properties.Resources._8C;
            }
            else if (cardNumber == 27)
            {
                aPictureBox.Image = Properties.Resources._8D;
            }
            else if (cardNumber == 28)
            {
                aPictureBox.Image = Properties.Resources._8H;
            }
            else if (cardNumber == 29)
            {
                aPictureBox.Image = Properties.Resources._8S;
            }
            else if (cardNumber == 30)
            {
                aPictureBox.Image = Properties.Resources._7C;
            }
            else if (cardNumber == 31)
            {
                aPictureBox.Image = Properties.Resources._7D;
            }
            else if (cardNumber == 32)
            {
                aPictureBox.Image = Properties.Resources._7H;
            }
            else if (cardNumber == 33)
            {
                aPictureBox.Image = Properties.Resources._7S;
            }
            else if (cardNumber == 34)
            {
                aPictureBox.Image = Properties.Resources._6C;
            }
            else if (cardNumber == 35)
            {
                aPictureBox.Image = Properties.Resources._6D;
            }
            else if (cardNumber == 36)
            {
                aPictureBox.Image = Properties.Resources._6H;
            }
            else if (cardNumber == 37)
            {
                aPictureBox.Image = Properties.Resources._6S;
            }
            else if (cardNumber == 38)
            {
                aPictureBox.Image = Properties.Resources._5C;
            }
            else if (cardNumber == 39)
            {
                aPictureBox.Image = Properties.Resources._5D;
            }
            else if (cardNumber == 40)
            {
                aPictureBox.Image = Properties.Resources._5H;
            }
            else if (cardNumber == 41)
            {
                aPictureBox.Image = Properties.Resources._5S;
            }
            else if (cardNumber == 42)
            {
                aPictureBox.Image = Properties.Resources._4C;
            }
            else if (cardNumber == 43)
            {
                aPictureBox.Image = Properties.Resources._4D;
            }
            else if (cardNumber == 44)
            {
                aPictureBox.Image = Properties.Resources._4H;
            }
            else if (cardNumber == 45)
            {
                aPictureBox.Image = Properties.Resources._4S;
            }
            else if (cardNumber == 46)
            {
                aPictureBox.Image = Properties.Resources._3C;
            }
            else if (cardNumber == 47)
            {
                aPictureBox.Image = Properties.Resources._3D;
            }
            else if (cardNumber == 48)
            {
                aPictureBox.Image = Properties.Resources._3H;
            }
            else if (cardNumber == 49)
            {
                aPictureBox.Image = Properties.Resources._3S;
            }
            else if (cardNumber == 50)
            {
                aPictureBox.Image = Properties.Resources._2C;
            }
            else if (cardNumber == 51)
            {
                aPictureBox.Image = Properties.Resources._2D;
            }
            else if (cardNumber == 52)
            {
                aPictureBox.Image = Properties.Resources._2H;
            }
            else if (cardNumber == 53)
            {
                aPictureBox.Image = Properties.Resources._2S;
            }
        }
        private void PicImage_Click(object sender, EventArgs e)
        {
            //declare local constants
            const int MAX_NUM_CARDS = 52;
            //declare local variables
            int aRandomNumer;
            //Get a random umber between 1 and the maximum
            aRandomNumer = randNumbergenerator.Next(1, MAX_NUM_CARDS + 1);
            //Ckang the card depending on the random selection
            ChangeCard(ref this.picImage, aRandomNumer);
        }
    }
}
