using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void Player1ScoreChanged(int newScore);
public delegate void Player2ScoreChanged(int newScore);


public class Scorekeeper : MonoBehaviour
{
    public Player1ScoreChanged onPlayer1ScoreChanged;
    public Player2ScoreChanged onPlayer2ScoreChanged;

    private int Player1Score = 0;
    private int Player2Score = 0;

    public void AddScore(int changeAmount,BumperLoc bumperLoc)
    {
        if(bumperLoc == BumperLoc.Right)
        {
            Player1Score++;
            onPlayer1ScoreChanged.Invoke(Player1Score);
        }
        else
        {
            Player2Score++;
            onPlayer2ScoreChanged.Invoke(Player2Score);
        }
    }
}
