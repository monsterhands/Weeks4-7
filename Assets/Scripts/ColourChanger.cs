using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    public SpriteRenderer tankBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tankBody = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeColour()
    {
        tankBody.color = Random.ColorHSV();
    }
}
