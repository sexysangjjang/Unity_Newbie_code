using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot : MonoBehaviour
{
    public int rot_a = 0;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            this.transform.Rotate(0, 0, 45);
        }
       
        if (Input.GetKey("right"))
        {
            transform.Translate(speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
           transform.Translate(0, speed, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
           transform.Translate(0, -speed, 0);
        }
        
    }
}
