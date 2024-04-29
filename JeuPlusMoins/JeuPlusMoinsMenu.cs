namespace GamesApp.JeuPlusMoins{
    public class JeuPlusMoinsMenu : GameMenu
    {
        private static JeuPlusMoinsMenu jeuPlusMoinsMenuInstance;
        //public static List <JeuPlusMoinsLogic> jeuPlusMoins; //TODO non nullable ?

       // private enum Modes { CHALLENGERMODE, DEFENSEMODE, DUELMODE };

        private JeuPlusMoinsMenu()
        {
            name = "Jeu +/-";
            hasSettings = true;
            hasModes = true;
            if (gameLogic !=null) //TODO gameLogicDuel.Any() || 
            {
                gameStarted = true;
            }
        }

        public static GameMenu GetInstance()
        {
            if (jeuPlusMoinsMenuInstance == null)
            {
                jeuPlusMoinsMenuInstance = new JeuPlusMoinsMenu();
            }
            return jeuPlusMoinsMenuInstance;
        }
        protected override GameLogic StartDefenseMode(){
            return new DefenseMode();
        }
        protected override GameLogic StartChallengerMode(){
            return new ChallengerMode();
        }
        public override GameSettings GetSettings(){
          return JeuPlusMoinsSettings.GetInstance();
        }
    }
}