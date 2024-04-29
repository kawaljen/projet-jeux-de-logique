using System;
namespace GamesApp.JeuPlusMoins{


public class ChallengerMode : JeuPlusMoinsLogic
{
    public override GameResponse Init()
    {
        GenerateSecretCombinaison();
        GameResponse toSend = new GameResponse();
        toSend.SetIsValid(true);
        toSend.SetMessage("Give us a combination:");
        return toSend;
    }

    public override GameResponse PlayC(string guess)
    {
        guessesCompt++;
        GameResponse toSend = new GameResponse();

        if(secretCombinaison == null){
            GenerateSecretCombinaison();
        }
        if (!string.IsNullOrEmpty(guess) && guess.Length == secretCombinaison.Length)
        {
            string response = CheckGuess(guess);
            bool isWon = IsWon(guess);
            bool isLost = IsLost();

            toSend.SetIsValid(true);
            toSend.SetUserInput(guess);
            toSend.SetComputerAnswer(response);
            toSend.SetMessage($"Proposal {guess} -> {response}");
            toSend.SetWin(isWon);
            toSend.SetLost(isLost);

            if (isWon || isLost)
            {
                JeuPlusMoinsMenu.EndGame();
            }
        }
        else
        {
            toSend.SetErrorMessage($"The combination you sent was not the right size, we need {settings.GetNbCases()} digits.");
        }
        return toSend;
    }


    private string CheckGuess(string guess)
    {
        string response = "";
        for (int i = 0; i < guess.Length; i++)
        {
            int guessDigit = guess[i] - '0';
            int secretCombinaisonDigit = secretCombinaison[i] - '0';

            if (guessDigit > secretCombinaisonDigit)
            {
                response += "-";
            }
            else if (guessDigit < secretCombinaisonDigit)
            {
                response += "+";
            }
            else
            {
                response += "=";
            }
        }
        return response;
    }

    protected void GenerateSecretCombinaison()
    {
        Random rand = new Random();
        secretCombinaison = rand.Next(settings.GetMinCombinaison(), settings.GetMaxCombinaison() + 1).ToString();
    }
}
}