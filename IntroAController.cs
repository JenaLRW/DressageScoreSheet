using Microsoft.AspNetCore.Mvc;

namespace scoringapi.Controllers
{
    public class ScoringService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    public interface IntroAScoringService

    {
        double CalculateScore(double[] totalPoints, double[] coef, int errors);
    }

    public class IntroAScoring : IntroAScoringService
    {
        public double CalculateScore(double[] totalPoints, double[] coef, int errors)
        {
            double sum = 0;
            for (int i = 0; i < totalPoints.Length; i++)
            {
                sum += totalPoints[i] * coef[i];
            }

            double percentage = ((sum - errors) / 160) * 100; 
            return percentage;
        }
    }

}
