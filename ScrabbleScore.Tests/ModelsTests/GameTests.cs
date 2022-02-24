using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System;
using System.Collections.Generic;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfItemGame_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual(typeof(int), newGame.GetType());
    }
  }
}
