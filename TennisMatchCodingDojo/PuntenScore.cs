using System;
using System.Collections.Generic;

namespace TennisMatchCodingDojo {
    public class PuntenScore {

        private Dictionary<Speler, Punten> SpelerPunten; 

        public PuntenScore() {
            ResetPunten();
        }

        public override string ToString() {
            var puntenString = String.Format("{0} {1}", (int)SpelerPunten[Speler.Een], (int)SpelerPunten[Speler.Twee]);
            return puntenString.Replace("50", "A");
        }

        public void ResetPunten() {
            SpelerPunten = new Dictionary<Speler, Punten> {
                { Speler.Een, Punten.Nul },
                { Speler.Twee, Punten.Nul },
            };
        }

        public void ScorePuntVoor(Speler speler, SpelerGames spelerGames, SpelerSets spelerSets) {
            var puntenSpeler = SpelerPunten[speler];
            if (puntenSpeler == Punten.Nul) {
                SpelerPunten[speler] = Punten.Vijftien;
            }
            if (puntenSpeler == Punten.Vijftien) {
                SpelerPunten[speler] = Punten.Dertig;
            }
            if (puntenSpeler == Punten.Dertig) {
                SpelerPunten[speler] = Punten.Veertig;
            }
            var andereSpeler = GetAndereSpeler(speler);
            var puntenAndereSpeler = SpelerPunten[andereSpeler];
            if (puntenSpeler == Punten.Veertig && puntenAndereSpeler == Punten.Veertig) {
                SpelerPunten[speler] = Punten.Advantage;
            }
            if (puntenSpeler == Punten.Veertig && puntenAndereSpeler == Punten.Advantage) {
                SpelerPunten[andereSpeler] = Punten.Veertig;
            }
            if (puntenSpeler == Punten.Veertig && (puntenAndereSpeler != Punten.Veertig && puntenAndereSpeler != Punten.Advantage)) {
                ScoreGame(speler, spelerGames, spelerSets);
            }
            if (puntenSpeler == Punten.Advantage) {
                ScoreGame(speler, spelerGames, spelerSets);
            }
        }

        public void ScoreGame(Speler speler, SpelerGames spelerGames, SpelerSets spelerSets) {
            spelerGames.ScoreGameVoor(speler, spelerSets);

            ResetPunten();
        }

        private Speler GetAndereSpeler(Speler speler) {
            if (speler == Speler.Een) {
                return Speler.Twee;
            }
            return Speler.Een;
        }

    }

}
