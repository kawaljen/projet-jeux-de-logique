using System;
using GamesApp.JeuPlusMoins;
using GamesApp.Mastermind;

    public class GamesApplication
    {
        // private bool isModeDev;
        private GameMenu[] gamesAvailable;

        public GamesApplication()
        {
            gamesAvailable = new GameMenu[2];
            gamesAvailable[0] = GamesApp.Mastermind.MastermindMenu.GetInstance();
            gamesAvailable[1] = GamesApp.JeuPlusMoins.JeuPlusMoinsMenu.GetInstance();
        }

        public GameMenu[] GetGames()
        {
            return gamesAvailable;
        }
    }
