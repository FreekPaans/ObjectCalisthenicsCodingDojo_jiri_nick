using System;

namespace TennisMatchCodingDojo {
    public class SetsScore {

        private SpelerSets SpelerSets;
        private GamesScore Games;

        public SetsScore() {
            SpelerSets = new SpelerSets();
            Games = new GamesScore();
        }

        public void ScorePuntVoor(Speler speler) {
            Games.ScorePuntVoor(speler, SpelerSets);
        }

        public override string ToString() {
            return String.Format("{0} {1}", SpelerSets, Games);
        }
    }
}