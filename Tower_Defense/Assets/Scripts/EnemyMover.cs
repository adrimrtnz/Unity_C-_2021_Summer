using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] [Range(0f,4f)] float speedFactor = 1f;
    [SerializeField] List<Waypoint> path = new List<Waypoint>();

    void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        foreach(Waypoint waypoint in path)
        {
            // Debug.Log(waypoint.name);

            Vector3 startPosition = transform.position;
            Vector3 endPosition = waypoint.transform.position;
            float travelPercent = 0f;

            // Make the object point at its destination point
            transform.LookAt(endPosition);

            while(travelPercent < 1f) {
                travelPercent += Time.deltaTime * speedFactor;
                transform.position = Vector3.Lerp(startPosition, endPosition, travelPercent);
                yield return new WaitForEndOfFrame();
            }
            
        }
    }
}