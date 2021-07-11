using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xRotationSpeed = 0;
    [SerializeField] private float yRotationSpeed = 150.0f;
    [SerializeField] private float zRotationSpeed = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotationSpeed * Time.deltaTime, 
                         yRotationSpeed * Time.deltaTime, 
                         zRotationSpeed * Time.deltaTime);
    }
}