using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    Rigidbody playerRigid;
    int count = 0;
    public int playerHP = 10;

    // Use this for initialization
    void Start() {
        playerRigid = gameObject.GetComponent<Rigidbody>();
        Debug.Log("プレイヤーのHPは" + playerHP);
    }

    // Update is called once per frame
    void Update() {
		if(playerRigid.velocity == new Vector3(0,0,0)){
            transform.Rotate(new Vector3(0, 5f, 0));
            if (Input.GetKey("up")){
				playerRigid.velocity = transform.forward * 50f;
                count++;
                Debug.Log(count.ToString());
            }
		}
        if (playerHP == 0)
        {
            Debug.Log("Game Over");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        playerHP--;
        Debug.Log("プレイヤーのHPは" + playerHP);
    }
}
