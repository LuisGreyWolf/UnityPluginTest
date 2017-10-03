using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Configuration;
using System.Security.Policy;

public class NewPlayMode : MonoBehaviour {
	public float speed = 5;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}
}
