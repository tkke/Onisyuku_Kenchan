using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int enemyHP = 100;
    // Use this for initialization
    void Start()
    {
        Debug.Log("敵のHPは" + enemyHP);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHP == 0)
        {
            Debug.Log("Clear");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        enemyHP--;
        Debug.Log("敵のHPは" + enemyHP);
    }
}
