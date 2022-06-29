using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class music : MonoBehaviour
{
    public AudioClip butterfly;
    public AudioClip rose;
    AudioSource audioSource1;
    AudioSource audioSource2;
    string sceneName;
    

    // Start is called before the first frame update
    void Start()
    {
        //Scene currentScene = SceneManager.GetActiveScene();
        //string sceneName = currentScene.name;

        audioSource1 = GetComponent<AudioSource>();
        audioSource2 = GetComponent<AudioSource>();
        if ((SceneManager.GetActiveScene().name == "TrialScene"))
        {
            PlayMusicTrial();
        }
        else if ((SceneManager.GetActiveScene().name == "GameScene"))
        {
            PlayMusicGame();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if ((SceneManager.GetActiveScene().name == "TrialScene"))
            { 
            if (!audioSource1.isPlaying)
            {
                Debug.Break();
            }
        }
        else if ((SceneManager.GetActiveScene().name == "GameScene"))
        {
            if (!audioSource2.isPlaying)
            {
                Debug.Break();
            }
        }
    }
           

    private void PlayMusicTrial()
    {
        audioSource1.Play();
    }

    private void PlayMusicGame()
    {
        audioSource2.Play();
    }


}
