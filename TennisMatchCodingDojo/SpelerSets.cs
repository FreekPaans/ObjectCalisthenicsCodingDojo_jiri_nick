using System;
using System.Collections.Generic;

namespace TennisMatchCodingDojo {
    public class SpelerSets {
        
        private Dictionary<Speler, Sets> Sets;

        public SpelerSets() {
            Sets = new Dictionary<Speler, Sets> {
                { Speler.Een, new Sets(0) },
                { Speler.Twee, new Sets(0) }
            };
        }

        public override string ToString() {
            return String.Format("{0} {1}", Sets[Speler.Een], Sets[Speler.Twee]);
        }

        public void ScoreSetVoor(Speler speler) {
            Sets[speler].Next();
        }
    }
}