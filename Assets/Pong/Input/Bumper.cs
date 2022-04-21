using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 5f;
    [SerializeField] Transform btmRaycast;
    [SerializeField] Transform topRaycast;
    [SerializeField] BumperLoc bumperLoc;

    [SerializeField] LayerMask BoundaryLayerMask;

    float moveInput;

    public void Move(float newInput)
    {
        moveInput = newInput;
    }

    bool CanMove()
    {
        if (moveInput > 0 && !CanMoveUp())
        {
            return false;
        }
        else if (moveInput < 0 && !CanMoveDown())
        {
            return false;
        }
        return true;
    }

    bool CanMoveUp()
    {
        RaycastHit hit;
        if(Physics.Raycast(topRaycast.position, topRaycast.TransformDirection(Vector3.up), out hit, .3f, BoundaryLayerMask))
        {
            return false;
        }
        return true;
    }

    bool CanMoveDown()
    {
        RaycastHit hit;
        if(Physics.Raycast(btmRaycast.position,btmRaycast.TransformDirection(Vector3.down),out hit, .3f, BoundaryLayerMask))
        {
            return false;
        }
        return true;
    }


    private void Update()
    {
        if(CanMove())
        {
            transform.position += new Vector3(0, moveInput, 0) * Time.deltaTime * MoveSpeed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Ball>())
        {
            collision.gameObject.GetComponent<Ball>().ChangeVelocity(bumperLoc);
        }
    }

}
