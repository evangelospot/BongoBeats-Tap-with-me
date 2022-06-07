using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteColRight : MonoBehaviour
{
    [SerializeField] AudioClip Hit;
    [SerializeField] AudioClip Miss;
    [SerializeField] AudioClip drum;
    AudioSource audioSource;
    public bool IsCollidingRightNote;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        IsCollidingRightNote = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "notecool_right")
        {
            IsCollidingRightNote = true;
            Debug.Log("Egine deksi collide, paikse Hit");
            audioSource.PlayOneShot(drum);
            audioSource.PlayOneShot(Hit, 3f);
        }
        else if (collision.gameObject.name == "Drum Right")
        {
            if (IsCollidingRightNote == true)
            {
                Debug.Log("Mhn paikseis deksi misshit");
                IsCollidingRightNote = false;
            }
            else
            {
                Debug.Log("Paikse dkesi misshit");
                audioSource.PlayOneShot(drum);

                audioSource.PlayOneShot(Miss, 3f);
            }


        }
    }
}
