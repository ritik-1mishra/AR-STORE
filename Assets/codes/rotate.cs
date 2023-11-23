using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
 
    public float rotationSpeed = 5f;

    void Update()
    {
        // Rotate the object around its up axis (y-axis)
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}


