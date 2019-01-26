using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicHandler : MonoBehaviour
{
    AudioSource goodAudioSource;
    AudioSource badAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        goodAudioSource = GetComponent<AudioSource>();
        goodAudioSource.spatialBlend = 0;
        goodAudioSource.loop = true;

        badAudioSource = GetComponent<AudioSource>();
        badAudioSource.spatialBlend = 0;
        badAudioSource.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Manage the clip playing based on the the players negativity
    }
}
