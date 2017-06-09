using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class SomBola : MonoBehaviour {

	public AudioClip audio;
	private AudioSource emitAudio;
	private bool init;

	// Use this for initialization
	void Start () {
		emitAudio = GetComponent<AudioSource> ();
		init = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("w") && !init) {
			init = true;
			emitAudio.clip = audio;//aqui seto audio para emissor
			emitAudio.Play();// aqui dou play no emissor de audio
		}
		
	}
}
