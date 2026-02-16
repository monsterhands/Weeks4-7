using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class TurntableController : MonoBehaviour
{
    //Set variables for child object music player and its audio source
    public GameObject musicPlayer;
    public AudioSource musicAudio;
    //Set variable for list of audio clips
    public List<AudioClip> tracks;
    //Set integer variable for audio clip number
    public int trackNumber;
    //Set slider variable
    public Slider volume;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //At beginning of play, set the track to first one and max the volume,
        //then play that specific one
        volume.value = volume.maxValue;
        trackNumber = 0;
        musicAudio.clip = tracks[trackNumber];
        musicAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //This function checks the value set by the slider and if above minimum value, tracks play
    public void PlayThatFunkyMusic ()
    {
        if (volume.value > volume.minValue)
        {
            musicAudio.clip = tracks[trackNumber];
            musicAudio.UnPause();
        } else if (volume.value == volume.minValue)
        {
            //If at minimum value, pause the playback
            musicAudio.clip = tracks[trackNumber];
            musicAudio.Pause();
        }

        //Values adjust the volume of audio
        if (volume.value == 3)
        {
            musicAudio.volume = 0.75f;
        } else if (volume.value == 2)
        {
            musicAudio.volume = 0.5f;
        }
        else if (volume.value == 1)
        {
            musicAudio.volume = 0.25f;
        } else
        {
            musicAudio.volume = 1;
        }
    }

    //This function cycles through the list of clips sequentially
    public void ChangeThatFunkyMusic()
    {
        if (trackNumber >= (tracks.Count -1))
        {
            //When it reaches the end of the list, cycles back to the first clip
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
