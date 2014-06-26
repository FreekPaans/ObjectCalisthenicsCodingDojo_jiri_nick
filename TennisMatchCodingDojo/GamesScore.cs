using System;

namespace TennisMatchCodingDojo {
    public class GamesScore {
        
        private SpelerGames SpelerGames;
        private PuntenScore Punten;

        public GamesScore() {
            ResetGames();
        }

        public void ScorePuntVoor(Speler speler, SpelerSets spelerSets) {
            Punten.ScorePuntVoor(speler, SpelerGames, spelerSets);
        }

        private void ResetGames() {
            Punten = new PuntenScore();
            SpelerGames = new SpelerGames();
        }

        public override string ToString() {
            return String.Format("{0} {1}", SpelerGames, Punten);
        }

    }

}