using UnityEngine;
using UnityEngine.UI;

public class RecordSpin : MonoBehaviour
{
    //public Slider volume;
    public float speed;
    public Slider volume;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = newRotation;
    }

    public void SpinMe()
    {
        if (volume.value == volume.minValue)
        {
            speed = 0;
        }
        else if (volume.value > volume.minValue)
        {
            speed = -40;            
        }
    }
}
