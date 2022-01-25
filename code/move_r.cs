using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_r : MonoBehaviour
{
    public float speed = 5.0f; //public °ø°³
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed / 20.0f , 0, 20.0f);
    }
}
