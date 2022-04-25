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
            scoreKeeper.AddScore(1, bumperLoc);
            DestroyBall(other.gameObject);
            
        }
        else if (bumperLoc == BumperLoc.Right)
        {
            scoreKeeper.AddScore(1, bumperLoc);
            DestroyBall(other.gameObject);
        }
    }

    void DestroyBall(GameObject other)
    {
        Player player = FindObjectOfType<Player>();
        player.RespawnBall();
        Destroy(other);
    }
}
