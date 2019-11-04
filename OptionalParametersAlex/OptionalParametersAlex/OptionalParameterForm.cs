using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionalParametersAlex
{
    public partial class frmOptionalParameter : Form
    {
        public frmOptionalParameter()
        {
            InitializeComponent();
        }
        //Procedure: PrintName
        //Input: String apptNumber, String streetAddress, String city, String postalCode, String Province
        //Output: void
        //Description: the procedure displays a messagebox with the five given parameters:apptNumber, streetAddress, city, postalCode,  Province
        public void PrintName(string apptNumber, string streetAddress, string city, string postalCode, string province)
        {

        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {

        }
    }
}
