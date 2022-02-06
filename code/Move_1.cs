using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_1 : MonoBehaviour
{
    public float speed = 0f;
    public float speed_1 = 0f;
    public AudioClip Accele_1;
    void Update()
    {
        transform.Translate(speed_1, 0, 0);
        if (Input.GetMouseButton(0))
        {
            transform.Translate(0, -speed, 0);
        }
        else if(Input.GetMouseButton(1))
        {
            transform.Translate(0, speed, 0);
        }
        else if(Input.GetKey("KeyCod.space"))
        {
            transform.Translate(0.05f, 0, 0);
            
        }
    }
}
