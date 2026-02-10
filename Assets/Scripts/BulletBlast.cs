using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletBlast : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip blastSFX;
    public float speed = 5;
    //public List<Sprite> Bullets;
    //public int randomNumber;
    //public SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource.clip = blastSFX;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;

    }
    //public void PickARandomSprite()
    //{
    //    randomNumber = Random.Range(0, Bullets.Count);
    //    spriteRenderer.sprite = Bullets[randomNumber];
    //}
}
