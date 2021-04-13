using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string selectedOperator;
        int acumulatedValue;
        int result;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void NumberAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int buttonValue = int.Parse(button.Text);
            int currentValue = int.Parse(TxtValue.Text);
            currentValue = currentValue * 10 + buttonValue;
            TxtValue.Text = currentValue.ToString();
        }

        private void OperatorAction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            selectedOperator = button.Text;
            acumulatedValue = int.Parse(TxtValue.Text);
            TxtValue.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtValue.Text = "0";
            acumulatedValue = 0;
            selectedOperator = string.Empty; 

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            int secondAcumulatedValue = int.Parse(TxtValue.Text);
            int result = 0;
          

                switch (selectedOperator)
                {
                    case "+":
                        result = acumulatedValue + secondAcumulatedValue;
                        break;
                    case "-":
                        result = acumulatedValue - secondAcumulatedValue;
                        break;
                    case "*":
                        result = acumulatedValue * secondAcumulatedValue;
                        break;
                    case "/":
                        result = acumulatedValue / secondAcumulatedValue;
                        break;
                }
            TxtValue.Text = result.ToString();
       

    }
    }
}
