using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixCode : MonoBehaviour
{
    [SerializeField]
    protected Rigidbody2D body;

    [SerializeField]
    protected KeyCode left = KeyCode.A;

    [SerializeField]
    protected KeyCode right = KeyCode.D;

    [SerializeField]
    protected float speed;

    //Edited update to fixedupdate()
    //FixedUpdate() runs at a fixed interval, making sure that the physics calculations are consistent.
    // it is better update() because update runs per frame, which results in
    // inconsistent physics calculations
    private void FixedUpdate()
    {
        // To move the character use body.velocity 
        // right or left at a constant speed
        //the other mistake is that they wrote vector3 instead of vector2 
        if (Input.GetKey(left))
        {
            body.velocity = Vector2.left * speed;
        }
        else if (Input.GetKey(right))
        {
            body.velocity = Vector2.right * speed;
        }
        else
        {
            // Stop the character if no input is detected
            body.velocity = Vector2.zero;
        }//i decided to add the else if statements, i found that it worked better, so i left it.
     
    }
}

