using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class HighlightInfo : MonoBehaviour
{
    public SpriteRenderer sr;
    public GameObject fact;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it over the game object?
        if (sr.bounds.Contains(mousePos) == true)
        {
            //Y: toggle fact on
            fact.SetActive(true);
        }
        else if (!sr.bounds.Contains(mousePos))
        {
            //N: toggle fact off
            fact.SetActive(false);
        }
    }

}
