using UnityEngine;
using UnityEngine.UI;

public class RatDance : MonoBehaviour
{
    public float speed;
    public Slider volume;
    float startingY;
    float bob = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startingY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (volume.value > volume.minValue)
        {
            float newPosition = startingY + ((float)Mathf.Sin(Time.deltaTime * speed) * bob);
            transform.position = new Vector3(transform.position.x, newPosition, transform.position.z);
        }        
    }
}
