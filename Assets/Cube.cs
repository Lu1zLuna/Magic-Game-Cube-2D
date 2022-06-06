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
        // message if up arrow is pressed.
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MyRigidbody2D.velocity = new Vector2(0f, 10f);
        }

        // message if down arrow is pressed.
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MyRigidbody2D.velocity = new Vector2(0f, -10f);
        }

        // message if right arrow is pressed.
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MyRigidbody2D.velocity = new Vector2(10f, 0f);
        }

        // message if left arrow is pressed.
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MyRigidbody2D.velocity = new Vector2(-10f, 0f);
        }

        // message if space bar is pressed.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MyRigidbody2D.velocity = new Vector2(0f, 10f);
        }
    }
}
