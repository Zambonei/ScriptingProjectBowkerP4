using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // i want the x position of my game object to appear on the console
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        // i want to know what my y location is at all times
        Debug.Log (transform.position.y);
        // i want the console to say somehting if my object is below 5
        if (transform.position.y <= 5f) 
        {
            Debug.Log("i am about to hit the ground");
        }
    }
}
