using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoteCamera : MonoBehaviour
{
    public float rotationSpeed;
  

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
                
    }
}
