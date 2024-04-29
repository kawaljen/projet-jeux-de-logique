
    public abstract class GameMenu
    {
        public string name = "";
        public bool hasSettings = false;
        public bool hasModes = false;
        public bool gameStarted = false;
        public static GameLogic[] gameLogicDuel;
        public static GameLogic gameLogic;
        private enum Modes { CHALLENGERMODE, DEFENSEMODE, DUELMODE };

        protected abstract GameLogic StartDefenseMode();
        protected abstract GameLogic StartChallengerMode();
        public abstract GameSettings GetSettings();


        public GameLogic StartNewGame(object mode)
        {
            gameLogicDuel = new GameLogic[2];
            if (mode.Equals(Modes.DEFENSEMODE))
            {
                gameLogic =  StartDefenseMode();
            }
            else
            {
                gameLogic = StartChallengerMode();
            }
            return gameLogic;
        }
        public  GameLogic StartNewGame()
        {
            gameLogicDuel = new GameLogic[2];
            gameLogic = StartChallengerMode();
            
            return gameLogic;
        }        
        
        public  GameLogic[] StartNewDuelGame()
        {
            gameLogicDuel = new GameLogic[2];
            gameLogicDuel[0] = StartChallengerMode();
            gameLogicDuel[1] =  StartDefenseMode();

            
        
            return gameLogicDuel;
        }

        public GameLogic ResumeGame()
        {
            // Implement resume logic if needed //TODO 
            return gameLogic;
        }

        public GameLogic[] ResumeDuelGame()
        {
            // Implement resume logic if needed //TODO 
            return gameLogicDuel;
        }
        public static void EndGame()
        {
            gameLogic = null;
            gameLogicDuel= new GameLogic[2]; 
        }

}
