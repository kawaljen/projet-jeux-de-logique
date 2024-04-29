
using System.ComponentModel;

public abstract class GameLogic {
        protected List <GameLogic> gameLogicDuel; //TODO non nullable ?
        protected GameLogic gameLogic;
        // protected JeuPlusMoinsSettings settings; //TODO jeuplus moins
        // protected MastermindSettings settingsM;

        protected int guessesCompt = 0;
        protected string secretCombinaison;

        public abstract GameResponse Play(string guess);

        protected bool IsWon(string input)
        {
            if (secretCombinaison.Contains(input))
            {
                return true;
            }
            return false;
        }

        protected bool IsLost()
        {
            int nbguesses =10;
            // if(settings != null )
            // {
            //     nbguesses = settings.nbGuesses;
            // }
            // else {
            //     nbguesses = settingsM.nbGuesses; //TODO
            // }
            if (guessesCompt >= nbguesses)
            {
                return true;
            }
            return false;
        }
        public GameResponse AfficherDev()
        {
            GameResponse toSend = new GameResponse();
            toSend.SetDevInfo($"(Secret Combination: {secretCombinaison})"); //TODO ad it to the playresponse
            return toSend;
        }
    }
    



