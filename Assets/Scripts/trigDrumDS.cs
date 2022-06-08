using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigDrumDS : MonoBehaviour
{
    public AudioClip drum;
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
            audioSource.PlayOneShot(drum);
            Debug.Log("Drum is Triggered");
        }
        
    }
}