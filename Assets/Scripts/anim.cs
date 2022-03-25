using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{

    Animator animator;
    float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
      
        float vertical = Input.GetAxis("Vertical") * 10f;
        bool moveForward = Input.GetKey(KeyCode.UpArrow);
        bool moveLeft = Input.GetKey(KeyCode.LeftArrow);
        bool moveRight = Input.GetKey(KeyCode.RightArrow);
        bool moveBackward = Input.GetKey(KeyCode.DownArrow);
        bool run = Input.GetKey(KeyCode.LeftShift);
        Debug.Log(vertical);

        /*walk*/
        if (moveForward && vertical > 0.1f && !run)
        {
            animator.SetBool("move", true);
            animator.SetFloat("speed", 5f);
            animator.SetFloat("rotation", 0f);
        }
        else if (moveForward && vertical > 6f && run)
        {
            animator.SetBool("move", true);
            animator.SetFloat("speed", 10f);
            animator.SetFloat("rotation", 0f);
        }
        else if (moveBackward && vertical < 0 && !run)
        {
            animator.SetBool("move", true);
            animator.SetFloat("speed", -5f);
            animator.SetFloat("rotation", 0f);
        }
        else if (moveBackward && vertical < -5f && run)
        {
            animator.SetBool("move", true);
            animator.SetFloat("speed", -10f);
            animator.SetFloat("rotation", 0f);
        }
        else if (moveLeft && horizontal < 0)
        {
            animator.SetBool("move", true);
            animator.SetFloat("speed", 0f);
            animator.SetFloat("rotation", -.5f);
        }
        else if (moveRight && horizontal > 0)
        {
            animator.SetBool("move", true);
            animator.SetFloat("speed", 0f);
            animator.SetFloat("rotation", .5f);
        }
        else
        {
            animator.SetBool("move", false);
            animator.SetFloat("speed", 0f);
            animator.SetFloat("rotation", 0f);
        }

    }
}
