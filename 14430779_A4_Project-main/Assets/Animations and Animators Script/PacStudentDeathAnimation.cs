using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentDeathAnimation : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();


        transform.position = new Vector3(-12.4f, 13.58f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //Press the K button on keyboard to stop the death animation
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("IsDead");
        }
        //Press the L button on keyboard to stop the death animation
        if (Input.GetKeyDown(KeyCode.L))
        {
            animator.SetTrigger("Idle");
        }*/
    }
}
