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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BaseballDrills
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SwingCountRT : Page
    {
        int swings = 1;
        int hits = 1;
        int strikes = 1;
        int outs = 1;
        public SwingCountRT()
        {
            this.InitializeComponent();
        }
        private void backn_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        private void Hits_Click(object sender, RoutedEventArgs e)
        {
            txtHits.Text = hits++.ToString();
            txtSwings.Text = swings++.ToString();
            mediaHits.Play();
        }

        private void Strikes_Click(object sender, RoutedEventArgs e)
        {
            txtStrike.Text = strikes++.ToString();
            txtSwings.Text = swings++.ToString();
            mediaStrikes.Play();

        }

        private void Outs_Click(object sender, RoutedEventArgs e)
        {
            txtSrikeout.Text = outs++.ToString();
            txtSwings.Text = swings++.ToString();
            mediaOuts.Play();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            swings = 1;
            hits = 1;
            strikes = 1;
            outs = 1;
            txtSrikeout.Text = "0";
            txtSwings.Text = "0";
            txtHits.Text = "0";
            txtStrike.Text = "0";
        }
    }
}
