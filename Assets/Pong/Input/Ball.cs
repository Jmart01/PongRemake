using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BumperLoc
{
    Left,
    Right
};

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, 0f);
    }

    public void ChangeVelocity(BumperLoc bumperLoc)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if(bumperLoc == BumperLoc.Left)
        {
            rb.AddForceAtPosition(transform.right* speed,transform.position,ForceMode.Force);
        }
        else
        {
            rb.AddForceAtPosition(-transform.right*speed,transform.position,ForceMode.Force);
        }
        speed+=10;
        Debug.Log(speed);
    }
}
