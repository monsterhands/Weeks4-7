using System.Drawing;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal.Internal;

public class TankController : MonoBehaviour
{
    public float speed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //if keyboard input left arrow or right arrow made, change transform position to reflect
        Vector2 newPos = transform.position;

        if (Keyboard.current.rightArrowKey.isPressed == true)
        {
            newPos.x += speed * Time.deltaTime;
            transform.position = newPos;
        } else if (Keyboard.current.leftArrowKey.isPressed == true)
        {
            newPos.x += -speed * Time.deltaTime;
            transform.position = newPos;
        }
    }

    public void SetSpeed ()
    {
        speed = Random.Range(1f, 5f);
    }

}
