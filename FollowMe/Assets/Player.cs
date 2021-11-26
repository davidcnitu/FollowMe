using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 10;
    void Update()
    {
        //First, let's ask the user for a direction in which the player (cube) should move.
        //On the horizinatal (x axis) an input of left is -1 and an input of right is +1
        //On the vertical (z axis) an input of down is -1 and an input of up is +1)
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        //We can normalize the input vector to obtain a direction vector that has a magnitude of 1
        Vector3 direction = input.normalized;

        //Velocity is defined by both direction and speed and it refers to the direction and distance an object is moving in one unit of time
        Vector3 velocity = direction * speed;

        //To calculate how much an object is moving we multiply velocity but the amount of time passed since last frame
        Vector3 moveAmmount = velocity * Time.deltaTime;

        //Based on the move ammount we can update the transform of our object to move it to a new location
        transform.Translate(moveAmmount);
    }
}
