using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float delayTimeToFall = 3.0f;
    private bool hasFallen = false;

    // Update is called once per frame
    void Update()
    {
        if (!hasFallen && Time.time > delayTimeToFall) {
            hasFallen = true;
            GetComponent<Rigidbody>().useGravity = true;
            Debug.Log("This is the perfect time to into the void!");
        }
    }
}
