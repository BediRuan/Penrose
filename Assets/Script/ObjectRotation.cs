using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    public float rotationSpeed = 100f; // speed

    private float xRotation = 0f; // x angle of rotation
    private float zRotation = 0f; 

    void Update()
    {
        // X rotation
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            xRotation -= rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            xRotation += rotationSpeed * Time.deltaTime;
        }

        // Z rotation
        if (Input.GetKey(KeyCode.UpArrow))
        {
            zRotation += rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            zRotation -= rotationSpeed * Time.deltaTime;
        }

        // Limit the range of rotation
        xRotation = Mathf.Clamp(xRotation, -8f, 8f);
        zRotation = Mathf.Clamp(zRotation, -8f, 8f);

        // apply rotation
        transform.rotation = Quaternion.Euler(xRotation, 0f, zRotation);
    }
}
