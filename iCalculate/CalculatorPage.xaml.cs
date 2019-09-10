using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace iCalculate
{
    public partial class CalculatorPage : ContentPage
    {
        public double numberOne = 0;
        public double numberTwo = 0;
        public double result = 0;
        public string operation = "";

        public Color clickedOperationColor = Color.FromHex("#c4e39a");

        public Color originalOperationColor = Color.FromHex("#4a7312");


        public CalculatorPage()
        {
            InitializeComponent();

        }

        private void NumberButtonClicked(Button sender)
        {
            int sentNumber = Convert.ToInt32(sender.Text);

            if (operation == "")
            {
                result = (numberOne * 10) + sentNumber;
                resultBox.Text = result.ToString();

                numberOne = result;
            }
            else
            {
                // operation is set already
                result = (numberTwo * 10) + sentNumber;
                resultBox.Text = result.ToString();

                numberTwo = result;
            }

        }

        private void OperationButtonClicked(Button sender)
        {
            operation = sender.Text;

            sender.BackgroundColor = clickedOperationColor;
        }


    }
}
