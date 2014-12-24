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
using AppeveliSportsLibrary;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace BaseballDrills
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PitchCount : Page
    {
        int pitches = 1;
        int balls = 1;
        int strikes = 1;
        BaseballScorekeeping sk = new BaseballScorekeeping();
        public PitchCount()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Strikes_Click(object sender, RoutedEventArgs e)
        {
            //sk.KCount(txtStrike.Text.ToString());
            //sk.PitchCount(txtPitches.Text.ToString());
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
