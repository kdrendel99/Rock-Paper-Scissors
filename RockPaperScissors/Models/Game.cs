namespace RockPaperScissors.Models
{
  public class Game
  {
    public string PlayerOne {get; set;}
    public string PlayerTwo {get; set;}

    public Game(string playerOne, string playerTwo)
    {
      PlayerOne = playerOne;
      PlayerTwo = playerTwo;
    }

    public string GetWinner() 
    { 
      string result = "";
      return result;
    }
  }
}