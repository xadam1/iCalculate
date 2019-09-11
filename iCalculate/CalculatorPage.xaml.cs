using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace iCalculate
{
    public partial class CalculatorPage : ContentPage
    {
        public double NumberOne;
        public double NumberTwo;
        public double Result;
        public string Operation = "";

        public Color ClickedOperationColor = Color.FromHex("#c4e39a");

        public Color OriginalOperationColor = Color.FromHex("#4a7312");


        public CalculatorPage()
        {
            InitializeComponent();

        }

        private void NumberButtonClicked(object o, EventArgs eventArgs)
        {
            var sender = o as Button;

            if (sender == null)
                return;

            var sentNumber = Convert.ToInt32(sender.Text.ToString());

            if (Operation == "")
            {
                Result = (NumberOne * 10) + sentNumber;
                ResultBox.Text = Result.ToString();

                NumberOne = Result;
            }
            else
            {
                // operation is set already
                Result = (NumberTwo * 10) + sentNumber;
                ResultBox.Text = Result.ToString();

                NumberTwo = Result;
            }

        }

        private void NotImplementedClicked(object sender, EventArgs e)
        {
            var btnSender = sender as Button;
            DisplayAlert("This button ain't ready dumbass.", "Clicked button: " + btnSender.Text, "Fuck off");
        }

        private void OperationButtonClicked(object sender, EventArgs e)
        {
            var btnSender = sender as Button;
            Operation = btnSender.Text;
            btnSender.BackgroundColor = ClickedOperationColor;
        }
    }
}
