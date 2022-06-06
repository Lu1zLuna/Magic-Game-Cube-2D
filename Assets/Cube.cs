using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Rigidbody2D MyRigidbody2D;

    // int numberOfTimes = 2;
    // string usedKey = "ESC";
    // float seconds = 999.99f;
    // Start is called before the first frame update

    void Start()
    {
        // Debug.Log("Press left arrow key" + numberOfTimes + " to go left.");
        // Debug.LogWarning("WARNING: Pressing " + usedKey + " key will stop the program.");
        // Debug.LogError("ERROR: You took " + seconds + " seconds to press left arrow.");
    }

    // Update is called once per frame
    void Update()
    {
    //movement controls:
        // moves up if up arrow is pressed.
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MyRigidbody2D.velocity = new Vector2(0f, 10f);
        }

        // moves down if down arrow is pressed.
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MyRigidbody2D.velocity = new Vector2(0f, -10f);
        }

        // moves right if right arrow is pressed.
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MyRigidbody2D.velocity = new Vector2(10f, 0f);
        }

        // moves left if left arrow is pressed.
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MyRigidbody2D.velocity = new Vector2(-10f, 0f);
        }

        // moves up if space bar is pressed.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MyRigidbody2D.velocity = new Vector2(0f, 10f);
        }
    //end of movement controls.

    //checks if the cube is out of borders:
        if (transform.position.x > 9.42f)
        {
            Debug.LogWarning("You are out of borders to the Right side!!");
        }
        else if (transform.position.x < -9.42f)
        {
            Debug.LogWarning("You are out of borders to the Left side!!");
        }
        else if (transform.position.y > 5.5f)
        {
            Debug.LogWarning("You are out of borders to the Upper side!!");
        }
    }
}
