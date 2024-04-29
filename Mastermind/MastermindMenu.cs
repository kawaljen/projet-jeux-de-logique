namespace GamesApp.Mastermind
{
    public class MastermindMenu : GameMenu
    {
        private static MastermindMenu MastermindMenuInstance;


        private MastermindMenu()
        {
            name = "Mastermind";
            hasSettings = true;
            hasModes = true;
            if (gameLogic !=null) //TODO gameLogicDuel.Any() || 
            {
                gameStarted = true;
            }
        }

        public static GameMenu GetInstance()
        {
            if (MastermindMenuInstance == null)
            {
                MastermindMenuInstance = new MastermindMenu();
            }
            return MastermindMenuInstance;
        }

        protected override GameLogic StartDefenseMode(){
            return new DefenseMode();
        }
        protected override GameLogic StartChallengerMode(){
            return new ChallengerMode();
        }

        public override GameSettings GetSettings(){
          return MastermindSettings.GetInstance();
        }
    }
}