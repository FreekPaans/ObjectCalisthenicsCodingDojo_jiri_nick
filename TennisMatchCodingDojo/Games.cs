using System;

namespace TennisMatchCodingDojo {

    public class Games {

        private int Value;

        public Games(int value) {
            Value = value;
        }

        public void Next() {
            Value++;
        }
        public override string ToString() {
            return String.Format("{0}", Value);
        }

        public override bool Equals(object obj) {
            return obj is Games && ((Games)obj).Value == Value;
        }

    }

}