using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class powerUp : MonoBehaviour {
	public AudioClip clip;
	public score scoreincreament;

	public ParticleSystem pickUpEffect;
	public void OnTriggerEnter(Collider obj){
		if (obj.name=="aj") {
			
			pickUp ();
		}
	}
	public void pickUp()
	{
		
		Instantiate (pickUpEffect,transform.position,transform.rotation);
		scoreincreament.check = true;
		AudioSource.PlayClipAtPoint (clip, this.gameObject.transform.position);
	    GameObject.Destroy (gameObject);

	}
	void Update()
	{
		transform.Rotate (0,10,0);
	}
}
