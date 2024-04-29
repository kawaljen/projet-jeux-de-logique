 # GameApp
A exercice to play around with object oriented architecture<br/>

GetGames : gives an array of available games <br/>

Game Menu :<br/>
-> StartNewGame : start the game chosen<br/>
-> StartNewDuelGame : start duel game<br/>
-> ResumeGame : resume previously started game<br/>
-> ResumeDuelGame : resume previously started duelgame<br/>
-> EndGame : end single and duel game<br/>
-> GetSettings : acces to settings and change some of them, depend of each game, for Mastermind (SetNbCases, SetNbColors, SetNbGuesses, Reset ..)<br/>
<br/>
For each game :<br/>
-> Play (string) : play a turn, return a response (bool win, bool lost, computerAnswer, userInput, message, isValid, devInfo, errorMessage)<br/>
<br/>
<br/>
Exemple:<br/>
GamesApplication game = new GamesApplication();<br/>
GameMenu jeuplusmoins = game.GetGames()[1];<br/>
<br/>
GameLogic instJPM = jeuplusmoins.StartNewGame();<br/>
GameSettings jeuplusmoinsSettings = jeuplusmoins.GetSettings();<br/>
jeuplusmoinsSettings.SetNbCases(5);<br/>
<br/>
GameResponse respJPM = instJPM.Play("33733");<br/>
Console.WriteLine(respJPM.GetMessage());<br/>
