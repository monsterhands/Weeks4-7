using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ScarecrowSensor : MonoBehaviour
{
    public Transform player;
    public bool isInHazard = false;
    public bool chase = false;
    public UnityEvent OnEnterHazard;
    public UnityEvent OnExitHazard;
    public GameObject scarecrow;
    public GameObject playerObject;
    public float threshold = 0;
    public ScarecrowHazard hazardScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);
        hazardScript = scarecrow.GetComponent<ScarecrowHazard>();

        //is the player inside the hazard sprite renderer?
        if (distance < threshold && hazardScript.huntComplete == false)
        {
            if (isInHazard == true)
            {
                //we're still in the hazard

            }
            else
            {
                //just entered the hazard
                //Y: player has tripped the sensor
                isInHazard = true;
                Debug.Log("entered the hazard");
                OnEnterHazard.Invoke();
            }


        }
        else
        {
            if (isInHazard == true)
            {
                //we just left the hazard
                //N: player has not tripped the sensor
                isInHazard = false;
                Debug.Log("exited the hazard");
                OnExitHazard.Invoke();
            }
            else
            {
                //we're still not in the hazard
            }
        }
    }
}
