using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private Vector4 originalColor;
    private float delayInSeconds = 2.0f;

    private void OnCollisionEnter(Collision other) 
    {
        originalColor = GetComponent<MeshRenderer>().material.color;
        Debug.Log("Player bumped into a wall!");
        GetComponent<MeshRenderer>().material.color = Color.red;

        Invoke("SetColorToOriginal", delayInSeconds);
    }

    private void SetColorToOriginal() 
    {
        GetComponent<MeshRenderer>().material.color = originalColor;
    }
}