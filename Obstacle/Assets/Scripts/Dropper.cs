using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float delayTimeToFall = 3.0f;
    
    private MeshRenderer myRenderer;
    private Rigidbody myRigidbody;
    private bool canFall = false;

    private void Start() {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.enabled = false;

        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!canFall && Time.time > delayTimeToFall) 
        {
            canFall = true;
            
            Debug.Log("This is the perfect time to fall into the void!");
            
            myRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
