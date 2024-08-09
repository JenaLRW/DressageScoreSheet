using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressageScoreSheet
{
    internal class ScoreInputModel
    {
        
        public double TotalScore { get; set; }
        public double[] Coef { get; internal set; }
        public int Errors { get; internal set; }
        public double[] TotalPoints { get; internal set; }
        
    }
}
