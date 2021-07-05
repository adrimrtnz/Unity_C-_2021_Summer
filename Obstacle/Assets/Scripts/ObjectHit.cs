using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private Vector4 originalColor;
    private float delayInSeconds = 2.0f;

    private void Start() 
    {
        originalColor = GetComponent<MeshRenderer>().material.color;
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player") 
        {
            Debug.Log("Player bumped into a wall!");
            GetComponent<MeshRenderer>().material.color = Color.red;

            Invoke("SetColorToOriginal", delayInSeconds);
            
            gameObject.tag = "Obstacle";
        }
    }

    private void SetColorToOriginal() 
    {
        GetComponent<MeshRenderer>().material.color = originalColor;
    }
}