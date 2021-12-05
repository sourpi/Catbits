using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alive_to_dead : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.E))
       {
      animator.SetFloat("PressKey" , 1);
       }
    }
}

