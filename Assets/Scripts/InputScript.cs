using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputScript : MonoBehaviour
{
    private Rigidbody capsuleRigidBody;
    private PlayerInput playerInput;

    private void Awake()
    {
        capsuleRigidBody = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
    }
    public void Jump(InputAction.CallbackContext context)
    {
        if(capsuleRigidBody != null && context.performed) 
        { 
            Debug.Log("Jump Pressed!" + context.phase);
            capsuleRigidBody.velocity = Vector3.up;
        }
    }
}
