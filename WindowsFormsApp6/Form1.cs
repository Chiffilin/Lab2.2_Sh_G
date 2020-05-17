using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        Rect rect;
        bool isSecondNumber;
        public Form1()
        {
            InitializeComponent();
            rect = new Rect();
            isSecondNumber = false;
        }
       
        public void AddDigit(String digit)
        {
            if (display.Text.Equals("0") || isSecondNumber)
                display.Text = digit;
            else
                display.Text += digit;

            isSecondNumber = false;
        }
        public void ChooseOperation(object sender, EventArgs e)
        {
            
            switch (((Button)sender).Text)
            {
                case "Diag":
                    rect.OperationCode = 1;
                    break;
                case "P":
                    rect.OperationCode = 2;
                    break;
                case "S":
                    rect.OperationCode = 3;
                    break;
                case "Sprism":
                    rect.OperationCode = 4;
                    break;
                case "Vprism":
                    rect.OperationCode = 5;
                    break;
                default:
                    break;
            }

            rect.Number = Convert.ToDouble(display.Text);
            this.isSecondNumber = true;


        }
       

     

        private void button1_Click(object sender, EventArgs e)
        {
            
            rect.Rectg();
            display.Text = rect.Result ;
        
        }

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            AddDigit(((Button)sender).Text);
        }
       
        private void Clear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            Answer.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            rect.Number = Convert.ToDouble(display.Text);
            rect.Rectg();
            Answer.Text = rect.Result;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains(","))
                display.Text += ",";
        }
    }
}
