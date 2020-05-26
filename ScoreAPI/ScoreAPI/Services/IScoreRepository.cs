using ScoreAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreAPI.Services
{
    public interface IScoreRepository
    {
        Score GetScore(string userName);
        IEnumerable<Score> GetScores();
        int GetPoints(String userName);
        void AddScore(Score score);
        void UpdateScore(Score score);
        void DeleteScore(Score score);


        bool ScoreExists(String userName);
        bool Save();
    }
}
