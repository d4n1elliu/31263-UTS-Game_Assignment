using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja4 : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        // Set the initial position to (3.49f, 0.54f, 0f) when the game starts
        transform.position = new Vector3(3.49f, 0.54f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
