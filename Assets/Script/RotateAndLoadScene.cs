using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RotateAndLoadScene : MonoBehaviour
{
    public float rotationSpeed = 100f; // speed
    public string sceneName = "NextScene"; 
    public float targetRotation = 3.3f; 
    public float tolerance = 1f; // 

    void Update()
    {
       
        float horizontalInput = Input.GetAxis("Horizontal");

       
        if (horizontalInput != 0)
        {
            transform.Rotate(0, horizontalInput * rotationSpeed * Time.deltaTime, 0);
        }

        // check y axis rotation
        if (Mathf.Abs(transform.eulerAngles.y - targetRotation) <= tolerance)
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        // load scene
        SceneManager.LoadScene(sceneName);
    }
}