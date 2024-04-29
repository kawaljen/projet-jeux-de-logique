

    public abstract class JeuPlusMoinsLogic : GameLogic
    {
         protected JeuPlusMoinsSettings settings;
        // public int guessesCompt = 0;
        // protected string secretCombinaison;

        protected JeuPlusMoinsLogic()
        {
            guessesCompt = 0;
            settings = JeuPlusMoinsSettings.GetInstance();
            //Init();
        }


        protected string Afficher(string test)
        {
            return test;
        }

        public override GameResponse Play(string guess){
            return PlayC(guess);

        }
        public abstract GameResponse PlayC(string guess);

        public abstract GameResponse Init();

    }
