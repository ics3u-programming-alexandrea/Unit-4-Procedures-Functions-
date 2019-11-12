using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchStatementsAlex
{
    public partial class frmSwitchStatements : Form
    {
        public frmSwitchStatements()
        {
            InitializeComponent();
        }
        //Function: ConverttoPercentage
        //Input: String level
        //Output: int
        //Description: This function accepts a level in a type string and converts it to percentage

        private int ConverttoPercentage(String level)
        {
            int percentage;
            switch (level)
            {
                case "4++":
                    percentage = 98;
                    MessageBox.Show("your percentage is 98%", "Convert to percentage");
                    break;
                case "4+":
                    percentage = 95;
                    MessageBox.Show("your percentage is 95%", "Convert to percentage");
                    break;
                case "4":
                    percentage = 93;
                    MessageBox.Show("your percentage is 93%", "Convert to percentage");
                    break;
            }
        }
        

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }
    }
}
