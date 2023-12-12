using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPellet4 : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        //Setting initial spawnpoint to (-12.48f, -8.48f, 0f)
        transform.position = new Vector3(-12.48f, -8.48f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
