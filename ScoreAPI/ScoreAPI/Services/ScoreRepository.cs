using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScoreAPI.Entity;
using ScoreAPI.DbContexts;

namespace ScoreAPI.Services
{
    public class ScoreRepository : IScoreRepository
    {
        private readonly ScoreContext _context;
        public ScoreRepository(ScoreContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        public void AddScore(Score score)
        {
            if (score == null)
                throw new ArgumentNullException(nameof(score));

            _context.Scores.Add(score);
        }

        public void DeleteScore(Score score)
        {
            if (score == null)
                throw new ArgumentNullException(nameof(score));

            _context.Scores.Remove(score);
        }

        public int GetPoints(string userName)
        {
            if (userName == String.Empty)
                throw new ArgumentNullException(nameof(userName));

            return _context.Scores.FirstOrDefault(s => s.UserName == userName).Points;
        }

        public IEnumerable<Score> GetScores()
        {
            return _context.Scores.OrderByDescending(s => s.Points).ToList();
        }

        public Score GetScore(string userName)
        {
            if (userName == String.Empty)
                throw new ArgumentNullException(nameof(userName));

            return _context.Scores.Where(s => s.UserName == userName).FirstOrDefault();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public bool ScoreExists(string userName)
        {
            if (userName == String.Empty)
                throw new ArgumentNullException(nameof(userName));

            return _context.Scores.Any(s => s.UserName == userName);
        }

        public void UpdateScore(Score score)
        {
            // implemented 
        }
    }
}
