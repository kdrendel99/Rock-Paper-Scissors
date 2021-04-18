using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("rock","paper");
      Assert.AreEqual(typeof(Game),newGame.GetType());
    }

    [TestMethod]
    public void GetPlayerOne_ReturnsPlayerOne_String()
    {
      // Arrange
      string selection1 = "rock";
      string selection2 = "paper";

      //Act
      Game newGame = new Game(selection1,selection2);
      string playerOne = newGame.PlayerOne;

      //Assert
      Assert.AreEqual(selection1, playerOne);
    }

    [TestMethod]
    public void GetPlayerTwo_ReturnsPlayerTwo_String()
    {
      // Arrange
      string selection1 = "rock";
      string selection2 = "paper";

      //Act
      Game newGame = new Game(selection1,selection2);
      string playerTwo = newGame.PlayerTwo;

      //Assert
      Assert.AreEqual(selection2, playerTwo);
    }

    [TestMethod]
    public void GetWinner_ReturnsDrawString_Draw()
    {
      string selection1 = "rock";
      string selection2 = "rock";

      Game newGame = new Game(selection1,selection2);
      string result = newGame.GetWinner();
      string winner = "Draw!";

      Assert.AreEqual(winner, result);
    }    

    [TestMethod]
    public void GetWinner_ReturnsPlayerOnePaperWin_PlayerOneWins()
    {
      string selection1 = "paper";
      string selection2 = "rock";

      Game newGame = new Game(selection1,selection2);
      string result = newGame.GetWinner();
      string winner = "Player One Wins!";

      Assert.AreEqual(winner, result);
    }
  }
}
