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
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }
    [TestMethod]
    public void ReturnScore_ReturnsScoreForLetterA_1()
    {
      Assert.AreEqual(1, Game.ReturnScore("a"));
    }
    [TestMethod]
    public void ReturnScore_ReturnsScoreForAnyIndividualLetter_10()
    {
      Assert.AreEqual(10, Game.ReturnScore("q"));
    }
    [TestMethod]
    public void ReturnScore_ReturnsScoreForWordAt_2()
    {
      Assert.AreEqual(2, Game.ReturnScore("at"));
    }
  }
}


/*
if A is entered, return 1
if q is entered, return 10











*/