using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public float mouseSensitivity = 150f;
    public bool locked=false;
    [SerializeField]
    public Transform playerBody;

    float yRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void freeCursor ()
    {
        Cursor.lockState = CursorLockMode.None;

    }

    public void unFreeCursor() {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void lockCursor()
    {
        locked=true;
    }

    public void unlockCursor()
    {
        locked=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!locked) {
            //Get Mouse Coordinates
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            yRotation -= mouseY;
            yRotation = Mathf.Clamp(yRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(yRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
        
    }
}
