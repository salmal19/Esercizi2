using System;

namespace Esercizi2{

    public class Calcolatrice{
        //Attributi
        private int n;

        private int k;

        //Property
        public int N {
            get => n;
            set => n = value;
        }

        public int K {
            get => k;
            set => k = value;
        }

        //Methods
        public int Addizione() => N + K ;

        public int Sottrazione() => N - K ;

        public int Moltiplicazione() => N * K ;

        public int Divisione() => N / K ;

    }
}