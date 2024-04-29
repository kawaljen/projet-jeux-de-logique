using System;
using System.ComponentModel;


public class MainClass {


    public static void Main() {
         Console.WriteLine("hello world");
        GamesApplication game = new GamesApplication();


        GameMenu jeuplusmoins = game.GetGames()[1];
        GameLogic instJPM = jeuplusmoins.StartNewGame();
        GameSettings jeuplusmoinsSet = jeuplusmoins.GetSettings();
        jeuplusmoinsSet.SetNbCases(7);

        GameResponse respJPM = instJPM.Play("3333");
        Console.WriteLine(respJPM.GetMessage());
        Console.WriteLine(instJPM.AfficherDev().GetDevInfo());



        GameMenu mastermind = game.GetGames()[0];
        GameLogic instM =mastermind.StartNewGame();
        GameSettings mastermindSet = mastermind.GetSettings();
        mastermindSet.SetNbCases(5);


        GameResponse respM = instM.Play("65545");
        Console.WriteLine(respM.GetMessage());
        Console.WriteLine(instM.AfficherDev().GetDevInfo());


        GameResponse respJPM2t = instJPM.Play("6765");
        Console.WriteLine(respJPM2t.GetMessage());
        Console.WriteLine(instJPM.AfficherDev().GetDevInfo());

        GameResponse respM2t = instM.Play("34445");
        Console.WriteLine(respM2t.GetMessage());
        Console.WriteLine(instM.AfficherDev().GetDevInfo());

    }
}  


