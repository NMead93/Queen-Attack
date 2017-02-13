using System;
using ChessGame.Objects;
using Xunit;

namespace ChessGame
{
  public class QueenTest
  {
    [Fact]
    public void CanAttack_TestIfCanAttackHorzintally_True()
    {
      Queen testQueen = new Queen(3,4);

      Assert.Equal(true, testQueen.CanAttack(4,4));
    }

    [Fact]
    public void CanAttack_TestIfCanAttackVertically_True()
    {
      Queen testQueen = new Queen(6, 3);

      Assert.Equal(true, testQueen.CanAttack(6, 1));
    }

    [Fact]
    public void CanAttack_TestIfCanAttackDiagonally_True()
    {
      Queen testQueen = new Queen(3, 4);

      Assert.Equal(true, testQueen.CanAttack(6, 1));
    }
  }
}
