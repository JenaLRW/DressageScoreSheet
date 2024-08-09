using Microsoft.AspNetCore.Mvc;

namespace scoringapi.Controllers
{
    public class Third1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    public interface Third1ScoringService
    {
        double CalculateScore(double[] totalPoints, double[] coef, int errors);
    }

    public class Third1Scoring : Third1ScoringService
    {
        public double CalculateScore(double[] totalPoints, double[] coef, int errors)
        {
            double sum = 0;
            for (int i = 0; i < totalPoints.Length; i++)
            {
                sum += totalPoints[i] * coef[i];
            }

            double percentage = ((sum - errors) / 370) * 100; 
            return percentage;
        }
    }

}
