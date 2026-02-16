using UnityEngine;
using UnityEngine.UI;

public class RatDance : MonoBehaviour
{
    public Slider volume;
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (volume.value > volume.minValue)
        {
            animator.SetBool("IsVolumeUp", true);
        }
        else
        {
            animator.SetBool("IsVolumeUp", false);
        }
    }
}
