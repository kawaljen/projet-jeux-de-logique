

using System.Runtime.InteropServices;

public class  MastermindSettings : GameSettings
    {
        private static  MastermindSettings settings;
        public int nbColors;

        private  MastermindSettings()
        {
            nbGuesses = 10;
            nbCases = 4;
            nbCasesmin = 4;
            nbCasesmax = 10;
            nbGuessesmin = 10;
            nbGuessesmax = 50;
            nbColors = 6;
            SetOffset();
        }

        public static MastermindSettings GetInstance()
        {
            if (settings == null)
            {
                settings = new  MastermindSettings();
            }
            return settings;
        }


        public void Reset()
        {
            settings = new MastermindSettings();
        }
    }
