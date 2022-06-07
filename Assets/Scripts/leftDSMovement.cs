using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftDSMovement : MonoBehaviour
{
    Animator animator;
  //  AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Call MoveDrumStick method
        MoveDrumStick();
    }

    // Activate Hit Animator Component 
    private void ActivateMovement()
    {
        animator.SetTrigger("Left Hit");
    }


    // Activate Idle Animator Component
    private void DisActivateMovement()
    {
        animator.SetTrigger("Left Idle");
    }

    private void MoveDrumStick()
    {
        // Receive Arrows as Input
        if (Input.GetMouseButtonDown(0))
        {

            // Call ActivateMovement method
            ActivateMovement();
        }
        // Call DisActivateMovement method
        DisActivateMovement();
    }

}


