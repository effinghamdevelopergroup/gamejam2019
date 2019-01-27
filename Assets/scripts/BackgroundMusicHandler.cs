using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicHandler : MonoBehaviour
{

    public AudioClip goodMusic;
    public AudioClip badMusic;

    private static bool fading= false;

    public AudioSource audioSource;

    private GameController _global;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.spatialBlend = 0;
        audioSource.loop = true;

        audioSource.clip = goodMusic;
        audioSource.Play();
        _global = GameObject.FindGameObjectWithTag("Global").GetComponent<GameController>();

    }

    // Update is called once per frame
    void Update()
    {

        if (_global.Score < 50)
        {
            if (!fading && audioSource.clip != badMusic )
            {
                StartCoroutine(FadeOut(audioSource, .1f, badMusic));
               
            }
        }
        else
        {
            if (!fading && audioSource.clip != goodMusic)
            {
                StartCoroutine(FadeOut(audioSource, .1f, goodMusic));
            }
        }

        // TODO: Manage the clip playing based on the the players negativity
    }



    public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime, AudioClip audio)
    {
        float startVolume = audioSource.volume;
        fading = true;
        while (audioSource.volume > 0)
        {
            audioSource.volume -= Time.deltaTime * FadeTime;

            yield return null;
        }
        audioSource.Stop();
        audioSource.clip = audio;
        audioSource.volume = 1;
        audioSource.Play();
        fading = false;
    }


}


