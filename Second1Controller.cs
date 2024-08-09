using Microsoft.AspNetCore.Mvc;

namespace scoringapi.Controllers
{
    public class Second1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    public interface Second1ScoringService
    {
        double CalculateScore(double[] totalPoints, double[] coef, int errors);
    }

    public class Second1Scoring : Second1ScoringService
    {
        public double CalculateScore(double[] totalPoints, double[] coef, int errors)
        {
            double sum = 0;
            for (int i = 0; i < totalPoints.Length; i++)
            {
                sum += totalPoints[i] * coef[i];
            }

            double percentage = ((sum - errors) / 350) * 100; 
            return percentage;
        }
    }

}
