using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightDSMovement : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveDrumStick();
    }


    private void ActivateMovement()
    {
        animator.SetTrigger("Right Hit");
    }

    private void DisActivateMovement()
    {
        animator.SetTrigger("Right Idle");
    }

    private void MoveDrumStick()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ActivateMovement();

            variables.rightTries += 1;
            Debug.Log("Right tries = " + variables.rightTries);

            variables.totalTries += 1;
            Debug.Log("Total tries = " + variables.totalTries);
        }
        // Call DisActivateMovement method
        DisActivateMovement();

    }
}

