using System;
namespace GamesApp.JeuPlusMoins{
    public class DefenseMode : JeuPlusMoinsLogic
    {
        private string computerProposition;

        public override GameResponse Init()
        {
            Random rand = new Random();
            computerProposition = rand.Next(settings.GetMinCombinaison(), settings.GetMaxCombinaison()).ToString();
            guessesCompt++;
            GameResponse toSend = new GameResponse();
            toSend.SetIsValid(true);
            toSend.SetMessage($"First give us a combination of {settings.GetNbCases()} digits, we'll try to guess it in {settings.GetNbGuesses()} guesses.");
            return toSend;
        }

        public override GameResponse PlayC(string userClue)
        {
            GameResponse toSend = new GameResponse();
            if (string.IsNullOrEmpty(secretCombinaison))
            {
                toSend = SetSecretCombinaison(userClue, toSend);
            }
            else 
            {
                if (ValidateUserInput(userClue))
                {
                    string computerAnswer = GenerateAnswer(userClue);
                    bool isWon = IsWon(userClue);
                    bool isLost = IsLost();

                    toSend.SetIsValid(true);
                    toSend.SetUserInput(userClue);
                    toSend.SetComputerAnswer(computerAnswer);
                    toSend.SetMessage($"Proposition {computerAnswer}");
                    toSend.SetWin(isWon);
                    toSend.SetLost(isLost);
                    return toSend;
                }
                else
                {
                    toSend.SetIsValid(false);
                    toSend.SetErrorMessage("Not a valid clue, we need +/-/=");
                    return toSend;

                }
            }

            return toSend;
        }

        private GameResponse SetSecretCombinaison(string userClue, GameResponse toSend)
        {
            if (int.TryParse(userClue, out int userInput))
            {
                if (userInput > settings.GetMinCombinaison() && userInput < settings.GetMaxCombinaison())
                {
                    secretCombinaison = userInput.ToString();
                    toSend.SetIsValid(true);
                    toSend.SetMessage("Perfect, let's begin !");
                }
                else
                {
                    toSend.SetIsValid(false);
                    toSend.SetErrorMessage($"The combination you sent, was not the right size, we need {settings.GetNbCases()} digits.");
                }
            }
            else{
                    toSend.SetIsValid(false);
                    toSend.SetErrorMessage("We work with digits, not letters !");               
            }
            return toSend;
        }

        private string GenerateAnswer(string userClue)
        {
            guessesCompt++;
            string response = "";
            for (int i = 0; i < userClue.Length; i++)
            {
                int computerPropCurrnentChar = computerProposition[i] - '0';

                if (userClue[i] == '-')
                {
                    response += computerPropCurrnentChar - 1;
                }
                else if (userClue[i] == '+')
                {
                    response += computerPropCurrnentChar + 1;
                }
                else if (userClue[i] == '=')
                {
                    response += computerPropCurrnentChar;
                }
            }
            return response;
        }

        private bool ValidateUserInput(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            s = s.Replace(" ", "");
            if (s.Length == settings.GetNbCases())
            {
                foreach (char c in s)
                {
                    if (c != '+' || c != '-' || c != '=')
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

    }
}