using System;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class StateBehaviour : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 5;
    private Vector3 position = Vector3.zero;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        var direction = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        position.Set(direction, 0,0 );
        controller.Move(position);
        //if left key do backwardWalk
        //if right arrow do forwardWalk
        //if none, do idle
    }
}
