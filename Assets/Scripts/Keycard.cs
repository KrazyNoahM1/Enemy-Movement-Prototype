using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycard : MonoBehaviour
{
    GameObject temp;

    [SerializeField] AudioClip open;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<AudioSource>();
        temp = GameObject.FindGameObjectWithTag("temp");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(open, 1f);
            Destroy(gameObject);
            Destroy(temp);
        }
    }
}
