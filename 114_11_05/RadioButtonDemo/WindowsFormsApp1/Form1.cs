using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CoffeeradioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            String message = "點餐內容:" ;
            String drink = "";
            String sandwich = "";

            if (CoffeeradioButton.Checked)
            {
                drink = "咖啡 ";
            }
            else if (milktearadioButton.Checked)
            {
                drink = "奶茶  ";
            }
            else if (BlacktearadioButton.Checked)
            {
                drink = "紅茶  ";

            }
            else if (JuiceradioButton.Checked)
            {
                drink = "果汁  ";
            }
            else
            {
                drink = "";
            }

            if (jellySanradioButton.Checked)
            {
                sandwich = "果醬三明治 ";
            }
            else if (hamSanradioButton.Checked)
            {
                sandwich = "火腿三明治 ";
            }
            else if (tunaSanradioButton.Checked)
            {
                sandwich = "鮪魚三明治 ";
            }
            else
            {
                sandwich = "";
            }
            message += drink + sandwich;
            MessageBox.Show(message);
        }
    }
}
