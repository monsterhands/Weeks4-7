using UnityEngine;
using UnityEngine.InputSystem;

public class Spawn : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        //{
        //    Vector2 spawnPos = Random.insideUnitCircle * 5;
        //    Instantiate(ObjectToSpawn, spawnPos, Quaternion.identity);
        //}
    }

    public void SpawnObject()
    {
        Vector2 spawnPos = Random.insideUnitCircle * 5;
        Instantiate(ObjectToSpawn, spawnPos, Quaternion.identity);

    }
}
