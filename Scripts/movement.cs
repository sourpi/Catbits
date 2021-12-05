
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{   [SerializeField]float speed; //serialize to make it directly editable from unity 
    Rigidbody2D body;
     void Awake() //every time the script is loaded
		{ body = GetComponent<Rigidbody2D>(); }

    // Update is called once per frame
    void Update()
    {  
        body.velocity = new UnityEngine.Vector2(Input.GetAxis("Horizontal")*speed, body.velocity.y);
        
    }

}
