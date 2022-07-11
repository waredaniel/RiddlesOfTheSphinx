using System;

namespace Sphinx {
  public class Riddle
  {
    private int _id;
    private string _question;
    private string _answer;

    public Riddle(int id, string question, string answer)
    {
      _id = id;
      _question = question;
      _answer = answer;
    }

    public int GetId()
    {
      return _id;
    }
    public string GetQuestion()
    {
      return _question;
    }
    public string GetAnswer()
    {
      return _answer;
    }
  }
}