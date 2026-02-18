using UnityEngine;

public class BarkTimer : MonoBehaviour
{
    //Set public variable for the current object script is attached to
    public GameObject currentObject;
    //Set private floats for time tracker and desired max timer value
    private float timerValue = 0f;
    private float timerMaxValue = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the object the script is attached to is active/enabled,
        //time value will advance with deltaTime
        if (currentObject.activeInHierarchy)
        {
            timerValue += Time.deltaTime;
        }
        //If the value reaches or is greater than max timer value,
        //deactivate object in hierarchy and reset timer to zero
        if (timerValue >= timerMaxValue)
        {            
            currentObject.SetActive(false);
            timerValue = 0;
        }

    }
}
