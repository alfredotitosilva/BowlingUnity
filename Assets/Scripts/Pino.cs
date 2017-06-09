using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pino : MonoBehaviour {

	private bool isFalled;
	private float inicial;

	// Use this for initialization
	void Start () {
		isFalled = false;
		inicial = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(!isFalled){
			if(transform.position.x != inicial){
				isFalled = true;
				ControleBola bola = GameObject.Find("Bola").GetComponent<ControleBola>();
				bola.totalCaidos();
			}
		}
	}
}
