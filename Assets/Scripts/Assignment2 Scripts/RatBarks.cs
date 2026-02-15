using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RatBarks : MonoBehaviour
{
    public float timer;
    float timerMaxValue = 5f;
    float startTime = 0f;
    public GameObject[] barks;
    int randomBark;
    public Slider volume;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = startTime;
    }

    // Update is called once per frame
    void Update()
    {   
        if (volume.value > volume.minValue)
        {            
            if (timer >= timerMaxValue)
            {
                randomBark = Random.Range(0, barks.Length);
                barks[randomBark].SetActive(true);
                timer = startTime;
            } else
            {
                timer += Time.deltaTime;
            }

        }        
    }
}
