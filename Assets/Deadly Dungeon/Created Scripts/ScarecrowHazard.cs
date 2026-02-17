using UnityEngine;

public class ScarecrowHazard : MonoBehaviour
{
    public bool huntComplete = false;
    public Vector3 originPosition;
    public ScarecrowSensor sensorScript;
    public Transform player;
    //float timer;
    //float timerMaxValue;
    //float speed = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 newPosition = player;
        //newPosition() += Time.deltaTime * speed; ;
        //transform.position = newPosition;
    }
}
