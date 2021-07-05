using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hitCounter = 0;

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Obstacle")
        {
            hitCounter++;
            Debug.Log("You've bumped into " + hitCounter  + " obstacles.");
        }
    }
}
