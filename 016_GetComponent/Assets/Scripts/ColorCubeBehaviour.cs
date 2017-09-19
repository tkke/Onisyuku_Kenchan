using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubeBehaviour : MonoBehaviour
{
    private RamdomColor _randomColor;
    private float _time = 0;
    public float interval = 1;
    private void Awake()
    {
        _randomColor = GetComponent<RamdomColor>();
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Renderer renderer = collision.gameObject.GetComponent<Renderer>();
        renderer.material.color = _randomColor.GetBodyColor();
        _randomColor.ChangeColor();
        _time = 0;

    }

}
