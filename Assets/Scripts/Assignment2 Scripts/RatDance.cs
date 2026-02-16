using UnityEngine;
using UnityEngine.UI;

public class RatDance : MonoBehaviour
{
    //Set slider variable
    public Slider volume;
    //Set animator component variable
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Get a reference to the animator component on the GO
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //If the value of the slider is above minimum, flip bool to true
        if (volume.value > volume.minValue)
        {
            animator.SetBool("IsVolumeUp", true);
        }
        else
        {
            //If not, flip to false
            animator.SetBool("IsVolumeUp", false);
        }
    }
}
