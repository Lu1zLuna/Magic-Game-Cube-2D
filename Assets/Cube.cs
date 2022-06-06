using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numberOfTimes = 2;
        string usedKey = "ESC";
        float seconds = 999.99f;

        Debug.Log("Press left arrow key" + numberOfTimes + " to go left.");
        Debug.LogWarning("WARNING: Pressing " + usedKey + " key will stop the program.");
        Debug.LogError("ERROR: You took " + seconds + " seconds to press left arrow.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
