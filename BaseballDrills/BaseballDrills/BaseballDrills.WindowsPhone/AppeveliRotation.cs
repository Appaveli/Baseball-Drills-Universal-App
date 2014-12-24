using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Display;

namespace AppeveliDisplayLandscape
{
    class AppeveliRotation
    {
        public void AppeveliLandscape()
        {
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Landscape; 
        }
        public void AppeveliLandscapeFlipped()
        {
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.LandscapeFlipped;
        }
        public void AppeveliPortrait()
        {
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait;
        }
        public void AppeveliPortraitFlipped()
        {
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.PortraitFlipped;
        }
    }
}
