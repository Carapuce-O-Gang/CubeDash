using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 midPosition;
    public Vector3 rightPosition;
    public Vector3 leftPosition;

    // Start is called before the first frame update
    void Start()
    {
       transform.position = midPosition;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) 
        {
            if (Vector3.Distance(transform.position, midPosition) < 0.1)
            {
                transform.position = rightPosition;
            }
            
            if (Vector3.Distance(transform.position, leftPosition) < 0.1)
            {
                transform.position = midPosition;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Q)) 
        {
            if (Vector3.Distance(transform.position, midPosition) < 0.1)
            {
                transform.position = leftPosition;
            }
            
            if (Vector3.Distance(transform.position, rightPosition) < 0.1)
            {
                transform.position = midPosition;
            }
            
            // if (transform.position == leftPosition)
            // {
            //     transform.position = midPosition;
            // }
        }
        
        // if (Input.GetKey(KeyCode.RightArrow)) 
        // {
        //     transform.position = rightPosition
        // }

        // if (Input.GetKey(KeyCode.LeftArrow)) 
        // {
        //     transform.position = leftPosition
        // }
    }
    
}
