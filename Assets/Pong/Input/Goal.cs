using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Goal : MonoBehaviour
{
    [SerializeField] BumperLoc bumperLoc;
    [SerializeField] Scorekeeper scoreKeeper;

    private void OnTriggerEnter(Collider other)
    {
        if (bumperLoc == BumperLoc.Left)
        {
            //Debug.Log("should change player2 score now");
            scoreKeeper.AddScore(1, bumperLoc);
        }
        else if (bumperLoc == BumperLoc.Right)
        {
            Debug.Log("should change player1 score now");
            scoreKeeper.AddScore(1, bumperLoc);
        }


        /*Debug.Log("something passed through me");
        Ball otherAsBall = other.GetComponent<Ball>();
        if (otherAsBall != null)
        {
            Debug.Log("the ball has passed me");
            if(bumperLoc == BumperLoc.Left)
            {
                scoreKeeper.ChangePlayer2Score(1);
            }
            else if(bumperLoc == BumperLoc.Right)
            {
                scoreKeeper.ChangePlayer1Score(1);
            }
        }
        else
        {
            Debug.Log("other as ball is not a ball");
        }*/
    }
}
