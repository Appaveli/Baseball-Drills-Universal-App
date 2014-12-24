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
using AppeveliDisplayLandscape;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace BaseballDrills
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SwingCount : Page
    {
        int swings = 1;
        int hits = 1;
        int strikes = 1;
        int outs = 1;
        AppeveliRotation rotate;
        public SwingCount()
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
            //rotate.AppeveliLandscape();
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            //rotate.AppeveliLandscape();
        }
        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
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
