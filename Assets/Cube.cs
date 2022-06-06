using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Press left arrow key to go left.");
        Debug.LogWarning("WARNING: Pressing another arrow key will stop the program.");
        Debug.LogError("ERROR: You have pressed another arrow key different from left arrow.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
