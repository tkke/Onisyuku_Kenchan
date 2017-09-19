using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);

        if (transform.position.z >= 150)
            SceneManager.LoadScene("Goal");
    }
}
