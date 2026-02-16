using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    public float timerValue = 0;
    public float timerMaxValue = 15;
    public GameObject enemyPrefab;
    public GameObject spawnedEnemy;
    public GameObject enemyTrigger;
    public GameObject ratAlert;
    public PartyDetection detectionScript;
    public EnemyPath pathScript;
    public Slider volume;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerValue += Time.deltaTime;
        detectionScript = enemyTrigger.GetComponent<PartyDetection>();

        if (timerValue > timerMaxValue && detectionScript.musicIsDetected == false)
        {
            spawnedEnemy = Instantiate(enemyPrefab, transform);
            ratAlert.SetActive(true);
            timerValue = 0;            
        }
        if (spawnedEnemy != null)
        {
            pathScript = spawnedEnemy.GetComponent<EnemyPath>();
            Vector3 enemyPosition = spawnedEnemy.transform.position;
            float distance = Vector2.Distance(enemyPosition, detectionScript.detectionTrigger.position);
            if (distance < 2 && volume.value > 1)
            {
                pathScript.speed = 0;
                detectionScript.musicIsDetected = true;
            } else
            {
                Destroy(spawnedEnemy, 6);
            }

        }
    }
    public void DestroyOnRestart()
    {
        Destroy(spawnedEnemy);
    }
}
