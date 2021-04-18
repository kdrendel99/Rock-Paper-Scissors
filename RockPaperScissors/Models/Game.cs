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
      if (PlayerOne == PlayerTwo)
      {
        string result = "Draw!";
        return result;
      }
      else if (PlayerOne == "paper" && PlayerTwo == "rock")
      {
        string result = "Player One Wins!";
        return result;
      }
      else
      {
        string result = "stuff";
        return result;
      }
    }
  }
}