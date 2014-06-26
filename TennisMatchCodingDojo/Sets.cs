using System;

namespace TennisMatchCodingDojo {

    public class Sets {

        private int Value;

        public Sets(int value) {
            Value = value;
        }

        public void Next() {
            Value++;
        }
        public override string ToString() {
            return String.Format("{0}", Value);
        }
    }

}