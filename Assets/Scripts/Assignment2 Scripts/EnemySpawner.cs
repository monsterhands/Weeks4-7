using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    //Set variables for timer value and max value
    public float timerValue = 0;
    private float timerMaxValue = 15;
    //Set variables for the prefab, the spawned GO clone, the clone’s Trigger Point
    public GameObject enemyPrefab;
    public GameObject spawnedEnemy;
    public GameObject enemyTrigger;
    public GameObject ratAlert;
    //Set variable for grabbing other scripts in the scene
    public PartyDetection detectionScript;
    public EnemyPath pathScript;
    //Set slider variable
    public Slider volume;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Increase the timer value by deltaTime
        timerValue += Time.deltaTime;
        //Get the component script Party Detection from the GO attached (Enemy Trigger Point)
        detectionScript = enemyTrigger.GetComponent<PartyDetection>();

        //If the timer exceeds the max value AND the bool on Party Detection detecting the music volume is set to false,
        //instantiate a clone of the Enemy prefab
        if (timerValue > timerMaxValue && detectionScript.musicIsDetected == false)
        {
            spawnedEnemy = Instantiate(enemyPrefab, transform);
            //Enable the rat alert text UI
            ratAlert.SetActive(true);
            //Reset timer
            timerValue = 0;            
        }

        //If there is a clone of Enemy prefab in scene,
        //get the component script Enemy Path from the clone
        if (spawnedEnemy != null)
        {
            pathScript = spawnedEnemy.GetComponent<EnemyPath>();
            //Get the location of the clone in a variable
            //Set a variable containing the distance between the enemy clone position
            //and the position of the object the detection script is on
            Vector3 enemyPosition = spawnedEnemy.transform.position;
            float distance = Vector2.Distance(enemyPosition, detectionScript.detectionTrigger.position);
            //If the distance is less than a small value AND the slider value referenced is greater than 1,
            //set speed variable on clone to zero and flip bool on Party Detection to true
            if (distance < 2 && volume.value > 1)
            {
                pathScript.speed = 0;
                detectionScript.musicIsDetected = true;
            } else
            {
                //Else, destroy the clone after 6 seconds
                Destroy(spawnedEnemy, 6);
            }

        }
    }

    //Function to destroy the clone called by the restart button
    public void DestroyOnRestart()
    {
        Destroy(spawnedEnemy);
    }
}
