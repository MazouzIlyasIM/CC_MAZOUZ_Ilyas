using System;
using System.Windows;
using System.Windows.Controls;

namespace MAZOUZ_Ilyas
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            res1.Text = Math.Round(sld1.Value).ToString();
            res2.Text = Math.Round(sld2.Value).ToString();
            res3.Text = Math.Round(sld3.Value).ToString();

            lstValues.Items.Clear();
            lstValues.Items.Add("Value 1: " + res1.Text);
            lstValues.Items.Add("Value 2: " + res2.Text);
            lstValues.Items.Add("Value 3: " + res3.Text);
        }
    }
}
