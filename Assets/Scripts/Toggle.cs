using UnityEngine;

public class Toggle : MonoBehaviour
{
    public void ToggleShape()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);

        //long way to do the same thing
        //if game object is inactive (turned off): call SetActive and pass true
        //if(!gameObject.activeInHierarchy)
        //{
        //    gameObject.SetActive(true);
        //} 
        //else if(gameObject.activeInHierarchy == true)
        //{
        //    //otherwise (the game object is active): call SetActive and pass false
        //    gameObject.SetActive(false);
        //}

    }
}
