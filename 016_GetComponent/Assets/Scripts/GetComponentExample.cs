using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentExample : MonoBehaviour {
    private Rigidbody _rigidbody;
    private GameObject _parent;
    private GameObject _child;
    private Renderer _renderer;

    private void Awake()
    {
        _rigidbody = this.GetComponent<Rigidbody>();
        _parent = this.transform.parent.gameObject;
        _child = this.transform.Find("Child").gameObject;
    }
    // Use this for initialization
    void Start () {
        this.transform.position = new Vector3(0f, 5f, 0f);
        _renderer = GetComponent<Renderer>();
        _renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
