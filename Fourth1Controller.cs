using Microsoft.AspNetCore.Mvc;

namespace scoringapi.Controllers
{
    public class Fourth1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    public interface Fourth1ScoringService
    {
        double CalculateScore(double[] totalPoints, double[] coef, int errors);
    }

    public class Fourth1Scoring : Fourth1ScoringService
    {
        public double CalculateScore(double[] totalPoints, double[] coef, int errors)
        {
            double sum = 0;
            for (int i = 0; i < totalPoints.Length; i++)
            {
                sum += totalPoints[i] * coef[i];
            }

            double percentage = ((sum - errors) / 380) * 100;
            return percentage;
        }
    }
}
