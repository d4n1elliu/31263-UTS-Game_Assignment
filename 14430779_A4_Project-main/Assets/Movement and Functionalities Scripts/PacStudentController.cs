using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
public class PacStudentController : MonoBehaviour
{
    private Animator animator;

    //Initial movement speed for pacman
    public float moveSpeed = 5f;

    //Plays the pellet eating sound
    public AudioClip pelletEatingSound;

    //Plays the moving pacman sound
    public AudioClip movingSound;

    //Direction where pacman can move
    public enum Directions { Up, Down, Left, Right };

    //Duration of the movement tween
    public float moveDur = 0.5f;

    private Tweener tweener;

    //Stoes the current input
    private Vector3 currentInput = Vector3.zero;

    //Stores the last input
    private Vector3 lastInput = Vector3.zero;

    //Default movement direction
    public Directions initialMoveDir = Directions.Right;

    //Set the pac man to not move
    public bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        //Set initial spawnpoint of player to (-12.4f, 13.58f, 0f)
        transform.position = new Vector3(-12.4f, 13.58f, 0f);

        //Initialising other components and variables 
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        //MovementInput();
    }

    /*private void MovementInput()
    {
        //Check for player input
        float horiInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");

        Vector3 startPos = transform.position;
        Vector3 endPos = startPos;

        //Check for horizontal movement (A or D Key)
        if (horiInput != 0f)
        {
            lastInput = new Vector3(horiInput, 0f, 0f);
        }

        //Check for vertical movement (W or S Key)
        else if (vertInput != 0f)
        {
            lastInput = new Vector3(0f, vertInput, 0f);
        }

        endPos = startPos + lastInput;

        if (IsPositionValid(endPos))
        {
            currentInput = lastInput;

            tweener.AddTween(transform, startPos, endPos, moveDur); 
        }
        else
        {
            //If last input direction is blocked, attempts to move in a current input direction
            endPos = startPos + currentInput;
            if (IsPositionValid(endPos))
            {
                //Use tweener to move pacStudent in a straight line
                tweener.AddTween(transform, startPos, endPos, moveDur);
            }
        }
    }

    private bool IsPositionValid(Vector3 position)
    {
        return true;
    }*/
}
