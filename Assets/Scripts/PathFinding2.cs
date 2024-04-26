using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinding2 : MonoBehaviour
{
    public GameObject Target;
    public float speed;
    public float distanceBetween;

    private float distance;

    private void Update()
    {
        distance = Vector2.Distance(transform.position, Target.transform.position);
        Vector2 direction = Target.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if(distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Target.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }
}
