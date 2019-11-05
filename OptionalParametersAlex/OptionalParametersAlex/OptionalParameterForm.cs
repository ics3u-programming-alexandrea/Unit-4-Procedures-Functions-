/*
 * Created by: Alex Ude
 * Created on: 05-11-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Address Program
 * This program diplays the user's address in a message box based on the information entered by the user
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

namespace OptionalParametersAlex
{
    public partial class FrmOptionalParameter : Form
    {
        public FrmOptionalParameter()
        {
            InitializeComponent();
        }
        //Procedure: PrintName
        //Input: String apptNumber, String streetAddress, String city, String postalCode, String Province
        //Output: void
        //Description: the procedure displays a messagebox with the five given parameters:apptNumber, streetAddress, city, postalCode,  Province
        public void PrintAddress(String apptNumber, String streetAddress, String city, String postalCode, String province)
        {
            MessageBox.Show("Your address is: " + apptNumber + " " + streetAddress + " " + city + " " + postalCode + " " + province , "Address Program");
        }

        //Procedure: PrintName
        //Input:  String streetAddress, String city, String postalCode, String Province
        //Output: void
        //Description: the procedure displays a messagebox with the four given parameters: streetAddress, city, postalCode,  Province
        public void PrintAddress(String streetAddress, String city, String postalCode, String province)
        {
            MessageBox.Show("Your address is: " + " " + streetAddress + " " + city + " " + postalCode + " " + province, "Address Program");
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            //declare local variables
            String userApptNumber, userStreetAddress, userCity, userPostalCode, userProvince;

            //get information from textboxes
            userApptNumber = this.txtUnit.Text;
            userStreetAddress = this.txtAddress.Text;
            userCity = this.txtCity.Text;
            userPostalCode = this.txtPostalCode.Text;
            userProvince = this.txtProvince.Text;

            //make the user enter his street address
            if(userStreetAddress == "")
            {
                MessageBox.Show("Please enter a valid address", "Address Program");
            }
            //make sure the user enters a city
            else if (userCity == "")
            {
                MessageBox.Show("Please enter a valid city", "Address Program");
            }
            //make sure the user enters a postal code
            else if (userPostalCode == "")
            {
                MessageBox.Show("Please enter a valid postal code", "Address Program");
            }
            //make sure the user enters a province
            else if (userProvince == "")
            {
                MessageBox.Show("Please enter a valid Province", "Address Program");
            }
            //if the user enters all in formation call the procedure that accepts 4 parameters
            else if (userApptNumber == "")
            {
                PrintAddress(userStreetAddress, userCity, userProvince, userPostalCode);
            }
            //if the user enters all in formation call the procedure that accepts 5 parameters
            else
            {
                PrintAddress(userApptNumber, userStreetAddress, userCity, userProvince, userPostalCode);
            }
        }
    }
}
