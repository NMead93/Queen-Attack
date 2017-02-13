using System;

namespace ChessGame.Objects
{
  public class Queen
  {
    private int _x;
    private int _y;

    public Queen(int x, int y)
    {
       _x = x;
       _y = y;
    }

    public int GetX()
    {
      return _x;
    }
    public void SetX(int newX)
    {
      _x = newX;
    }
    public int GetY()
    {
      return _y;
    }
    public void SetY(int newY)
    {
      _y = newY;
    }

    public bool CanAttack(int x, int y)
    {
      if (_y == y || _x == x || Math.Abs(_x - x) == Math.Abs(_y - y))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  }
}
