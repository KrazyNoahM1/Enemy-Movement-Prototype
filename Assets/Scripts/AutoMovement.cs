using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automovement : MonoBehaviour
{
    public float speed;
    private float startPosition;
    private int direction = 1;

    void Start()
    {
        startPosition = transform.position.x;
    }

    void Update()
    {
        float newPosition = transform.position.x + direction * speed * Time.deltaTime;


        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            direction *= -1;
        }
    }
}