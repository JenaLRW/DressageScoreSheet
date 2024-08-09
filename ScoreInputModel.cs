namespace scoringapi.Model
{
    public class ScoreInputModel
    {
        public double TotalScore { get; set; }
        public double[] Coef { get; internal set; }
        public int Errors { get; internal set; }
        public double[] TotalPoints { get; internal set; }
    }
}
