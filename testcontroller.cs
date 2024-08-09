using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using scoringapi.Model;

namespace scoringapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class testcontroller : ControllerBase
    {

        private readonly IntroAScoringService _introAScoringService;
        // Add services for other tests as needed

        public testcontroller (IntroAScoringService introAScoringService)
        {
            _introAScoringService = introAScoringService;
        }

        [HttpPost("IntroA")]
        public IActionResult CalculateIntroAScore([FromBody] ScoreInputModel input)
        {
            var score = _introAScoringService.CalculateScore(input.TotalPoints, input.Coef, input.Errors);
            return Ok(new { Score = score });
        }

        // Add methods for other tests
        

    }
}
