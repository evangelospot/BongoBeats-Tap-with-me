using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicTrial : MonoBehaviour
{
    public AudioClip butterfly;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {

            SceneManager.LoadScene("EmptyScene");
        }
    }

    private void PlayMusic()
    {
        audioSource.Play();
    }


}
