using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    [SerializeField]
    private float moveSpeed = 2.0f;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Forwards & Backwards movement
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            print("W key was pressed!");
        } else if (Input.GetKey("s"))
        {
            print("S key was pressed!");
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }

        //Left & Right movement
        if (Input.GetKey("a"))
        {
            print("a key was pressed");
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        } else if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            print("d key was pressed!");
        }
    }
}
