using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteColLeft : MonoBehaviour
{
    [SerializeField] AudioClip Hit;
    [SerializeField] AudioClip Miss;
    [SerializeField] AudioClip drum;
    AudioSource audioSource;
    public bool IsCollidingLeftNote;
    // Start is called before the first frame update

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        IsCollidingLeftNote = false;
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "notecool_left")
        {
            IsCollidingLeftNote = true;
            Debug.Log("Egine aristero collide, paikse Hit");
            audioSource.PlayOneShot(drum);
            audioSource.PlayOneShot(Hit, 3f);
        }
        else if (collision.gameObject.name == "Drum Left")
        {
            if (IsCollidingLeftNote == true)
            {
                Debug.Log("Mhn paikseis aristero misshit");
                IsCollidingLeftNote = false;
            }
            else
            {
                Debug.Log("Paikse aristero misshit");
                audioSource.PlayOneShot(drum);

                audioSource.PlayOneShot(Miss, 3f);
            }
         

        }
    }
}
