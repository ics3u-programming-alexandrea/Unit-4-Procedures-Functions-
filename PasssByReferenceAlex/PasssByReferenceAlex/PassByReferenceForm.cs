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
       //Description:This procedure takes a Picturebox passed by refrence and a card Number. it assigns the image to a picturbox to the card with a given number
        private void PicImage_Click(object sender, EventArgs e)
        {

        }
    }
}
