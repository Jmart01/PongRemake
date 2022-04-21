using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 5f;
    [SerializeField] GameObject topCollider;
    [SerializeField] GameObject midCollider;
    [SerializeField] GameObject btmCollider;

    float moveInput;

    public void Move(float newInput)
    {
        moveInput = newInput;
        Debug.Log(moveInput);
    }


    private void Update()
    {
        transform.position += new Vector3(0, moveInput, 0) * Time.deltaTime * MoveSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other == GetComponent<Ball>())
        {
            Ball ball = other.GetComponent<Ball>();
            
            ball.ChangeDir(this.GetComponent<RedirectBall>().GetDir());
        }    
    }
}
