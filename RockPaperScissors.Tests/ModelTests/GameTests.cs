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
      Game newGame = new Game();
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
      string playerOne = Game.PlayerOne;

      //Assert
      Assert.AreEqual(selection1, playerOne);
    }
  }
}
