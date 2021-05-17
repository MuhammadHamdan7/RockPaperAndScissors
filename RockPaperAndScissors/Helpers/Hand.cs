using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperAndScissors.Helpers
{
    public class Hand
    {
        public OptionRPS Selection { get; set; }
        public OptionRPS WinAgainst { get; set; }
        public OptionRPS LosesAgainst { get; set; }

        public String Image { get; set; } 

        public GameStatus PlayAgainst(Hand opponentHand)
        {
            if (Selection == opponentHand.Selection)
            {
                return GameStatus.Draw;
            }

            if (LosesAgainst == opponentHand.Selection)
            {
                return GameStatus.Loss;
            }
                return GameStatus.Victory;
        }
    }
}
