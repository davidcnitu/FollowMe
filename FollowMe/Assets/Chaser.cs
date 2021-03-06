using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Transform targetTransform;
    public float speed = 7;

    private void Start()
    {
        transform.position = new Vector3(2, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 displacementFromTarget = targetTransform.position - transform.position;
        Vector3 directionToTarget = displacementFromTarget.normalized;
        Vector3 velocity = directionToTarget * speed;

        float distanceToTarget = displacementFromTarget.magnitude;
        if (distanceToTarget > 2f)
        {
            transform.Translate(velocity * Time.deltaTime);
        }
    }
}
