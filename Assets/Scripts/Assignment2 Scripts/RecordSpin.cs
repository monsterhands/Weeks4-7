using UnityEngine;
using UnityEngine.UI;

public class RecordSpin : MonoBehaviour
{
    //Set public speed variable
    public float speed;
    //Set slider variable
    public Slider volume;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Apply speed and time in deltaTime to z axis to rotate the GO the script is on
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = newRotation;
    }

    //Function that, when called, checks if the value is set to min on the slider
    public void SpinMe()
    {
        if (volume.value == volume.minValue)
        {
            //If yes, set the speed to zero
            speed = 0;
        }
        else if (volume.value > volume.minValue)
        {
            //Otherwise, set speed to -40, clockwise motion
            speed = -40;            
        }
    }
}
