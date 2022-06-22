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
        if ((other.gameObject.name == "Left Drumstick") || (other.gameObject.name == "Right Drumstick"))
        {
            audioSource.PlayOneShot(Hit, 3f);
            Debug.Log("Note is Triggered.");
            scoreBoard.scoreBoardTotal += 3;
            Debug.Log("Score is: " + scoreBoard.scoreBoardTotal);
        }
    }
}