using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleCamera : MonoBehaviour {

	public GameObject Bola;
	private Vector3 offset;
	private float loopy = 0.0f;
	private float loopz = 0.0f;

	// Use this for initialization
	void Start () {
		offset = transform.position - Bola.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (Bola.transform.position.z > -23) {
			transform.position = Bola.transform.position + offset;
		}
	}
}
