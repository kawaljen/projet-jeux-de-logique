
using System.Runtime.InteropServices;

public class JeuPlusMoinsSettings : GameSettings
    {
        private static JeuPlusMoinsSettings settings;
        private JeuPlusMoinsSettings()
        {
            nbGuesses = 10;
            nbCases = 4;
            nbCasesmin = 4;
            nbCasesmax = 10;
            nbGuessesmin = 10;
            nbGuessesmax = 50;
            SetOffset();
        }

        public static JeuPlusMoinsSettings GetInstance()
        {
            if (settings == null)
            {
                settings = new JeuPlusMoinsSettings();
            }
            return settings;
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
        private void SetOffset(){
            int max = 1;
            for (int i = 0; i < nbCases; i++)
            {
                max = max * 10;
            }
            minCombinaison = max / 10;
            maxCombinaison = max -1;
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

        public void Reset()
        {
            settings = new JeuPlusMoinsSettings();
        }
    }
