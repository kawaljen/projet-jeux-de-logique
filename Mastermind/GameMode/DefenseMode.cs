using System;

namespace GamesApp.Mastermind
{
public class DefenseMode : MastermindLogic
{


    public override GameResponse Init()
    {
        GameResponse toSend = new GameResponse();
        

        toSend.SetMessage("pas d'implementation");

        return toSend;
    }

    public override GameResponse PlayC(string guess)
    {
        guessesCompt++;
        GameResponse toSend = new GameResponse();
        toSend.SetMessage("pas d'implementation");
        return toSend;
    }

}



    //     public DefenseMode (){
    //   String userPrompt = giveConsigne();
    // }


    // public String play(String combinaison){
    //   if(secretCombinaison == null){
    //      return proposeCombinaison(combinaison);

    //   }
    //   else {
    //     return giveComputerInt();

    //   }
    // }
    // private String giveConsigne(){
    //   return "Entrez un chiffre entre 0 et " + settings.maxCombinaison;

    // }

    // private String proposeCombinaison(String combinaison){
    //   if(Integer.parseInt(combinaison)>settings.maxCombinaison && Integer.parseInt(combinaison)>0){
    //       return "Too big or too small, try again";
    //   }
    //   else {
    //       secretCombinaison = combinaison;
    //   }
    //   return "thanks";
    // }

    // private String giveComputerInt(){      

    // }

    // private String computerTurn(){
    //   //...

    // }
}