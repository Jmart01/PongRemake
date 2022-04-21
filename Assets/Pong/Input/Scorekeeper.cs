using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void Player1ScoreChanged(int newScore, int oldScore);
public delegate void Player2ScoreChanged(int newScore, int oldScore);

public class Scorekeeper : MonoBehaviour
{
    public Player1ScoreChanged onPlayer1ScoreChanged;
    public Player2ScoreChanged onPlayer2ScoreChanged;

    int Player1Score = 0;
    int Player2Score = 0;

    public void ChangePlayer1Score(int changeAmount)
    {
        int oldPlayer1Score = Player1Score;
        Player1Score += changeAmount;

        if (onPlayer1ScoreChanged != null)
        {
            onPlayer1ScoreChanged.Invoke(Player1Score, oldPlayer1Score);
        }
    }

    public void ChangePlayer2Score(int changeAmount)
    {
        int oldPlayer2Score = Player2Score;
        Player1Score += changeAmount;

        if(onPlayer2ScoreChanged != null)
        {
            onPlayer2ScoreChanged.Invoke(Player2Score, oldPlayer2Score);
        }
    }

    public void BroadcastPlayer1Score()
    {
        onPlayer1ScoreChanged.Invoke(Player1Score, Player1Score);
    }

    public void BroadcastPlayer2Score()
    {
        onPlayer2ScoreChanged.Invoke(Player2Score, Player2Score);
    }
}
