using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleBola : MonoBehaviour {

	private Rigidbody rb;
	private bool play = false;
	public float power;

	public int derrubados;
	public Text Placar;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		derrubados = 0;
		Placar.text = "";	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("a") && transform.position.x < 2.0f && !play){
			transform.Translate (0.1f, 0.0f, 0.0f);
		}
		if (Input.GetKey ("d") && transform.position.x > -2.0f && !play) {
			transform.Translate (-0.1f, 0.0f, 0.0f);
		}
		if (Input.GetKey ("w") && !play) {
			rb.AddForce (new Vector3 (0.0f, 0.0f, -Mathf.Abs(power)));
			play = true;
		}

		if(play && derrubados > 1){
			Placar.text = "Derrubou: " + derrubados.ToString() +" pinos.";
		}
	}

	public void totalCaidos(){
		derrubados++;
	}
}
