using UnityEngine;
using UnityEngine.UI;

public class PartyDetection : MonoBehaviour
{
    public bool musicIsDetected = false;
    public Transform detectionTrigger;
    public Slider volume;
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
        if(musicIsDetected == true)
        {
            volume.value = 0;
            unpluggedOverlay.SetActive(gameObject.activeInHierarchy);
            restartButton.SetActive(gameObject.activeInHierarchy);
            musicSlider.SetActive(!gameObject.activeInHierarchy);
            trackButton.SetActive(!gameObject.activeInHierarchy);
        }
    }

    public void RestartEnabled()
    {
        musicIsDetected = false;
        volume.value = volume.maxValue;
        unpluggedOverlay.SetActive(!gameObject.activeInHierarchy);
        restartButton.SetActive(!gameObject.activeInHierarchy);
        musicSlider.SetActive(gameObject.activeInHierarchy);
        trackButton.SetActive(gameObject.activeInHierarchy);
    }
}
