using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sens=100f;
    float xRot=0f;
    public Transform body;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

        xRot -=mouseY;

        xRot = Mathf.Clamp(xRot,-90f,90f);
        transform.localRotation = Quaternion.Euler(xRot,0f,0f);
        body.Rotate(Vector3.up*mouseX);
    }
}
