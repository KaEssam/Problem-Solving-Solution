public class Kata
{
  public string Rps(string p1, string p2)
  {
    if (p1 == p2)
    {
      return "Draw!";
    }
    else if (p1 == "rock" && p2 == "scissors")
    {
      return "Player 1 won!";
    }

    else if (p1 == "paper" && p2 == "rock")

    {
      return "Player 1 won!";
    }
    else if (p1 == "scissors" && p2 == "paper")
    {
      return "Player 1 won!";
    }
    else if (p1 == "rock" && p2 == "paper")
    {
      return "Player 2 won!";
    }
    else if (p1 == "paper" && p2 == "scissors")
    {
      return "Player 2 won!";
    }
    else if (p1 == "scissors" && p2 == "rock")
    {
      return "Player 2 won!";
    }
    return "";
  }
}
