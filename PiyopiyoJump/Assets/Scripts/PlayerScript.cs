using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    int score = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 0);
            GetComponent<AudioSource>().Play();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
            Debug.Log("Game Over");
    }

    private void OnTriggerEnter(Collider other)
    {
        score++;
        Debug.Log(score);
    }
}
