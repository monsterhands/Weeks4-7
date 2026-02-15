using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class TurntableController : MonoBehaviour
{
    public GameObject musicPlayer;
    public AudioSource musicAudio;
    public List<AudioClip> tracks;
    public int trackNumber;
    public Slider volume;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        volume.value = volume.maxValue;
        trackNumber = 0;
        musicAudio.clip = tracks[trackNumber];
        musicAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayThatFunkyMusic ()
    {
        if (volume.value > volume.minValue)
        {
            musicAudio.clip = tracks[trackNumber];
            musicAudio.UnPause();
        } else if (volume.value == volume.minValue)
        {
            musicAudio.clip = tracks[trackNumber];
            musicAudio.Pause();
        }
    }

    public void ChangeThatFunkyMusic()
    {
        if (trackNumber >= (tracks.Count -1))
        {
            trackNumber = 0;
            musicAudio.clip = tracks[trackNumber];
            musicAudio.Play();
        } else if (trackNumber <= (tracks.Count -1))
        {
            trackNumber++;
            musicAudio.clip = tracks[trackNumber];
            musicAudio.Play();
        }
    }
}
