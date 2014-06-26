using System;
using System.Collections.Generic;

namespace TennisMatchCodingDojo {
    public class SpelerGames {

        private Dictionary<Speler, Games> Games;

        public SpelerGames() {
            ResetGames();
        }

        public override string ToString() {
            return String.Format("{0} {1}", Games[Speler.Een], Games[Speler.Twee]);
        }

        public void ScoreGameVoor(Speler speler, SpelerSets spelerSets) {
            Games[speler].Next();
            if (Games[speler].Equals(new Games(6))) {
                spelerSets.ScoreSetVoor(speler);
                ResetGames();
            }
        }

        private void ResetGames() {
            Games = new Dictionary<Speler, Games> {
                { Speler.Een, new Games(0) },
                { Speler.Twee, new Games(0) }
            };
        }
    }

}