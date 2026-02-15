using UnityEngine;
using UnityEngine.UI;

public class RecordSpin : MonoBehaviour
{
    public Slider volume;
    float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpinMe()
    {
        if (volume.value > volume.minValue)
        {
            speed = 5;
            Vector3 newRotation = transform.eulerAngles;
            newRotation.z += speed * Time.deltaTime;
        }
        else if (volume.value == volume.minValue)
        {
            speed = 0;
        }
    }
}
