using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Goal : MonoBehaviour
{
    [SerializeField] BumperLoc bumperLoc;
    Scorekeeper scoreKeeper;

    private void OnTriggerEnter(Collider other)
    {
       
        Ball otherAsBall = other.gameObject.GetComponent<Ball>();
        if (otherAsBall)
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
    }
}
