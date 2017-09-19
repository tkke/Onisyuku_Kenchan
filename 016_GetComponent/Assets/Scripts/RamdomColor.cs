using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamdomColor : MonoBehaviour
{
    private Renderer _targetRenderer;

    private void Awake()
    {
        _targetRenderer = this.GetComponent<Renderer>();
        _targetRenderer.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
    }

    public Color GetBodyColor()
    {
        return _targetRenderer.material.color;
    }

    public void ChangeColor()
    {
        _targetRenderer.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
    }
}
