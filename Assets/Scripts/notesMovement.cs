using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notesMovement : MonoBehaviour
{
    [SerializeField] Transform CubeTarget;
    [SerializeField] float speed;
    [SerializeField] float distanceTimeMovement;



    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time >= distanceTimeMovement)
        {
            Vector3 a = transform.position;
            Vector3 b = CubeTarget.position;
            transform.position = Vector3.MoveTowards(a, b, speed);
        }
        
    }
}