using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int axis;
    public float speedRotation = 10f;

    private float speed = 0.05f;
    private float speedLeftRight = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        
        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))) 
        {
            this.transform.Translate(Vector3.left * speed);
            this.transform.Translate(Vector3.forward * -1 * speedLeftRight/4);
        }
        

        else if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.Q))) 
        {
            this.transform.Translate(Vector3.right *speed);
            this.transform.Translate(Vector3.forward * -1 * speedLeftRight/4);
            
        }
        
    }
    
}
