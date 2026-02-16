using UnityEngine;
using UnityEngine.UI;

public class EnemyPath : MonoBehaviour
{
    //Set variable for audio source component
    public AudioSource soundEffect;
    //Set public float variable for speed
    public float speed = 8;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //In start, begin playing the sound effect attached to audio source
        soundEffect.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Add the direction of rightward to the transform.position,
        //adjusted by speed as deltaTime measures increasing time
        transform.position += transform.right * speed * Time.deltaTime;        
    }

}
