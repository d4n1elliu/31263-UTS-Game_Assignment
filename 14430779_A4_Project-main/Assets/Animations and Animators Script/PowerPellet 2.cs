using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPellet2 : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //Setting initial spawnpoint to (-12.49f, 9.51f, 0)
        transform.position = new Vector3(-12.49f, 9.51f, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
