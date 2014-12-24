using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppeveliSportsLibrary
{
    class BaseballScorekeeping
    {

        public String PitchCount(String pitchCount)
        {
            int pitch = 1;
            pitchCount = pitch++.ToString();
            return pitchCount;
            
        }
        public void BallCount(String ballCount)
        {
            int balls = 1;
            ballCount = balls++.ToString();
            
        }
        public String KCount(String strikeCount)
        {
            int strikes = 1;
            strikeCount = strikes++.ToString();
            return strikeCount;
            
        }
        public void SwingCount(String swingCount)
        {
            int swings = 1;
            swingCount = swings++.ToString();
          

        }
        public void HitCount(String hitCount)
        {
            int hits = 1;
            hitCount = hits++.ToString();
      
        }
        public void Outs(String outs)
        {
            int o =  1;
            outs = o++.ToString();

        }
    }
}
