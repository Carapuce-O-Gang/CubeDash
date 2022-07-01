using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 midPosition;
    public Vector3 rightPosition;
    public Vector3 leftPosition;
    public int movement = 3;

    // Start is called before the first frame update
    void Start()
    {
       transform.position = midPosition;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) 
        {
            if (Vector3.Distance(transform.position, midPosition) < 0.1)
            {
                float getIndented = transform.position.x + movement;
                Vector3 newRightPosition = new Vector3(getIndented, transform.position.y, transform.position.z);
                transform.position = newRightPosition;
            }
            else if (Vector3.Distance(transform.position, leftPosition) < 0.1) {
                float getIndented = transform.position.x + movement;
                Vector3 newMidPosition = new Vector3(getIndented, transform.position.y, transform.position.z);
                transform.position = newMidPosition;
            }
            else {
                transform.position = transform.position;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.Q)) 
        {
            if (Vector3.Distance(transform.position, midPosition) < 0.1)
            {
                float getIndented = transform.position.x - movement;
                Vector3 newLeftPosition = new Vector3(getIndented, transform.position.y, transform.position.z);
                transform.position = newLeftPosition;
            }
            else if (Vector3.Distance(transform.position, rightPosition) < 0.1) {
                float getIndented = transform.position.x - movement;
                Vector3 newMidPosition = new Vector3(getIndented, transform.position.y, transform.position.z);
                transform.position = newMidPosition;                
            }
            else {
                transform.position = transform.position;
            }
        }
    }
    
}
