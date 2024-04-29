public abstract class GameSettings {
        protected int nbGuesses;
        protected int nbCases;
        protected int nbColors ;
        protected int maxCombinaison;
        protected int minCombinaison;

        protected int nbCasesmin;
        protected int nbCasesmax;
        protected int nbGuessesmax;
        protected int nbGuessesmin; 

        public int GetNbGuesses (){
            return nbGuesses;
        }

        public int GetNbCases (){
            return nbCases;
        }

        public int GetNbColors (){
            return nbColors;
        }
        public int GetMaxCombinaison (){
            return maxCombinaison;
        }
        public int GetMinCombinaison (){
            return minCombinaison;
        }
        public void SetNbCases(int nbCases)
        {
            if (nbCases > nbCasesmin && nbCases <= nbCasesmax)
            {
                this.nbCases = nbCases;
                SetOffset();
            }
            else
            {
                // Exception handling // TODO exeption
            }
        }
        public void SetNbColors(int nbColors)
        {
            if (nbCases > 4  && nbColors <= 10)
            {
                this.nbColors = nbColors;

            }
            else
            {
                // Exception handling // TODO exeption
            }
        }

        public void SetNbGuesses(int nbGuesses)
        {
            if (nbGuesses > nbGuessesmin && nbGuesses <= nbGuessesmax)
            {
                this.nbGuesses = nbGuesses;
            }
            else
            { 
                // Exception handling // TODO exeption
            }
        }
        protected void SetOffset(){
            int max = 1;
            for (int i = 0; i < nbCases; i++)
            {
                max = max * 10;
            }
            minCombinaison = max / 10;
            maxCombinaison = max -1;
        }

}