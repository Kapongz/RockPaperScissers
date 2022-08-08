namespace RockPaperAndScissors.Helper
{
    public class Hand
    {

        public OptionRPS WinsAgainst { get; set; }
        public OptionRPS LosesAgainst { get; set; }
        public OptionRPS Selection { get; set; }
        public string Image { get; set; }

        public GameStatus PlayAgainst(Hand opponetHand)
        {
            if (Selection == opponetHand.Selection)
            {
                return GameStatus.Draw;
            }
            if (LosesAgainst == opponetHand.Selection)
            {
                return GameStatus.Loss;
            }
            return GameStatus.Victory;
        }

    }
}
