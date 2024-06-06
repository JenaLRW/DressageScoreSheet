using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressageScoreSheet
{
    internal class IntroA //USEF Introductory Test A https://www.usdf.org/docs/showflash/web/tests/2023/2023%20Intro%20A.pdf?t=6/5/2024%207:27:44%20PM
    {
        private decimal userInput;
        public decimal IAMove1 { get; set; } 
        public decimal IAMove2 { get; set; }
        public decimal IAMove3 { get; set; }
        public decimal IAMove4 { get; set; }
        public decimal IAMove5 { get; set; }
        public decimal IAMove6 { get; set; }
        public decimal IAMove7 { get; set; }
        public decimal IAMove8 { get; set; }   
        public decimal IAMove9 { get; set; }

        public decimal IAGaits { get; set; }
        public decimal IAImpulsion { get; set; }
        public decimal IASubmission { get; set; } //coef x2, need to add this in formula
        public decimal IAPosition { get; set; }
        public decimal IAEffectiveness { get;set; }
        public decimal IAAccuracy { get; set; }

        public int IATotalPoints = 160;



   
    
    }
}
