using UnityEngine;

public class BarkTimer : MonoBehaviour
{
    public GameObject currentObject;
    private float timerValue = 0f;
    private float timerMaxValue = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentObject.activeInHierarchy)
        {
            timerValue += Time.deltaTime;
        }

        if(timerValue >= timerMaxValue)
        {            
            currentObject.SetActive(false);
            timerValue = 0;
        }

    }
}
