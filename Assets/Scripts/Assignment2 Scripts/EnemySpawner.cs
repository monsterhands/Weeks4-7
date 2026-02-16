using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float timerValue = 0;
    public float timerMaxValue = 15;
    public GameObject enemyPrefab;
    public GameObject spawnedEnemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerValue += Time.deltaTime;

        if (timerValue > timerMaxValue)
        {
            spawnedEnemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            timerValue = 0;            
        }
    }
}
