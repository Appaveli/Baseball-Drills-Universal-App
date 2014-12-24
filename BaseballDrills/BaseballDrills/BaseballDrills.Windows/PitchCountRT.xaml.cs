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
    public sealed partial class PitchCountRT : Page
    {
        int pitches = 1;
        int balls = 1;
        int strikes = 1;
        public PitchCountRT()
        {
            this.InitializeComponent();
        }
        private void backn_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        private void Strikes_Click(object sender, RoutedEventArgs e)
        {

            txtStrike.Text = strikes++.ToString();
            txtPitches.Text = pitches++.ToString();
            mediaStrikes.Play();
        }

        private void Balls_Click(object sender, RoutedEventArgs e)
        {
            txtBall.Text = balls++.ToString();
            txtPitches.Text = pitches++.ToString();
            mediaBall.Play();

        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            pitches = 1;
            balls = 1;
            strikes = 1;
            txtBall.Text = "0";
            txtPitches.Text = "0";
            txtStrike.Text = "0";
        }
    }
}
