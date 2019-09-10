using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace iCalculate
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            var barColor = Color.FromHex("#808080");
            this.BarBackgroundColor = barColor;
        }
    }
}
