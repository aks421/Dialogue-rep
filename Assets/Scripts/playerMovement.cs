using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public CharacterController controller;
    public bool locked=false;
    public float speed = 8f;

    // Update is called once per frame
    void Update()
    {
        if(!locked) {
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);
        }
        
    }

    public void setSpeed(int s) {
        speed=s;

    }

    public void lockMovement() {
        locked=true;
    }
    public void unlockMovement() {
        locked=false;
    }
}