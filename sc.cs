using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector3(4, 5, 6);
        //assign the new pos = (asign) new position
        transform.position = startPosition;
        //transform.rotation 
        //transform.scale
    }

    // Update is called once per frame
    void Update()
    {
        //if space key pressed down -> print message
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space Key");
        }
        //if e key held down -> print message        
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Holding E");
        }
        //-----------------------------------------------        
        //if f key is lifted up - print message
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Debug.Log("Holding UpArrow");
        }
        //if f key is lifted up - print message
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Holding DownArrow");
        }
        
        //-----------------------------------------------
    }
}
