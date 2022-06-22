using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigNotesDS : MonoBehaviour
{
    public AudioClip Hit;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Left Drumstick")
        {
            audioSource.PlayOneShot(Hit, 3f);
            Debug.Log("Note is Triggered.");

            variables.hitLeftNotes += 1;
            Debug.Log("Left Score is: " + variables.hitLeftNotes);

            variables.totalScore += 3;
            Debug.Log("Total Score is: " + variables.totalScore);
        }
        else if (other.gameObject.name == "Right Drumstick")
        {
            audioSource.PlayOneShot(Hit, 3f);
            Debug.Log("Note is Triggered.");

            variables.hitRightNotes += 1;
            Debug.Log("Right Score is: " + variables.hitRightNotes);

            variables.totalScore += 3;
            Debug.Log("Total Score is: " + variables.totalScore);
        }
    }
}