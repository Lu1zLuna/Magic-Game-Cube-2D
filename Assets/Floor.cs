using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string stringFromCube = FindObjectOfType<Cube>().PrintFromOutside(6);
        Debug.Log(stringFromCube);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
