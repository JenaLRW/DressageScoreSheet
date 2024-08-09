using Microsoft.AspNetCore.Mvc;

namespace scoringapi.Controllers
{
    public class Training1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    public interface Training1ScoringService
    {
        double CalculateScore(double[] totalPoints, double[] coef, int errors);
    }

    public class Train1Scoring : Training1ScoringService
    {
        public double CalculateScore(double[] totalPoints, double[] coef, int errors)
        {
            double sum = 0;
            for (int i = 0; i < totalPoints.Length; i++)
            {
                sum += totalPoints[i] * coef[i];
            }

            double percentage = ((sum - errors) / 260) * 100; 
            return percentage;
        }
    }

}
