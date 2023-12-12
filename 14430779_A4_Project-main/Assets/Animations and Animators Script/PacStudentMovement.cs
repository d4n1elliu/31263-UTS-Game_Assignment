using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class PacStudentMovement : MonoBehaviour
{
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        //Set initial spawnpoint of player to (-12.4f, 13.58f, 0f)
        transform.position = new Vector3(-12.4f, 13.58f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
