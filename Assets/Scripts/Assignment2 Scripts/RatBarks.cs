using UnityEngine;
using UnityEngine.UI;

public class RatBarks : MonoBehaviour
{
    //Use UnityEngine.UI
    //Set variables for tracking time passed and timer max value
    public float timerValue = 0;
    private float timerMaxValue = 5f;
    //Set public variable for array of barks
    public GameObject[] barks;
    //Set integer for random value in bark array
    private int randomBark;
    //Set slider variable
    public Slider volume;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If slider value is greater than the minimum value of the referenced slider,
        //carry out the condition
        if (volume.value > volume.minValue)
        {
            //Let time be counted using deltaTime until the timer value is equal to or greater than max value,
            //then set the integer to a random value in the array and activate that gameobject
            if (timerValue >= timerMaxValue)
            {
                randomBark = Random.Range(0, barks.Length);
                barks[randomBark].SetActive(true);
                //Reset the timer to zero
                timerValue = 0;
            } else
            {
                timerValue += Time.deltaTime;
            }

        }        
    }
}
