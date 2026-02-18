using UnityEngine;
using UnityEngine.UI;

public class PartyDetection : MonoBehaviour
{
    //Set public Boolean for whether music is detected by the enemy
    public bool musicIsDetected = false;
    //Set transform variable for the game object this script is on
    public Transform detectionTrigger;
    //Set slider variable
    public Slider volume;
    //Set gameobject variables for fail-state overlay GO, restart button, music slider, and track button
    public GameObject unpluggedOverlay;
    public GameObject restartButton;
    public GameObject musicSlider;
    public GameObject trackButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If music is being detected at the overlap of the clone and enemy trigger point,
        //turn that music off!
        if (musicIsDetected == true)
        {
            volume.value = 0;
            //Enable overlay and restart and disable slider and track button
            unpluggedOverlay.SetActive(gameObject.activeInHierarchy);
            restartButton.SetActive(gameObject.activeInHierarchy);
            musicSlider.SetActive(!gameObject.activeInHierarchy);
            trackButton.SetActive(!gameObject.activeInHierarchy);
        }
    }

    public void RestartEnabled()
    {
        //If the function RestartEnabled is called, bool is reset to false,
        //volume is set to blast
        musicIsDetected = false;
        volume.value = volume.maxValue;
        //Overlay and restart are disabled while slider and track button are enabled
        unpluggedOverlay.SetActive(!gameObject.activeInHierarchy);
        restartButton.SetActive(!gameObject.activeInHierarchy);
        musicSlider.SetActive(gameObject.activeInHierarchy);
        trackButton.SetActive(gameObject.activeInHierarchy);
    }
}
