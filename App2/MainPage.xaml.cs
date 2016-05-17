using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        private void add_Click_1(object sender, RoutedEventArgs e)
        {
            int x = 0, y = 0;
            x = Convert.ToInt32(num1.Text);
            y = Convert.ToInt32(num2.Text);
            int Ansvar = x + y;
            Ans.Text = "Ans is:" + Ansvar;
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            int x = 0, y = 0;
            x = Convert.ToInt32(num1.Text);
            y = Convert.ToInt32(num2.Text);
            int Ansvar = x - y;
            Ans.Text = "Ans is:" + Ansvar;
        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            int x = 0, y = 0;
            x = Convert.ToInt32(num1.Text);
            y = Convert.ToInt32(num2.Text);
            int Ansvar = x * y;
            Ans.Text = "Ans is:" + Ansvar;
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            int x = 0, y = 0;
            x = Convert.ToInt32(num1.Text);
            y = Convert.ToInt32(num2.Text);
            Double Ansvar = 1.0*x / y;
            Ans.Text = "Ans is:" + Ansvar;
        }
    }
}
