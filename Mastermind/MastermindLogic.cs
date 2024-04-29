namespace GamesApp
{

    public abstract class MastermindLogic : GameLogic
    {
        protected MastermindSettings settings;


        public MastermindLogic()
        {
            guessesCompt = 0;
            settings = MastermindSettings.GetInstance();
            //Init();
        }


        public override GameResponse Play(string guess){
            return PlayC(guess);

        }
        public abstract GameResponse PlayC(string guess);

        public abstract GameResponse Init();


    }
}
