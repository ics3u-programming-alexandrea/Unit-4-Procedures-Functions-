/*
 * Created by: Alex Udechukwu
 * Created on: 30-October-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Area Procedure
 * This program converts temperature from degree celcius to degree farenheit and displays the answer in a message box
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

namespace PassByValueAlex
{
    public partial class frmTemperatureconverter : Form
    {
        public frmTemperatureconverter()
        {
            InitializeComponent();
        }
        //Funtion: convert to farenheit
        //input: Temperature in celcius
        //Output: void
        //Description:This function takes the temperature in celcius and displays it in  Farenheit
        public void ConvertToFarenheit(Double celcuis)
        {
            //variables
          Double farenheit;

            //write the formular for the conversion
            farenheit = celcuis * ((double)(9) / (double)(5)) + 32;

            //display the converted number in a message box plus the unit
            MessageBox.Show(celcuis + " degree Celcius =" + farenheit + (" degree Farenheit"), "Celcius to Farenheit Converter");
        }
        
        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //declare local variabes
            Double userCelcius;

            //convert from a string to an int and assign them to their various variable
            userCelcius = Convert.ToDouble(this.txtTemperature.Text);

            //call the function to calculate the degrees in farenheit
            this.ConvertToFarenheit(userCelcius);
        }
    }
}
