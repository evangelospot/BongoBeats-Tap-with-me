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
        // Receive LeftArrow as Input
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        { 
            // Call ActivateMovement method
            ActivateMovement();

            variables.leftTries += 1;
            Debug.Log("Left tries = " + variables.leftTries);

            variables.totalTries += 1;
            Debug.Log("Total tries = " + variables.totalTries);
        }
        // Call DisActivateMovement method
        DisActivateMovement();
    }

}


