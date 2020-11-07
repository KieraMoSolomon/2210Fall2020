using System;
using UnityEngine;
public class StateBehaviour : MonoBehaviour
{
    private Animator animator;
    /*private CharacterController controller;
    public CharacterBrain brain;
    
    public float speed = 5;*/
    private void Start()
    {
        animator = GetComponent<Animator>();
        //controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        
        /*var position = brain.Move(speed);
        controller.Move(position);*/

        if (Input.GetKey(KeyCode.Q))
        {
            animator.SetFloat("Walk", 1.0f);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("Walk", -1f);
        }
        else
        {
            animator.SetFloat("Walk", 0f);
        }
        //if left key do backwardWalk
        //if right arrow do forwardWalk
        //if none, do idle
    }
}
