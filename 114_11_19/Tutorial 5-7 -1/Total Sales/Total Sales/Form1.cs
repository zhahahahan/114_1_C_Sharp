using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            StreamReader inputFile;
            decimal totalSales = 0.0m;
            decimal currentSales = 0.0m;
            try
            {
                inputFile = File.OpenText("Sales.txt");
                salesListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    if(decimal.TryParse(inputFile.ReadLine(), out currentSales))
                    {
                        salesListBox.Items.Add(currentSales.ToString("c"));
                    }
                    else
                    {
                        MessageBox.Show("Invalid data in file.");
                        inputFile.Close();
                        return;
                    }
                    currentSales = decimal.Parse(inputFile.ReadLine());
                    totalSales += currentSales;


                }
                inputFile.Close();
                totalSalesLabel.Text = totalSales.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
