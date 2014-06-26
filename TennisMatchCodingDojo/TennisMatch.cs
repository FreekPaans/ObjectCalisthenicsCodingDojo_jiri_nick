using System;
using System.Linq;
using System.Text;

namespace TennisMatchCodingDojo
{
    public class TennisMatch {

        //private PuntenScore PuntenScore;
        //private GamesScore GamesScore;
        private SetsScore SetsScore;

        public TennisMatch() {
            //PuntenScore = new PuntenScore();
            //GamesScore = new GamesScore();
            SetsScore = new SetsScore();
        }

        public string BerekenScore() {
            //return String.Format("{0}", GamesScore);
            return String.Format("{0}", SetsScore);
        }

        public void ScorePuntVoor(Speler speler) {
            //GamesScore.ScorePuntVoor(speler);
            SetsScore.ScorePuntVoor(speler);
        }
        
    }
}
