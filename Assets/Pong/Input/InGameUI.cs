using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InGameUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI player1ScoreText; 
    [SerializeField] TextMeshProUGUI player2ScoreText; 
    // Start is called before the first frame update
    void Start()
    {
        Scorekeeper scoreKeeper = FindObjectOfType<Scorekeeper>().GetComponent<Scorekeeper>();
        scoreKeeper.onPlayer1ScoreChanged += ChangePlayer1Score;
        scoreKeeper.onPlayer2ScoreChanged += ChangePlayer2Score;
        scoreKeeper.BroadcastPlayer1Score();
        scoreKeeper.BroadcastPlayer2Score();
    }

    private void ChangePlayer1Score(int newScore, int oldScore)
    {
        player1ScoreText.text = newScore.ToString();
    }

    private void ChangePlayer2Score(int newScore, int oldScore)
    {
        player2ScoreText.text = newScore.ToString();
    }
}
