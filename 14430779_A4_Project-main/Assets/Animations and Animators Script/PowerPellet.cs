using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPellet : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        //Setting initial spawnpoint to (15.55f, 9.5f, 0f)
        transform.position = new Vector3(15.55f, 9.5f, 0f);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
