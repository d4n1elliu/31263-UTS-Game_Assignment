using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja3 : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        // Set the initial position to (2.61f, 0.55f, 0f) when the game starts
        transform.position = new Vector3(2.61f, 0.55f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
