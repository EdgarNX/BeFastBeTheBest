using Microsoft.AspNetCore.Mvc;
using ScoreAPI.DbContexts;
using ScoreAPI.Entity;
using ScoreAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreAPI.Controllers
{
    [ApiController]
    [Route("api/scores")]
    public class ScoreController : ControllerBase
    {
        private readonly IScoreRepository _scoreRepository;
        
        public ScoreController(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository ??
                throw new ArgumentNullException(nameof(scoreRepository));

        }

        [HttpGet]
        public IActionResult GetScores()
        {
            var scoresFromRepo = _scoreRepository.GetScores();

            return Ok(scoresFromRepo);
        }

        [HttpGet]
        [Route("{userName}")]
        public IActionResult GetScore(string userName)
        {
            var userFromRepo = _scoreRepository.GetScore(userName);
            if (userFromRepo == null)
                return NotFound();

            return Ok(userFromRepo.Points);
        }

        [HttpPost]
        public int CreateScore([FromBody] Score score)
        {
            _scoreRepository.AddScore(score);
            _scoreRepository.Save();

            return score.Points;
        }

        [HttpPut]
        [Route("{userName}/{userPoints}")]
        public string UpdateScore(string userName, int userPoints)
        {
            if (!_scoreRepository.ScoreExists(userName))
                return "User not found!";

            var scoreFromRepo = _scoreRepository.GetScore(userName);
            if (scoreFromRepo == null)
                return "User not found!";

            if (scoreFromRepo.Points < userPoints)
                scoreFromRepo.Points = userPoints;

            _scoreRepository.UpdateScore(scoreFromRepo);
            _scoreRepository.Save();

            return "No content!";
        }

        [HttpDelete]
        [Route("{userName}")]
        public string DeleteScore(string userName)
        {
            var scoreToDelete = _scoreRepository.GetScore(userName);

            if (scoreToDelete == null)
                return "User not found!";

            _scoreRepository.DeleteScore(scoreToDelete);
            _scoreRepository.Save();

            return "User was deleted successfully!";
        }
    }
}
