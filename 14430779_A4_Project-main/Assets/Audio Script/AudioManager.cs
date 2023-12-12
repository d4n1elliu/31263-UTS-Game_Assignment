using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip IntroMusic;
    public AudioClip BackgroundMusic;
    // Start is called before the first frame update
    void Start()
    {
        //Assigning audios sources to component
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = IntroMusic;

        //Playing intro music when the user clicks on the play button
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying && audioSource.clip == IntroMusic)
        {
            //Switching to Background Music
            audioSource.clip = BackgroundMusic;

            //Playing background music
            audioSource.Play();
        }
    }
}
