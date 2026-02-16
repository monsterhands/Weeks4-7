using UnityEngine;

public class EnemyDespawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
