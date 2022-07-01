using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int axis;
    public float speedRotation = 10f;

    private float movement = 1.0f;
    private float Xmax;
    private float Xmin;

    // Start is called before the first frame update
    void Start()
    {
        this.Xmax = this.transform.position.x + this.axis-1;
        this.Xmin = this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && this.transform.position.x > this.Xmin) 
        {
            if (this.transform.position.x > this.movement){

                this.transform.position = new Vector3(
                    this.transform.position.x - 0.1f,
                    this.transform.position.y,
                    this.transform.position.z
                );
            }
        }

        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.Q)) && this.transform.position.x < this.Xmax) 
        {
            this.transform.position = new Vector3(
                this.transform.position.x + this.movement,
                this.transform.position.y,
                this.transform.position.z
            );
        }
    }
    
}
